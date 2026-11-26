using AtomUI.Theme.DesignTokens;
using AtomUI.Theme.Languages;
using Avalonia;
using GravityGallery.Controls;

namespace GravityGallery.TokenRules;

/// <summary>The Generic view of <see cref="IconGalleryToken"/>.</summary>
[ControlTokenRule]
internal sealed class GenericIconGalleryTokenRule : IControlTokenRule<LanguageDesignToken, IconGalleryToken>
{
    public void Apply(in TokenEvaluationContext<LanguageDesignToken> context, ControlTokenTarget<IconGalleryToken> target)
    {
        var token  = target.Own;
        var global = target.Global;
        token.SearchInputMargin = new Thickness(
            0,
            global.UniformlyMarginXS,
            global.UniformlyMarginXS,
            global.UniformlyMarginXS);
        token.GalleryIconSize = 48;
        token.InfoItemSize    = 150;
        token.EmptyTitleFontSize = 18;
    }
}
