using ReactiveUI;

namespace GravityGallery.Features.Community;

public sealed class CommunityViewModel : ReactiveObject, IRoutableViewModel
{
    public const string ID = "Community";

    public IScreen HostScreen { get; }

    public string UrlPathSegment => ID;

    public CommunityViewModel(IScreen screen)
    {
        HostScreen = screen ?? throw new ArgumentNullException(nameof(screen));
    }
}
