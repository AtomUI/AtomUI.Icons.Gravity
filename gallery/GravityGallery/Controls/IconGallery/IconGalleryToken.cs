using AtomUI.Theme.DesignTokens;
using Avalonia;

namespace GravityGallery.Controls;

[ControlDesignToken]
internal sealed partial class IconGalleryToken : AbstractControlDesignToken
{
    public const string ID = "IconGallery";

    public partial Thickness SearchInputMargin { get; set; }
    public partial double GalleryIconSize { get; set; }
    public partial double InfoItemSize { get; set; }
    public partial double EmptyTitleFontSize { get; set; }
}
