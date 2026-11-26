using AtomUI;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Localization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using Avalonia.VisualTree;
using GravityGallery.Controls;
using GravityGallery.Features.IconCatalog;
using GravityGallery.Models;
using GravityGallery.Workspace.ViewModels;
using GravityGallery.Workspace.Views;
using ReactiveUI;
using ScrollViewer = AtomUI.Desktop.Controls.ScrollViewer;

namespace GravityGallery.Tests;

public class IconGalleryInteractionTests
{
    [Fact]
    public void Repository_supports_Gravity_themes_categories_search_and_96_item_batches()
    {
        var repository = new IconInfoRepository();

        foreach (var theme in GravityThemes)
        {
            repository.Category = "Arrows";
            repository.IconTheme = theme;
            repository.Filter = null;
            repository.RefreshIconInfos();

            var total = repository.MatchedIconCount;
            total.ShouldBeGreaterThan(0, theme.ToString());
            var initial = repository.ActivatedIconInfos!.ToArray();
            initial.Length.ShouldBe(Math.Min(96, total), theme.ToString());
            initial.ShouldAllBe(info => info.Category == "Arrows" && info.ThemeType == theme);

            repository.LoadMoreIconInfos();
            repository.ActivatedIconInfos!.Count().ShouldBe(Math.Min(192, total), theme.ToString());
        }

        repository.Category = "Status";
        repository.IconTheme = IconThemeType.Outlined;
        repository.Filter = "ALARM";
        repository.ActivatedIconInfos.ShouldNotBeNull();
        repository.ActivatedIconInfos.ShouldNotBeEmpty();
        repository.ActivatedIconInfos!.ShouldAllBe(info =>
            info.Category == "Status" &&
            info.Name.Contains("alarm", StringComparison.InvariantCultureIgnoreCase));
        repository.MatchedIconCount.ShouldBeGreaterThanOrEqualTo(repository.ActivatedIconInfos.Count());
        repository.HasMatches.ShouldBeTrue();

        repository.Filter = "__definitely_missing_icon__";
        repository.MatchedIconCount.ShouldBe(0);
        repository.HasMatches.ShouldBeFalse();
        repository.ActivatedIconInfos.ShouldBeEmpty();
    }

    [Fact]
    public void Repository_reset_releases_icons_from_the_previous_result_set()
    {
        var repository = new IconInfoRepository
        {
            Category = "Arrows",
            IconTheme = IconThemeType.Outlined
        };
        repository.RefreshIconInfos();
        var previous = repository.ActivatedIconInfos!.ToArray();
        previous.ShouldNotBeEmpty();
        previous.ShouldAllBe(info => info.Icon != null);

        repository.Category = "Layout";

        var afterCategory = repository.ActivatedIconInfos!.ToArray();
        afterCategory.ShouldNotBeEmpty();
        repository.IconTheme = IconThemeType.Filled;
        var afterTheme = repository.ActivatedIconInfos!.ToArray();
        afterTheme.ShouldNotBeEmpty();
        repository.Filter = "PIN";

        previous.ShouldAllBe(info => info.Icon == null);
        afterCategory.ShouldAllBe(info => info.Icon == null);
        afterTheme.ShouldAllBe(info => info.Icon == null);
        repository.MatchedIconCount.ShouldBeGreaterThan(0);
        repository.ActivatedIconInfos!.ShouldAllBe(info =>
            info.Category == "Layout" &&
            info.ThemeType == IconThemeType.Filled &&
            info.Name.Contains("pin", StringComparison.InvariantCultureIgnoreCase));
    }

    [Fact]
    public void Gallery_search_and_result_changes_reset_the_scroll_position()
    {
        AvaloniaTestApp.EnsureInitialized();
        var repository = new IconInfoRepository();
        var gallery = new IconGallery
        {
            Category = "Status",
            IconTheme = IconThemeType.Outlined,
            IconInfoRepository = repository
        };
        using var host = Show(gallery, 800, 500);
        var scrollViewer = FindGalleryScrollViewer(gallery);
        scrollViewer.Offset = new Vector(0, 200);

        var search = gallery.GetVisualDescendants().OfType<SearchEdit>().Single();
        search.RaiseEvent(new SearchRequestedEventArgs(
            SearchEdit.SearchRequestedEvent,
            search,
            "  alarm  ",
            SearchTriggerSource.Button));
        Dispatcher.UIThread.RunJobs();

        repository.Filter.ShouldBe("alarm");
        scrollViewer.Offset.Y.ShouldBe(0);
        repository.MatchedIconCount.ShouldBe(1);
        repository.ActivatedIconInfos!.ShouldAllBe(info =>
            info.Name.Contains("alarm", StringComparison.InvariantCultureIgnoreCase));

        scrollViewer.Offset = new Vector(0, 100);
        gallery.Category = "Layout";
        Dispatcher.UIThread.RunJobs();
        scrollViewer.Offset.Y.ShouldBe(0);

        scrollViewer.Offset = new Vector(0, 100);
        gallery.IconTheme = IconThemeType.Filled;
        Dispatcher.UIThread.RunJobs();
        scrollViewer.Offset.Y.ShouldBe(0);
    }

    [Fact]
    public async Task Only_the_latest_successful_copy_request_shows_feedback()
    {
        AvaloniaTestApp.EnsureInitialized();
        var writes = new Dictionary<string, TaskCompletionSource>();
        var feedback = new List<string>();
        var page = new IconCatalogPage(
            (text, _) => (writes[text] = new TaskCompletionSource()).Task,
            feedback.Add);
        using var host = Show(page, 800, 500);

        var first = page.RequestCopyAsync("AlarmFilled");
        var second = page.RequestCopyAsync("GearOutlined");
        writes["GearOutlined"].SetResult();
        (await second).ShouldBeTrue();
        writes["AlarmFilled"].SetResult();
        (await first).ShouldBeFalse();

        feedback.ShouldBe(["<GearOutlined /> copied 🎉"]);
    }

    [Fact]
    public async Task Missing_or_failed_clipboard_and_detachment_never_show_success()
    {
        AvaloniaTestApp.EnsureInitialized();

        var missingFeedback = new List<string>();
        var missingPage = new IconCatalogPage(null, missingFeedback.Add);
        using (var missingHost = Show(missingPage, 800, 500))
        {
            (await missingPage.RequestCopyAsync("AlarmFilled")).ShouldBeFalse();
            missingFeedback.ShouldBeEmpty();
        }

        var failedFeedback = new List<string>();
        var failedPage = new IconCatalogPage(
            (_, _) => Task.FromException(new InvalidOperationException("clipboard unavailable")),
            failedFeedback.Add);
        using (var failedHost = Show(failedPage, 800, 500))
        {
            (await failedPage.RequestCopyAsync("AlarmFilled")).ShouldBeFalse();
            failedFeedback.ShouldBeEmpty();
        }

        var deferred = new TaskCompletionSource();
        var detachedFeedback = new List<string>();
        var detachedPage = new IconCatalogPage((_, _) => deferred.Task, detachedFeedback.Add);
        using var detachedHost = Show(detachedPage, 800, 500);
        var pending = detachedPage.RequestCopyAsync("AlarmFilled");
        detachedHost.Window.Content = null;
        Dispatcher.UIThread.RunJobs();
        deferred.SetResult();

        (await pending).ShouldBeFalse();
        detachedFeedback.ShouldBeEmpty();
    }

    [Fact]
    public void Catalog_header_shows_title_count_and_two_persistent_theme_choices()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();
        using var viewModel = new IconCatalogPageViewModel(workspace, "Arrows");
        var page = new IconCatalogPage { DataContext = viewModel };
        using var host = Show(page, 1020, 620);

        page.FindControl<AtomUI.Desktop.Controls.TextBlock>("CategoryTitle")!.Text.ShouldBe("Arrows");
        page.FindControl<AtomUI.Desktop.Controls.TextBlock>("ResultCount")!.Text.ShouldNotBeNullOrWhiteSpace();
        var selector = page.FindControl<Segmented>("IconThemeSelector")!;
        selector.Items.Count.ShouldBe(2);
        selector.SelectedIndex.ShouldBe(0);
        var selectorRight = selector.TranslatePoint(new Point(selector.Bounds.Width, 0), page)
                                    .ShouldNotBeNull()
                                    .X;
        selectorRight.ShouldBe(page.Bounds.Width - 24, tolerance: 1);

        selector.SelectedIndex = 1;
        Dispatcher.UIThread.RunJobs();
        workspace.IconTheme.ShouldBe(IconThemeType.Filled);

        using var nextViewModel = new IconCatalogPageViewModel(workspace, "Layout");
        nextViewModel.SelectedThemeIndex.ShouldBe(1);
    }

    [Fact]
    public void Catalog_header_wraps_at_narrow_width_and_empty_state_preserves_controls()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();
        using var viewModel = new IconCatalogPageViewModel(workspace, "Arrows");
        var page = new IconCatalogPage { DataContext = viewModel };
        using var host = Show(page, 760, 560);

        var title = page.FindControl<AtomUI.Desktop.Controls.TextBlock>("CategoryTitle")!;
        var selector = page.FindControl<Segmented>("IconThemeSelector")!;

        // Gravity 只有两个主题，760 宽时选择器与标题同行
        var sameRowTopLeft = selector.TranslatePoint(default, page).ShouldNotBeNull();
        sameRowTopLeft.Y.ShouldBeLessThan(title.TranslatePoint(new Point(0, title.Bounds.Height), page).ShouldNotBeNull().Y);
        (sameRowTopLeft.X + selector.Bounds.Width).ShouldBeLessThanOrEqualTo(page.Bounds.Width);

        // 窗口继续变窄时，选择器换行到标题下方，而不是压缩标签
        host.Window.Width = 360;
        Dispatcher.UIThread.RunJobs();
        var selectorTopLeft = selector.TranslatePoint(default, page).ShouldNotBeNull();
        var titleBottomLeft = title.TranslatePoint(new Point(0, title.Bounds.Height), page).ShouldNotBeNull();
        (selectorTopLeft.X + selector.Bounds.Width).ShouldBeLessThanOrEqualTo(page.Bounds.Width);
        selectorTopLeft.Y.ShouldBeGreaterThanOrEqualTo(titleBottomLeft.Y);

        var gallery = page.FindControl<IconGallery>("CatalogGallery")!;
        var search = gallery.GetVisualDescendants().OfType<SearchEdit>().Single();
        search.RaiseEvent(new SearchRequestedEventArgs(
            SearchEdit.SearchRequestedEvent,
            search,
            "__definitely_missing_icon__",
            SearchTriggerSource.Button));
        Dispatcher.UIThread.RunJobs();

        page.GetVisualDescendants()
            .OfType<Border>()
            .Single(control => control.Name == "IconGalleryEmptyState")
            .IsVisible.ShouldBeTrue();
        search.IsVisible.ShouldBeTrue();
        selector.IsVisible.ShouldBeTrue();
    }

    [Fact]
    public async Task Removed_catalog_route_cannot_report_copy_success_after_new_route_is_active()
    {
        AvaloniaTestApp.EnsureInitialized();
        var oldWrite = new TaskCompletionSource();
        var feedback = new List<string>();
        var oldPage = new IconCatalogPage((_, _) => oldWrite.Task, feedback.Add);
        using var host = Show(oldPage, 800, 500);
        var oldRequest = oldPage.RequestCopyAsync("AlarmFilled");

        var newPage = new IconCatalogPage((_, _) => Task.CompletedTask, feedback.Add);
        host.Window.Content = newPage;
        Dispatcher.UIThread.RunJobs();
        (await newPage.RequestCopyAsync("GearOutlined")).ShouldBeTrue();
        oldWrite.SetResult();

        (await oldRequest).ShouldBeFalse();
        feedback.ShouldBe(["<GearOutlined /> copied 🎉"]);
    }

    [Fact]
    public void Catalog_title_tracks_language_until_view_model_is_disposed()
    {
        AvaloniaTestApp.EnsureInitialized();
        var manager = Application.Current!.GetLanguageManager()!;
        manager.ChangeLanguage(LanguageTags.EnUS);
        using var workspace = new WorkspaceWindowViewModel();
        var viewModel = new IconCatalogPageViewModel(workspace, "Arrows");

        viewModel.CategoryTitle.ShouldBe("Arrows");
        manager.ChangeLanguage(LanguageTags.ZhCN);
        viewModel.CategoryTitle.ShouldBe("箭头");

        viewModel.Dispose();
        manager.ChangeLanguage(LanguageTags.EnUS);
        viewModel.CategoryTitle.ShouldBe("箭头");
    }

    [Fact]
    public void Navigating_to_another_category_disposes_the_removed_catalog_session()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();

        workspace.CaseNavigation.NavigateToCommand.Execute("Arrows").Subscribe();
        Dispatcher.UIThread.RunJobs();
        var first = workspace.Router.NavigationStack[0].ShouldBeOfType<IconCatalogPageViewModel>();
        first.IconInfoRepository.MatchedIconCount.ShouldBeGreaterThan(0);

        workspace.CaseNavigation.NavigateToCommand.Execute("Layout").Subscribe();
        Dispatcher.UIThread.RunJobs();

        workspace.Router.NavigationStack[0].ShouldBeOfType<IconCatalogPageViewModel>()
                 .Category.ShouldBe("Layout");
        first.IconInfoRepository.MatchedIconCount.ShouldBe(0);
        first.IconInfoRepository.HasMatches.ShouldBeFalse();
    }

    // Gravity 只有上游的 regular（Outlined）与 fill（Filled）两种风格
    private static readonly IconThemeType[] GravityThemes =
    [
        IconThemeType.Filled,
        IconThemeType.Outlined
    ];

    private static ScrollViewer FindGalleryScrollViewer(Control gallery)
    {
        return gallery.GetVisualDescendants()
                      .OfType<ScrollViewer>()
                      .Single(viewer =>
                          viewer.Name == "PART_ScrollViewer" &&
                          ReferenceEquals(viewer.TemplatedParent, gallery));
    }

    private static WindowContext Show(Control content, double width, double height)
    {
        var window = new Avalonia.Controls.Window { Width = width, Height = height, Content = content };
        window.Show();
        Dispatcher.UIThread.RunJobs();
        content.ApplyTemplate();
        Dispatcher.UIThread.RunJobs();
        return new WindowContext(window);
    }

    private sealed class WindowContext(Avalonia.Controls.Window window) : IDisposable
    {
        public Avalonia.Controls.Window Window { get; } = window;

        public void Dispose()
        {
            Window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }
}
