using AtomUI;
using AtomUI.Localization;
using Avalonia;
using GravityGallery.Localization;

namespace GravityGallery.Models;

internal static class IconCategoryLocalization
{
    public static List<IconCategory> Localize(IEnumerable<string> categoryKeys)
    {
        var localizer = Application.Current?.GetLocalizer();
        return categoryKeys
            .Select(categoryKey => new IconCategory(categoryKey, GetCategoryHeader(localizer, categoryKey)))
            .ToList();
    }

    private static string GetCategoryHeader(ILocalizer? localizer, string categoryKey)
    {
        var resourceKind = ToResourceKind(categoryKey);
        return resourceKind is not null && localizer is not null
            ? localizer.Get(resourceKind.Value)
            : categoryKey;
    }

    private static WorkspaceWindowLangResourceKind? ToResourceKind(string categoryKey)
    {
        return categoryKey switch
        {
            "Arrows"        => WorkspaceWindowLangResourceKind.IconCategoryArrows,
            "Layout"        => WorkspaceWindowLangResourceKind.IconCategoryLayout,
            "Text"          => WorkspaceWindowLangResourceKind.IconCategoryText,
            "Status"        => WorkspaceWindowLangResourceKind.IconCategoryStatus,
            "Files"         => WorkspaceWindowLangResourceKind.IconCategoryFiles,
            "Shapes"        => WorkspaceWindowLangResourceKind.IconCategoryShapes,
            "Development"   => WorkspaceWindowLangResourceKind.IconCategoryDevelopment,
            "Editor"        => WorkspaceWindowLangResourceKind.IconCategoryEditor,
            "People"        => WorkspaceWindowLangResourceKind.IconCategoryPeople,
            "Media"         => WorkspaceWindowLangResourceKind.IconCategoryMedia,
            "Brands"        => WorkspaceWindowLangResourceKind.IconCategoryBrands,
            "Charts"        => WorkspaceWindowLangResourceKind.IconCategoryCharts,
            "Commerce"      => WorkspaceWindowLangResourceKind.IconCategoryCommerce,
            "Communication" => WorkspaceWindowLangResourceKind.IconCategoryCommunication,
            "Games"         => WorkspaceWindowLangResourceKind.IconCategoryGames,
            "Devices"       => WorkspaceWindowLangResourceKind.IconCategoryDevices,
            "Maps"          => WorkspaceWindowLangResourceKind.IconCategoryMaps,
            "Tools"         => WorkspaceWindowLangResourceKind.IconCategoryTools,
            "Math"          => WorkspaceWindowLangResourceKind.IconCategoryMath,
            "Security"      => WorkspaceWindowLangResourceKind.IconCategorySecurity,
            "Cloud"         => WorkspaceWindowLangResourceKind.IconCategoryCloud,
            "Finance"       => WorkspaceWindowLangResourceKind.IconCategoryFinance,
            "Health"        => WorkspaceWindowLangResourceKind.IconCategoryHealth,
            "Transport"     => WorkspaceWindowLangResourceKind.IconCategoryTransport,
            "Weather"       => WorkspaceWindowLangResourceKind.IconCategoryWeather,
            "Time"          => WorkspaceWindowLangResourceKind.IconCategoryTime,
            "Food"          => WorkspaceWindowLangResourceKind.IconCategoryFood,
            "Unassigned"    => WorkspaceWindowLangResourceKind.IconCategoryUnassigned,
            _               => null
        };
    }
}
