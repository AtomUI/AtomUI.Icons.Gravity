using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using Avalonia.VisualTree;
using GravityGallery.Controls;
using GravityGallery.Workspace.ViewModels;
using GravityGallery.Workspace.Views;
using ReactiveUI;

namespace GravityGallery.Tests;

public class IconGalleryThemeTests
{
    [Fact]
    public void Control_themes_resolve_design_values_from_tokens()
    {
        AvaloniaTestApp.EnsureInitialized();
        using var workspace = new WorkspaceWindowViewModel();
        var navigation = new CaseNavigation { ViewModel = workspace.CaseNavigation };
        using var shell = new GalleryShellView(GravityGalleryModule.GetConfiguration(), navigation, workspace.Router);
        var window = new Avalonia.Controls.Window { Width = 1300, Height = 900, Content = shell };

        try
        {
            window.Show();
            Dispatcher.UIThread.RunJobs();
            workspace.CaseNavigation.NavigateToCommand.Execute("Arrows").Subscribe();
            Dispatcher.UIThread.RunJobs();
            var gallery = shell.GetVisualDescendants().OfType<IconGallery>().Single();
            gallery.ApplyTemplate();
            Dispatcher.UIThread.RunJobs();

            // 图标卡片：IconGallery 的控件 Token 与经 IconInfoItemTokenResource 读取的全局 Token
            var item = gallery.GetVisualDescendants().OfType<IconInfoItem>().First();
            item.Width.ShouldBe(150);
            item.Padding.ShouldBe(new Thickness(8));
            item.CornerRadius.ShouldBe(new CornerRadius(6));
            item.FontSize.ShouldBe(12);
            item.IsMotionEnabled.ShouldBeTrue();
            item.GetVisualDescendants().OfType<StackPanel>().First().Spacing.ShouldBe(24);
            var presenter = item.GetVisualDescendants().OfType<IconPresenter>().First();
            presenter.Bounds.Width.ShouldBe(48);
            presenter.Bounds.Height.ShouldBe(48);

            // 空状态：全局 Token 加 IconGallery 自己的 EmptyTitleFontSize
            var emptyState = gallery.GetVisualDescendants()
                                    .OfType<Border>()
                                    .Single(border => border.Name == "IconGalleryEmptyState");
            emptyState.Padding.ShouldBe(new Thickness(24));
            var emptyPanel = emptyState.GetVisualDescendants().OfType<StackPanel>().First();
            emptyPanel.Spacing.ShouldBe(8);
            emptyPanel.GetVisualDescendants()
                      .OfType<AtomUI.Desktop.Controls.TextBlock>()
                      .First()
                      .FontSize.ShouldBe(18);

            gallery.GetVisualDescendants().OfType<SearchEdit>().Single().Margin.ShouldBe(new Thickness(0, 8, 8, 8));
        }
        finally
        {
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }
}
