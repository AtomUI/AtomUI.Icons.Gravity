using AtomUI;
using AtomUI.DesignLanguages.AntDesign;
using AtomUI.Desktop.Controls.Themes.AntDesign;
using GravityGallery.Workspace.Views;
using Window = Avalonia.Controls.Window;

namespace GravityGallery.Desktop;

public partial class GalleryApplication : BaseGalleryApplication
{
    public GalleryApplication()
    {
        Name = "Gravity Icons Gallery";
    }
    public static void Configure(IAtomUIBuilder builder)
    {
        BaseGalleryApplication.ConfigureCore(builder);
        builder.UseAntDesign(ant =>
        {
            ant.WithDefaultTheme(AntDesignThemes.DaybreakBlue);
            ant.AddDesktopControls();
        });
        builder.WithInitialDesignLanguage<AntDesignLanguage>();
        builder.UseMainWindow(static _ => Task.FromResult<Window>(new WorkspaceWindow()));
    }
}
