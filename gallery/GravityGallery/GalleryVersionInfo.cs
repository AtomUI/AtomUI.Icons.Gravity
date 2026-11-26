using System.Reflection;

namespace GravityGallery;

public static class GalleryVersionInfo
{
    private const string GravityVersionMetadataKey = "GravityVersion";

    public static string DisplayVersion => $"v{Version}";

    public static string Version
    {
        get
        {
            var metadataVersion = typeof(GalleryVersionInfo).Assembly
                                                            .GetCustomAttributes<AssemblyMetadataAttribute>()
                                                            .FirstOrDefault(attribute =>
                                                                attribute.Key == GravityVersionMetadataKey)
                                                            ?.Value;
            if (!string.IsNullOrWhiteSpace(metadataVersion))
            {
                return metadataVersion;
            }

            return typeof(GalleryVersionInfo).Assembly.GetName().Version?.ToString(3) ?? string.Empty;
        }
    }
}
