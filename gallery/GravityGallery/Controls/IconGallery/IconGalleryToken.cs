using AtomUI.Theme.DesignTokens;
using Avalonia;
using GravityGallery.Controls.DesignTokens;

namespace GravityGallery.Controls;

[ControlDesignToken]
internal sealed class IconGalleryToken : AbstractControlDesignToken
{
    public const string ID = "IconGallery";
    
    public Thickness SearchInputMargin { get; set; }
    public double GalleryIconSize { get; set; }
    public double InfoItemSize { get; set; }

    public IconGalleryToken()
    {
    }
    
    public override void CalculateTokenValues(bool isDarkMode)
    {
        base.CalculateTokenValues(isDarkMode);
        SearchInputMargin = new Thickness(
            0,
            EffectiveGlobalToken.UniformlyMarginXS,
            EffectiveGlobalToken.UniformlyMarginXS,
            EffectiveGlobalToken.UniformlyMarginXS);
        GalleryIconSize = 48;
        InfoItemSize = 150;
    }
}
