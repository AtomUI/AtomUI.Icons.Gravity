using AtomUI.Toolkits.GalleryBase.Navigation;
using ReactiveUI;

namespace GravityGallery.Workspace.ViewModels;

public sealed class CaseNavigationViewModel : GalleryNavigationViewModel
{
    public WorkspaceWindowViewModel Workspace => (WorkspaceWindowViewModel)HostScreen;

    public CaseNavigationViewModel(IScreen hostScreen)
        : base(hostScreen, GravityGalleryModule.GetConfiguration())
    {
    }
}
