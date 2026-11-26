using AtomUI.Controls;
using AtomUI.Icons.AntDesign;
using AtomUI.Toolkits.GalleryBase.Configuration;
using AtomUI.Toolkits.GalleryBase.Localization;
using AtomUI.Toolkits.GalleryBase.Routing;
using Avalonia.Controls;
using GravityGallery.Features.Community;
using GravityGallery.Features.IconCatalog;
using GravityGallery.Features.Overview;
using GravityGallery.Localization;
using GravityGallery.Models;
using ReactiveUI;

namespace GravityGallery;

public static class GravityGalleryModule
{
    internal const string CategoriesNavigationKey = "Categories";

    private static readonly Lazy<IReadOnlyList<GalleryRouteDescriptor>> RouteDescriptors =
        new(CreateRouteDescriptors);

    public static GalleryBaseConfiguration CreateConfiguration()
    {
        var options = new GalleryBaseOptions();
        Configure(options);
        return options.BuildConfiguration();
    }

    public static GalleryBaseConfiguration GetConfiguration()
    {
        return GalleryBaseConfigurationProvider.Current ?? CreateConfiguration();
    }

    public static void Configure(GalleryBaseOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        ConfigureBranding(options.Branding);
        ConfigureNavigation(options.Navigation);
        foreach (var route in RouteDescriptors.Value)
        {
            options.Routes.Map(route);
        }
    }

    public static void RegisterViews(DefaultViewLocator locator)
    {
        ArgumentNullException.ThrowIfNull(locator);
        foreach (var route in RouteDescriptors.Value)
        {
            route.RegisterView(locator);
        }
    }

    internal static GalleryLocalizedText<WorkspaceWindowLangResourceKind> LocalizedCategory(string category)
    {
        if (!Enum.TryParse<WorkspaceWindowLangResourceKind>(
                $"IconCategory{category}",
                out var resourceKind))
        {
            throw new InvalidOperationException($"No localized header exists for icon category '{category}'.");
        }

        return new GalleryLocalizedText<WorkspaceWindowLangResourceKind>(resourceKind, category);
    }

    private static void ConfigureBranding(GalleryBrandingOptions branding)
    {
        branding.AppName     = "AtomUI Gravity Icons";
        branding.Logo        = "avares://GravityGallery/Assets/atomui-oss.svg";
        branding.VersionText = GalleryVersionInfo.DisplayVersion;
        branding.Links.Add(new GalleryLink("Website", GalleryProjectLinks.Website,
            Icon(AntDesignIconKind.GlobalOutlined)));
        branding.Links.Add(new GalleryLink("NuGet", GalleryProjectLinks.NuGetPackage,
            Icon(AntDesignIconKind.CloudDownloadOutlined)));
        branding.Links.Add(new GalleryLink("GitHub", GalleryProjectLinks.GitHub,
            Icon(AntDesignIconKind.GithubOutlined)));
    }

    private static void ConfigureNavigation(AtomUI.Toolkits.GalleryBase.Navigation.GalleryNavigationBuilder navigation)
    {
        navigation.DefaultRoute = OverviewViewModel.ID;
        navigation.AddPage(
            OverviewViewModel.ID,
            Localized(WorkspaceWindowLangResourceKind.NavigationOverview, "Overview"),
            Icon(AntDesignIconKind.HomeOutlined));
        navigation.AddPage(
            CommunityViewModel.ID,
            Localized(WorkspaceWindowLangResourceKind.NavigationCommunity, "Community"),
            Icon(AntDesignIconKind.TeamOutlined));

        var categories = navigation.AddGroup(
            CategoriesNavigationKey,
            Localized(WorkspaceWindowLangResourceKind.NavigationCategories, CategoriesNavigationKey),
            Icon(AntDesignIconKind.AppstoreOutlined));
        navigation.DefaultOpenKeys.Add(CategoriesNavigationKey);

        foreach (var category in new IconInfoRepository().Categories)
        {
            categories.AddPage(category, LocalizedCategory(category), CategoryIcon(category));
        }
    }

    private static IReadOnlyList<GalleryRouteDescriptor> CreateRouteDescriptors()
    {
        var routes = new GalleryRouteRegistry();
        ConfigureRoutes(routes);
        return routes.Routes;
    }

    private static void ConfigureRoutes(GalleryRouteRegistry routes)
    {
        routes.Map<OverviewViewModel, OverviewPage>(
            OverviewViewModel.ID,
            screen => new OverviewViewModel(screen),
            static () => new OverviewPage());
        routes.Map<CommunityViewModel, CommunityPage>(
            CommunityViewModel.ID,
            screen => new CommunityViewModel(screen),
            static () => new CommunityPage());

        foreach (var category in new IconInfoRepository().Categories)
        {
            var capturedCategory = category;
            routes.Map<IconCatalogPageViewModel, IconCatalogPage>(
                category,
                screen => new IconCatalogPageViewModel(screen, capturedCategory),
                static () => new IconCatalogPage());
        }
    }

    private static GalleryLocalizedText<WorkspaceWindowLangResourceKind> Localized(
        WorkspaceWindowLangResourceKind kind,
        string fallback)
    {
        return new GalleryLocalizedText<WorkspaceWindowLangResourceKind>(kind, fallback);
    }

    private static Func<PathIcon> Icon(AntDesignIconKind kind)
    {
        return () => (PathIcon)new AntDesignIconProvider(kind).ProvideValue(null!);
    }

    private static Func<PathIcon> CategoryIcon(string category)
    {
        return Icon(category switch
        {
            "Arrows"        => AntDesignIconKind.ArrowsAltOutlined,
            "Layout"        => AntDesignIconKind.LayoutOutlined,
            "Text"          => AntDesignIconKind.FontSizeOutlined,
            "Status"        => AntDesignIconKind.InfoCircleOutlined,
            "Files"         => AntDesignIconKind.FolderOutlined,
            "Shapes"        => AntDesignIconKind.BorderOutlined,
            "Development"   => AntDesignIconKind.CodeOutlined,
            "Editor"        => AntDesignIconKind.FormOutlined,
            "People"        => AntDesignIconKind.UserOutlined,
            "Media"         => AntDesignIconKind.PlayCircleOutlined,
            "Brands"        => AntDesignIconKind.GoogleOutlined,
            "Charts"        => AntDesignIconKind.BarChartOutlined,
            "Commerce"      => AntDesignIconKind.ShoppingOutlined,
            "Communication" => AntDesignIconKind.MessageOutlined,
            "Games"         => AntDesignIconKind.TrophyOutlined,
            "Devices"       => AntDesignIconKind.LaptopOutlined,
            "Maps"          => AntDesignIconKind.EnvironmentOutlined,
            "Tools"         => AntDesignIconKind.ToolOutlined,
            "Math"          => AntDesignIconKind.NumberOutlined,
            "Security"      => AntDesignIconKind.SafetyOutlined,
            "Cloud"         => AntDesignIconKind.CloudServerOutlined,
            "Finance"       => AntDesignIconKind.DollarOutlined,
            "Health"        => AntDesignIconKind.HeartOutlined,
            "Transport"     => AntDesignIconKind.CarOutlined,
            "Weather"       => AntDesignIconKind.CloudOutlined,
            "Time"          => AntDesignIconKind.ClockCircleOutlined,
            "Food"          => AntDesignIconKind.CoffeeOutlined,
            "Unassigned"    => AntDesignIconKind.QuestionCircleOutlined,
            _ => throw new InvalidOperationException($"No navigation icon exists for icon category '{category}'.")
        });
    }
}
