using Avalonia;
using System.Globalization;
using AtomUI;
using AtomUI.Desktop.Controls;
using AtomUI.Localization;
using AtomUI.Toolkits.GalleryBase;
using GravityGallery.Localization;

namespace GravityGallery;

public abstract partial class BaseGalleryApplication : Application
{
    public BaseGalleryApplication()
    {
    }

    protected internal static void ConfigureCore(IAtomUIBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.WithApplicationId("GravityGallery");
        builder.UseUserThemeDirectory();
        builder.UseLanguages(
            GalleryLanguageDefaults.Resolve(CultureInfo.CurrentUICulture),
            [LanguageTags.EnUS, LanguageTags.ZhCN, LanguageTags.ZhTW, LanguageTags.PtBR]);
        builder.UseAlibabaSansFont();
        builder.UseDesktopControls();
        builder.UseGalleryBase(GravityGalleryModule.Configure);
        builder.UseGalleryControls();
    }
}
