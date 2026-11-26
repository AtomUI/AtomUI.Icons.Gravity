using AtomUI;
using AtomUI.DesignLanguages.AntDesign;
using AtomUI.Desktop.Controls;
using AtomUI.Desktop.Controls.Themes.AntDesign;
using AtomUI.Toolkits.GalleryBase;
using Avalonia;
using Avalonia.Headless;
using ReactiveUI.Avalonia;

[assembly: AvaloniaTestApplication(typeof(GravityGallery.Tests.TestAppBuilder))]
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace GravityGallery.Tests;

internal static class AvaloniaTestApp
{
    private static int _initialized;

    public static void EnsureInitialized()
    {
        if (Interlocked.CompareExchange(ref _initialized, 1, 0) != 0)
        {
            return;
        }

        try
        {
            TestAppBuilder.BuildAvaloniaApp().SetupWithoutStarting();
        }
        catch
        {
            Volatile.Write(ref _initialized, 0);
            throw;
        }
    }
}

public static class TestAppBuilder
{
    public static AppBuilder BuildAvaloniaApp()
    {
        // 与桌面宿主 GalleryApplication.Configure 保持同一组合：共享库不能引用语言包，语言由宿主启用
        return AppBuilder.Configure<TestApplication>()
                         .UseHeadless(new AvaloniaHeadlessPlatformOptions())
                         .UseReactiveUI(build =>
                             build.ConfigureViewLocator(locator =>
                                 global::GravityGallery.GravityGalleryModule.RegisterViews(locator)))
                         .UseAtomUI(builder =>
                         {
                             BaseGalleryApplication.ConfigureCore(builder);
                             builder.UseAntDesign(ant =>
                             {
                                 ant.WithDefaultTheme(AntDesignThemes.DaybreakBlue);
                                 ant.AddDesktopControls();
                             });
                             builder.WithInitialDesignLanguage<AntDesignLanguage>();
                         });
    }
}

internal sealed partial class TestApplication : Application;
