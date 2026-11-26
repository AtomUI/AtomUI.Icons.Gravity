using AtomUI;
using AtomUI.Generated.GravityGallery;

namespace GravityGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IAtomUIBuilder UseGalleryControls(this IAtomUIBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        GeneratedControlTokenRuleRegistration.Register(builder.Theme);
        return PackageMetadata.Definition.Register(builder);
    }
}
