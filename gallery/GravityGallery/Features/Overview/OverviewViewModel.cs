using ReactiveUI;
using GravityGallery.Models;

namespace GravityGallery.Features.Overview;

public sealed class OverviewViewModel : ReactiveObject, IRoutableViewModel
{
    private const string GravityPackageName = "AtomUI.Icons.Gravity";

    public const string ID = "Overview";

    public IScreen HostScreen { get; }

    public string UrlPathSegment => ID;

    public string PackageName => GravityPackageName;

    public string DotNetCliInstallCommand =>
        $"dotnet add package {GravityPackageName} --version {GalleryVersionInfo.Version}";

    public string PackageReferenceInstallCommand =>
        $"<PackageReference Include=\"{GravityPackageName}\" Version=\"{GalleryVersionInfo.Version}\" />";

    public string PackageManagerInstallCommand =>
        $"Install-Package {GravityPackageName} -Version {GalleryVersionInfo.Version}";

    public Uri BrowseIconsUri { get; } = new($"{GalleryProjectLinks.GitHub}/tree/main/src/AtomUI.Icons.Gravity");

    public Uri UsageUri { get; } = new($"{GalleryProjectLinks.GitHub}#readme");

    public Uri NuGetUri { get; } = new(GalleryProjectLinks.NuGetPackage);

    public Uri GitHubUri { get; } = new(GalleryProjectLinks.GitHub);

    public Uri GravityIconsUpstreamUri { get; } = new(GalleryProjectLinks.GravityIconsUpstream);

    public OverviewViewModel(IScreen screen)
    {
        HostScreen = screen ?? throw new ArgumentNullException(nameof(screen));
    }
}
