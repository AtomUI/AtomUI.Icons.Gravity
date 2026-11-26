using System.Reactive.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Xml.Linq;
using AtomUI;
using AtomUI.Theme;
using AtomUI.Theme.Resources;
using AtomUI.Toolkits.GalleryBase.Shell;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.Threading;
using GravityGallery.Workspace;
using GravityGallery.Workspace.ViewModels;
using GravityGallery.Workspace.Views;
using MenuSeparator = AtomUI.Desktop.Controls.MenuSeparator;
using MenuItem = AtomUI.Desktop.Controls.MenuItem;
using ToolTip = AtomUI.Desktop.Controls.ToolTip;

namespace GravityGallery.Tests;

public class ThemeMenuTests
{
    private const string TitleBarMenuResourceKey = "WorkspaceTitleBarMenu";

    private static readonly Color DaybreakBlue = Color.Parse("#1677FF");
    private static readonly Color PolarGreen   = Color.Parse("#52C41A");

    [Fact]
    public void Title_bar_theme_menu_has_the_AtomUI_Gallery_structure()
    {
        var document = XDocument.Load(RepoFile("gallery/GravityGallery/Workspace/Views/WorkspaceWindow.axaml"));
        var ns       = document.Root!.Name.Namespace;
        var theme    = document.Descendants(ns + "MenuItem").Single(item => HeaderOf(item) == "MenuItemTheme");

        theme.Elements().Select(HeaderOf).ShouldBe(
        [
            "MenuItemDesignLanguage", "MenuItemBrandColor", "MenuItemNeutralColor", null,
            "MenuItemAppearance", "MenuItemCompactMode", "MenuItemOtherThemes", "MenuItemEnableMotion", "MenuItemEnableWaveSpirit"
        ]);
        theme.Elements().Single(element => element.Name == ns + "MenuSeparator").ShouldNotBeNull();
        theme.Elements().Select(TagOf).ShouldBe(
        [
            "ThemeCatalog", "BrandColor", "NeutralColor", null,
            null, "Compact", "OtherThemes", "Motion", "WaveSpirit"
        ]);

        var appearance = theme.Elements().Single(element => HeaderOf(element) == "MenuItemAppearance");
        var modes      = appearance.Elements().ToList();
        modes.Select(HeaderOf).ShouldBe(["MenuItemLightMode", "MenuItemDarkMode", "MenuItemFollowSystem"]);
        modes.Select(TagOf).ShouldBe(["LightMode", "DarkMode", "FollowSystem"]);
        modes.Select(element => (string?)element.Attribute("ToggleType")).ShouldAllBe(value => value == "Radio");
        modes.Select(element => (string?)element.Attribute("GroupName")).ShouldAllBe(value => value == "ThemeAppearance");
        modes.Select(element => (string?)element.Attribute("IsChecked")).ShouldBe(
            ["{Binding IsLightAppearanceMode}", "{Binding IsDarkAppearanceMode}", "{Binding IsSystemAppearanceMode}"]);
    }

    [Fact]
    public async Task Theme_menu_lists_the_design_language_and_the_brand_color_swatches()
    {
        AvaloniaTestApp.EnsureInitialized();
        var viewModel = new WorkspaceWindowViewModel();
        var (languageItem, brandItem, neutralItem, otherItem) = (new MenuItem(), new MenuItem(), new MenuItem(), new MenuItem());
        using var menu = new GalleryThemeMenu(viewModel, languageItem, brandItem, neutralItem, otherItem);
        try
        {
            // Gravity 只启用 Ant Design：设计语言子菜单只有一项，并且处于选中状态。
            viewModel.DesignLanguages.ShouldBe(["AntDesign"]);
            var languages = languageItem.Items.OfType<MenuItem>().ToList();
            languages.Select(item => (string?)item.Tag).ShouldBe(["AntDesign"]);
            languages.Single().IsChecked.ShouldBeTrue();

            // 品牌色：语言默认主题的基础色排在首位并被选中，其后是 Ant 命名色与 Tailwind 色阶，最后是分隔线与重置。
            viewModel.CanChooseBrandColor.ShouldBeTrue();
            brandItem.IsEnabled.ShouldBeTrue();
            var swatches = brandItem.Items.OfType<MenuItem>().Where(item => item.Tag is not null).ToList();
            swatches.Count.ShouldBe(1 + (GalleryBrandSwatches.AntNamed.Count - 1) + GalleryBrandSwatches.Tailwind500.Count);
            swatches[0].Tag.ShouldBe(DaybreakBlue);
            swatches[0].IsChecked.ShouldBeTrue();
            swatches.Select(item => (Color)item.Tag!)
                    .ShouldBe(GalleryBrandSwatches.AntNamed.Concat(GalleryBrandSwatches.Tailwind500)
                                      .Select(swatch => swatch.Color)
                                      .Distinct());
            swatches.ShouldAllBe(item => item.ToggleType == MenuItemToggleType.Radio && item.GroupName == "ThemeBrandColor");
            brandItem.Items.OfType<MenuSeparator>().Count().ShouldBe(1);
            var reset = brandItem.Items.OfType<MenuItem>().Single(item => item.Tag is null);
            reset.IsEnabled.ShouldBeFalse("reset is disabled while the theme's own color is in use");

            // 中性色：Ant Design 不支持更换中性色，子菜单禁用并用工具提示说明原因。
            viewModel.CanChooseNeutralColor.ShouldBeFalse();
            neutralItem.IsEnabled.ShouldBeFalse();
            neutralItem.Items.Count.ShouldBe(0);
            ToolTip.GetTip(neutralItem).ShouldNotBeNull();
            ToolTip.GetShowOnDisabled(neutralItem).ShouldBeTrue();

            // 其他主题只列出带名字的主题文件，语言自带的默认条目不在这里。
            otherItem.Items.OfType<MenuItem>()
                      .Select(item => (string?)item.CommandParameter)
                      .ShouldBe(viewModel.AvailableThemes.Where(theme => !theme.IsLanguageDefault)
                                         .Select(theme => theme.Id));

            // 选择一个品牌色：视图模型记住它，单选项跟随，重置变为可用。
            await viewModel.SetBrandColorCommand.Execute(PolarGreen).ToTask();
            Dispatcher.UIThread.RunJobs();

            viewModel.BrandColor.ShouldBe(PolarGreen);
            brandItem.Items.OfType<MenuItem>().Single(item => item.IsChecked).Tag.ShouldBe(PolarGreen);
            brandItem.Items.OfType<MenuItem>().Single(item => item.Tag is null).IsEnabled.ShouldBeTrue();
        }
        finally
        {
            await viewModel.SetBrandColorCommand.Execute(null).ToTask();
            Dispatcher.UIThread.RunJobs();
            viewModel.Dispose();
        }
    }

    [Fact]
    public async Task Appearance_menu_items_switch_light_dark_and_follow_system()
    {
        AvaloniaTestApp.EnsureInitialized();
        var manager = Application.Current!.GetThemeManager()!;
        var window  = new WorkspaceWindow();
        try
        {
            window.Show();
            Dispatcher.UIThread.RunJobs();
            var viewModel = window.ViewModel!;
            var original  = viewModel.AppearanceMode;
            OpenAppearanceMenu(window);

            foreach (var (kind, preference, appearance) in new[]
                     {
                         (WindowMenuItemKind.DarkMode, ThemePreference.Dark, ThemeAppearance.Dark),
                         (WindowMenuItemKind.LightMode, ThemePreference.Light, ThemeAppearance.Light)
                     })
            {
                Click(window, kind);
                HeadlessWait.Until(window, () => viewModel.AppearanceMode == preference)
                            .ShouldBeTrue($"clicking {kind} should switch the appearance");
                Dispatcher.UIThread.RunJobs();

                ItemOf(window, kind).IsChecked.ShouldBeTrue();
                manager.CurrentSelection!.Appearance.ShouldBe(appearance);
            }

            Click(window, WindowMenuItemKind.FollowSystem);
            HeadlessWait.Until(window, () => viewModel.AppearanceMode == ThemePreference.System)
                        .ShouldBeTrue("clicking FollowSystem should follow the system appearance");
            Dispatcher.UIThread.RunJobs();

            // 跟随系统：视图模型解析出当前的系统外观并写入具体的外观值，菜单上记住的是“跟随系统”。
            ItemOf(window, WindowMenuItemKind.FollowSystem).IsChecked.ShouldBeTrue();
            ItemOf(window, WindowMenuItemKind.LightMode).IsChecked.ShouldBeFalse();
            ItemOf(window, WindowMenuItemKind.DarkMode).IsChecked.ShouldBeFalse();
            manager.CurrentSelection!.Appearance.ShouldNotBeNull();

            await viewModel.SetAppearanceModeCommand.Execute(original).ToTask();
            Dispatcher.UIThread.RunJobs();
            viewModel.AppearanceMode.ShouldBe(original);
        }
        finally
        {
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    [Fact]
    public async Task Motion_and_wave_spirit_menu_items_stay_in_sync()
    {
        AvaloniaTestApp.EnsureInitialized();
        var manager = Application.Current!.GetThemeManager()!;
        var window  = new WorkspaceWindow();
        try
        {
            window.Show();
            Dispatcher.UIThread.RunJobs();
            var viewModel  = window.ViewModel!;
            OpenThemeMenu(window);
            var motion     = ItemOf(window, WindowMenuItemKind.Motion);
            var waveSpirit = ItemOf(window, WindowMenuItemKind.WaveSpirit);
            motion.IsChecked.ShouldBeTrue();
            waveSpirit.IsChecked.ShouldBeTrue();

            // 关闭动效时一并关闭波浪动画。
            motion.IsChecked = false;
            motion.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent));
            waveSpirit.IsChecked.ShouldBeFalse();
            HeadlessWait.Until(window, () => !EffectiveToken<bool>(motion, SharedTokenKind.EnableMotion))
                        .ShouldBeTrue("the theme should turn motion off");
            EffectiveToken<bool>(motion, SharedTokenKind.EnableWaveSpirit).ShouldBeFalse();
            manager.CurrentSelection!.Seeds[nameof(SharedTokenKind.EnableMotion)].ShouldBe("false");
            manager.CurrentSelection.Seeds[nameof(SharedTokenKind.EnableWaveSpirit)].ShouldBe("false");

            // 开启波浪动画时把动效一并打开。
            waveSpirit.IsChecked = true;
            waveSpirit.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent));
            motion.IsChecked.ShouldBeTrue();
            HeadlessWait.Until(window, () => EffectiveToken<bool>(motion, SharedTokenKind.EnableWaveSpirit))
                        .ShouldBeTrue("the theme should turn wave spirit on");
            EffectiveToken<bool>(motion, SharedTokenKind.EnableMotion).ShouldBeTrue();
        }
        finally
        {
            await window.ViewModel!.ToggleMotionCommand.Execute(true).ToTask();
            await window.ViewModel.ToggleWaveSpiritCommand.Execute(true).ToTask();
            Dispatcher.UIThread.RunJobs();
            window.Close();
            Dispatcher.UIThread.RunJobs();
        }
    }

    [Fact]
    public void Theme_menu_commands_do_not_forward_CanExecuteChanged_to_menu_items()
    {
        var innerCommand  = new RecordingCommand();
        var stableCommand = CreateStableThemeCommand(innerCommand);
        var raiseCount    = 0;
        stableCommand.CanExecuteChanged += (_, _) => raiseCount++;

        innerCommand.RaiseCanExecuteChanged();

        raiseCount.ShouldBe(0);
        stableCommand.CanExecute(DaybreakBlue).ShouldBeTrue();
        stableCommand.Execute(DaybreakBlue);
        innerCommand.ExecuteParameters.ShouldBe([DaybreakBlue]);
    }

    // 只有登记在主题 schema 里的控件类型才能读取生效的 Token，窗口类型不行，这里用菜单项本身。
    private static T EffectiveToken<T>(MenuItem owner, SharedTokenKind kind)
    {
        return ControlTokenAccessor.Capture(owner).GetEffectiveGlobal<T>(kind);
    }

    private static MenuItem ItemOf(Window window, WindowMenuItemKind kind)
    {
        return Descendants(ThemeMenu(window)).Single(item => Equals(item.Tag, kind));
    }

    // 子菜单弹出后，其中的菜单项才进入可视树，路由事件才能到达窗口上的处理器。
    private static MenuItem OpenThemeMenu(Window window)
    {
        var themeItem = ThemeMenu(window);
        themeItem.IsSubMenuOpen = true;
        Dispatcher.UIThread.RunJobs();
        return themeItem;
    }

    private static void OpenAppearanceMenu(Window window)
    {
        var appearance = OpenThemeMenu(window).Items.OfType<MenuItem>()
                                              .Single(item => item.Items.OfType<MenuItem>()
                                                                .Any(child => Equals(child.Tag, WindowMenuItemKind.LightMode)));
        appearance.IsSubMenuOpen = true;
        Dispatcher.UIThread.RunJobs();
    }

    private static void Click(Window window, WindowMenuItemKind kind)
    {
        var item = ItemOf(window, kind);
        item.IsChecked = !item.IsChecked;
        item.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent));
    }

    private static MenuItem ThemeMenu(Window window)
    {
        var menu = window.Resources[TitleBarMenuResourceKey].ShouldBeOfType<AtomUI.Desktop.Controls.Menu>();
        return menu.Items.OfType<MenuItem>()
                     .Single(item => Descendants(item).Any(child => Equals(child.Tag, WindowMenuItemKind.BrandColor)));
    }

    private static IEnumerable<MenuItem> Descendants(MenuItem item)
    {
        foreach (var child in item.Items.OfType<MenuItem>())
        {
            yield return child;

            foreach (var descendant in Descendants(child))
            {
                yield return descendant;
            }
        }
    }

    private static string? HeaderOf(XElement element)
    {
        var header = (string?)element.Attribute("Header");
        return header is null ? null : Regex.Match(header, @"(\w+)\s*\}$").Groups[1].Value;
    }

    private static string? TagOf(XElement element)
    {
        var tag = (string?)element.Attribute("Tag");
        return tag is null ? null : Regex.Match(tag, @"(\w+)\}$").Groups[1].Value;
    }

    private static string RepoFile(string relativePath)
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null)
        {
            if (File.Exists(Path.Combine(directory.FullName, "Gravity.slnx")))
            {
                return Path.Combine(directory.FullName, relativePath);
            }

            directory = directory.Parent;
        }

        throw new FileNotFoundException($"Could not locate the repository root above {AppContext.BaseDirectory}");
    }

    private static ICommand CreateStableThemeCommand(ICommand innerCommand)
    {
        var commandType = typeof(GalleryThemeMenu).GetNestedType("StableCommand", BindingFlags.NonPublic);
        commandType.ShouldNotBeNull();
        var constructor = commandType!.GetConstructor(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
            binder: null,
            types: [typeof(ICommand)],
            modifiers: null);
        constructor.ShouldNotBeNull();
        return (ICommand)constructor.Invoke([innerCommand]);
    }

    private sealed class RecordingCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public List<object?> ExecuteParameters { get; } = [];

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            ExecuteParameters.Add(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
