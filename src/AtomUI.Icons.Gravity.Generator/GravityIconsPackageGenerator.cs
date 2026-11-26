using System.Globalization;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using AtomUI.Controls;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Headless;
using Avalonia.Media;

namespace AtomUI.Icons.Gravity.Generator;

/// <summary>
/// Generates the Gravity icon package from the upstream Gravity UI icon sources.
/// </summary>
/// <remarks>
/// The shared <see cref="SvgParser"/> ignores <c>fill-rule</c> and <c>clip-path</c>, and the headless drawing stub
/// measures geometry bounds from control points only. Both matter for the Gravity sources, so this generator reads
/// their small SVG subset itself and runs on the Skia backend. The enum, factory and catalog emission still come
/// from <see cref="DefaultIconPackageGenerator"/>.
/// </remarks>
public class GravityIconsPackageGenerator : DefaultIconPackageGenerator
{
    private const string SolutionFileName = "Gravity.slnx";
    private const string SvgDirectoryName  = "svgs";
    private const string MetadataFileName  = "metadata.json";
    private const string UpstreamFileName  = "upstream.json";

    private const string RegularStyle       = "regular";
    private const string FillStyle          = "fill";
    private const string FillVariantSuffix  = "-fill";
    private const string ThemeBrushFill     = "currentColor";
    // 越出画布的容差：上游个别路径有 0.04 单位以内的坐标误差
    private const double CanvasTolerance = 0.05;

    private const string DefsElementName     = "defs";
    private const string ClipPathElementName = "clipPath";
    private const string GroupElementName    = "g";
    private const string PathElementName     = "path";

    private static readonly Regex ClipReferencePattern = new(@"^url\(#(?<id>[^)]+)\)$", RegexOptions.Compiled);

    private readonly string _galleryModelPath;
    private readonly Dictionary<string, SvgSource> _svgSources = new(StringComparer.Ordinal);
    private readonly List<string> _warnings = new();
    private string _upstreamAttribution = string.Empty;

    public GravityIconsPackageGenerator(string sourcePath, string targetPath, string galleryModelPath)
        : base(sourcePath, targetPath)
    {
        PackageName      = "Gravity";
        PackageNamespace = "AtomUI.Icons.Gravity";
        _galleryModelPath = galleryModelPath;
    }

    public IReadOnlyList<string> Warnings => _warnings;

    public static async Task<int> Main(string[] args)
    {
        try
        {
            SetupAvalonia();
            var repositoryRoot = ResolveRepositoryRoot();
            var generator = new GravityIconsPackageGenerator(
                Path.Combine(repositoryRoot, "src", "AtomUI.Icons.Gravity.Generator", "Assets"),
                Path.Combine(repositoryRoot, "src", "AtomUI.Icons.Gravity"),
                Path.Combine(repositoryRoot, "gallery", "GravityGallery", "Models"));
            await generator.GenerateAsync();
            generator.Report();
            return 0;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine($"Generate error: {e.Message}");
#if DEBUG
            throw;
#else
            return 1;
#endif
        }
    }

    private static void SetupAvalonia()
    {
        // 无头绘图桩只按控制点估算包围盒（圆弧只计端点），这里用 Skia 后端拿到真实几何
        AppBuilder.Configure<GeneratorApplication>()
                  .UseSkia()
                  .UseHeadless(new AvaloniaHeadlessPlatformOptions { UseHeadlessDrawing = false })
                  .SetupWithLifetime(new ClassicDesktopStyleApplicationLifetime());
        SynchronizationContext.SetSynchronizationContext(null);
    }

    private static string ResolveRepositoryRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);
        while (directory is not null)
        {
            if (File.Exists(Path.Combine(directory.FullName, SolutionFileName)))
            {
                return directory.FullName;
            }

            directory = directory.Parent;
        }

        throw new DirectoryNotFoundException(
            $"Cannot locate the repository root: no {SolutionFileName} found above {AppContext.BaseDirectory}.");
    }

    protected override IEnumerable<IconFileInfo> ScanIconFilesRecursively(string sourcePath)
    {
        var (version, commit) = LoadUpstreamProvenance(Path.Combine(sourcePath, UpstreamFileName));
        _upstreamAttribution =
            $"// Upstream: Gravity UI Icons v{version} ({commit[..12]}), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons";

        var metadata = LoadUpstreamMetadata(Path.Combine(sourcePath, MetadataFileName));
        var iconFiles = new List<IconFileInfo>();
        var usedSvgNames = new HashSet<string>(StringComparer.Ordinal);
        var usedClassNames = new HashSet<string>(StringComparer.Ordinal);

        foreach (var svgFilePath in Directory.EnumerateFiles(Path.Combine(sourcePath, SvgDirectoryName), "*.svg"))
        {
            var svgName = Path.GetFileNameWithoutExtension(svgFilePath);
            if (!metadata.TryGetValue(svgName, out var upstreamIcon))
            {
                throw new InvalidDataException($"{svgName}.svg has no entry in {MetadataFileName}.");
            }

            var isFill = svgName.EndsWith(FillVariantSuffix, StringComparison.Ordinal);
            if (upstreamIcon.Style != (isFill ? FillStyle : RegularStyle))
            {
                throw new InvalidDataException($"{svgName}: metadata style \"{upstreamIcon.Style}\" does not match the file name.");
            }

            var iconName = ToPascalCase(upstreamIcon.Name);
            if (upstreamIcon.ComponentName != iconName + (isFill ? "Fill" : string.Empty))
            {
                throw new InvalidDataException($"{svgName}: derived name \"{iconName}\" does not match the upstream component name.");
            }

            if (upstreamIcon.Categories.Count == 0)
            {
                throw new InvalidDataException($"{svgName}: no category in {MetadataFileName}.");
            }

            var category = Capitalize(upstreamIcon.Categories[0]);
            var iconFile = new IconFileInfo
            {
                Category  = category,
                Name      = iconName,
                FilePath  = svgFilePath,
                ThemeType = isFill ? IconThemeType.Filled : IconThemeType.Outlined
            };
            var className = $"{iconFile.Name}{iconFile.ThemeType}";
            if (!usedClassNames.Add(className))
            {
                throw new InvalidDataException($"Duplicate icon class name {className}.");
            }

            usedSvgNames.Add(svgName);
            _svgSources[svgFilePath] = LoadSvgSource(svgFilePath, className);
            iconFiles.Add(iconFile);
        }

        var missing = metadata.Keys.Where(name => !usedSvgNames.Contains(name)).OrderBy(name => name, StringComparer.Ordinal).ToList();
        if (missing.Count > 0)
        {
            throw new InvalidDataException($"{MetadataFileName} lists icons without an svg file: {string.Join(", ", missing)}.");
        }

        // 常规版排在同名实心版前面，枚举、工厂和目录共用这个顺序
        return iconFiles.OrderBy(info => info.Name, StringComparer.Ordinal)
                        .ThenByDescending(info => info.ThemeType);
    }

    private static Dictionary<string, UpstreamIcon> LoadUpstreamMetadata(string path)
    {
        using var document = JsonDocument.Parse(File.ReadAllText(path));
        var icons = new Dictionary<string, UpstreamIcon>(StringComparer.Ordinal);
        foreach (var element in document.RootElement.GetProperty("icons").EnumerateArray())
        {
            var icon = new UpstreamIcon(
                element.GetProperty("name").GetString()!,
                element.GetProperty("style").GetString()!,
                element.GetProperty("svgName").GetString()!,
                element.GetProperty("componentName").GetString()!,
                element.GetProperty("categories").EnumerateArray().Select(item => item.GetString()!).ToList());
            icons.Add(icon.SvgName, icon);
        }

        return icons;
    }

    private static (string Version, string Commit) LoadUpstreamProvenance(string path)
    {
        using var document = JsonDocument.Parse(File.ReadAllText(path));
        var root = document.RootElement;
        return (root.GetProperty("version").GetString()!, root.GetProperty("commit").GetString()!);
    }

    private SvgSource LoadSvgSource(string filePath, string className)
    {
        var root = XDocument.Load(filePath, LoadOptions.None).Root
                   ?? throw new InvalidDataException($"{className}: missing svg root.");
        var viewBox = ParseViewBox(root.Attribute("viewBox")?.Value, className);
        // svg 根上的 fill 会被没有自带 fill 的后代继承，上游在这里写的是 none
        var rootFill = root.Attribute("fill")?.Value;
        var canvas   = viewBox.Inflate(CanvasTolerance);
        var paths = new List<SvgPathSource>();
        Rect? geometryBounds = null;

        // 上游把 <defs> 写在引用它的 <g> 之后，所以先收集全部 clipPath
        var clipRects = new Dictionary<string, Rect>(StringComparer.Ordinal);
        foreach (var definitions in root.Elements().Where(element => element.Name.LocalName == DefsElementName))
        {
            foreach (var definition in definitions.Elements())
            {
                if (definition.Name.LocalName != ClipPathElementName)
                {
                    throw UnsupportedElement(className, definition);
                }

                var id = definition.Attribute("id")?.Value
                         ?? throw new InvalidDataException($"{className}: clipPath without id.");
                var clip = new GeometryGroup();
                foreach (var shape in definition.Elements())
                {
                    if (shape.Name.LocalName != PathElementName)
                    {
                        throw UnsupportedElement(className, shape);
                    }

                    clip.Children.Add(ParseGeometry(RequiredAttribute(shape, "d", className), FillRule.NonZero, className));
                }

                clipRects.Add(id, clip.Bounds);
            }
        }

        foreach (var element in root.Elements())
        {
            switch (element.Name.LocalName)
            {
                case DefsElementName:
                    break;
                case GroupElementName:
                {
                    EnsureSupportedAttributes(className, element, "clip-path", "clip-rule", "fill", "fill-rule");
                    if (element.Attribute("clip-path")?.Value is { } clipReference)
                    {
                        var id = ClipReferencePattern.Match(clipReference) is { Success: true } match
                            ? match.Groups["id"].Value
                            : throw new InvalidDataException($"{className}: unsupported clip-path \"{clipReference}\".");
                        if (!clipRects.TryGetValue(id, out var clipRect))
                        {
                            throw new InvalidDataException($"{className}: clip-path references unknown clipPath \"{id}\".");
                        }

                        // 上游的 clipPath 都是整幅画布，等同于不裁剪
                        if (!Equals(clipRect, viewBox))
                        {
                            throw new InvalidDataException(
                                $"{className}: clipPath \"{id}\" is not the canvas; real clipping is not supported.");
                        }
                    }

                    var groupFill     = element.Attribute("fill")?.Value ?? rootFill;
                    var groupFillRule = element.Attribute("fill-rule")?.Value;
                    foreach (var shape in element.Elements())
                    {
                        if (shape.Name.LocalName != PathElementName)
                        {
                            throw UnsupportedElement(className, shape);
                        }

                        EnsureSupportedAttributes(className, shape, "d", "fill", "fill-rule", "clip-rule");
                        AddPath(shape, className, canvas, groupFill, groupFillRule, paths, ref geometryBounds);
                    }

                    break;
                }
                case PathElementName:
                    EnsureSupportedAttributes(className, element, "d", "fill", "fill-rule", "clip-rule");
                    AddPath(element, className, canvas, rootFill, null, paths, ref geometryBounds);
                    break;
                default:
                    throw UnsupportedElement(className, element);
            }
        }

        if (paths.Count == 0)
        {
            throw new InvalidDataException($"{className}: no drawable path.");
        }

        return new SvgSource
        {
            ViewBox         = viewBox,
            GeometryBounds  = geometryBounds ?? default,
            Paths           = paths
        };
    }

    private void AddPath(XElement path, string className, Rect canvas, string? inheritedFill, string? inheritedFillRule,
                         List<SvgPathSource> paths, ref Rect? geometryBounds)
    {
        var data = RequiredAttribute(path, "d", className);
        if (data.IndexOf('"') >= 0 || data.IndexOf('\\') >= 0)
        {
            throw new InvalidDataException($"{className}: path data contains a character that cannot be emitted in a C# string literal.");
        }

        var fillRule = ParseFillRule(path.Attribute("fill-rule")?.Value ?? inheritedFillRule);
        var fill     = path.Attribute("fill")?.Value ?? inheritedFill;
        if (fill is null || fill == "none")
        {
            throw new InvalidDataException($"{className}: drawable path without a fill color.");
        }

        if (fill != ThemeBrushFill)
        {
            _warnings.Add($"{className}: fill=\"{fill}\" is drawn with the icon brush.");
        }

        var bounds = ParseGeometry(data, fillRule, className).Bounds;
        if (!canvas.Contains(bounds))
        {
            _warnings.Add($"{className}: path bounds {bounds} exceed the viewBox.");
        }

        paths.Add(new SvgPathSource(data, fillRule));
        geometryBounds = geometryBounds is { } current ? current.Union(bounds) : bounds;
    }

    protected override async Task GenerateIconPackageClass(IconFileInfo iconFileInfo, Stream output)
    {
        var sourceText = new StringBuilder();
        var source     = _svgSources[iconFileInfo.FilePath];
        var viewBox    = source.ViewBox;
        var className  = $"{iconFileInfo.Name}{iconFileInfo.ThemeType}";
        var zoomMatrix = CalculateZoomToFit(viewBox, source.GeometryBounds);

        sourceText.AppendLine("// This code is auto generated. Do not modify.");
        sourceText.AppendLine(_upstreamAttribution);
        sourceText.AppendLine();
        sourceText.AppendLine("using System.Collections.Generic;");
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using Avalonia.Media;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine($"namespace {PackageNamespace};");
        sourceText.AppendLine();
        sourceText.AppendLine($"public class {className} : GravityIcon");
        sourceText.AppendLine("{");
        sourceText.AppendLine($"    public {className}()");
        sourceText.AppendLine("    {");
        sourceText.AppendLine($"        IconTheme = IconThemeType.{iconFileInfo.ThemeType};");
        sourceText.AppendLine($"        ViewBox = {FormatRect(viewBox)};");
        sourceText.AppendLine("    }");
        sourceText.AppendLine();
        sourceText.AppendLine("    public override Icon CreateInstance()");
        sourceText.AppendLine("    {");
        sourceText.AppendLine($"        return new {className}();");
        sourceText.AppendLine("    }");
        sourceText.AppendLine();
        sourceText.AppendLine("    internal override Rect GeneratedViewBox => "
                               + $"{FormatRect(viewBox)};");
        sourceText.AppendLine("    internal override Rect GeneratedGeometryBounds => "
                               + $"{FormatRect(source.GeometryBounds)};");
        sourceText.AppendLine("    internal override Matrix GeneratedZoomMatrix => "
                               + $"{FormatMatrix(zoomMatrix)};");
        sourceText.AppendLine();
        sourceText.AppendLine("    private static readonly DrawingInstruction[] StaticInstructions = [");
        for (var i = 0; i < source.Paths.Count; i++)
        {
            var path = source.Paths[i];
            sourceText.AppendLine("        new PathDrawingInstruction()");
            sourceText.AppendLine("        {");
            sourceText.AppendLine("            Opacity = 1,");
            sourceText.AppendLine("            FillBrush = IconBrushType.Fill,");
            sourceText.AppendLine($"            Data = StreamGeometry.Parse(\"{FormatPathData(path.Data, path.FillRule)}\"),");
            sourceText.AppendLine($"        }}{(i == source.Paths.Count - 1 ? string.Empty : ",")}");
        }

        sourceText.AppendLine("    ];");
        sourceText.AppendLine();
        sourceText.AppendLine("    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;");
        sourceText.AppendLine("}");

        await output.WriteAsync(Encoding.UTF8.GetBytes(sourceText.ToString()));
    }

    protected override async Task GenerateIconPackageClassesAsync()
    {
        await base.GenerateIconPackageClassesAsync();
        await GenerateIconRepositoryClassAsync();
    }

    private async Task GenerateIconRepositoryClassAsync()
    {
        var repositoryFilePath = Path.Combine(_galleryModelPath, "IconInfoRepository.g.cs");
        await using var stream = new FileStream(repositoryFilePath, FileMode.Create, FileAccess.Write);
        var sourceText = new StringBuilder();
        sourceText.AppendLine("// This code is auto generated. Do not modify.");
        sourceText.AppendLine(_upstreamAttribution);
        sourceText.AppendLine("#nullable enable");
        sourceText.AppendLine();
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using System;");
        sourceText.AppendLine("using System.Collections.Generic;");
        sourceText.AppendLine("using Avalonia.Media;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine("namespace GravityGallery.Models;");
        sourceText.AppendLine();
        sourceText.AppendLine("public partial class IconInfoRepository");
        sourceText.AppendLine("{");
        sourceText.AppendLine("    public IconInfoRepository()");
        sourceText.AppendLine("    {");
        var categoryGroups = IconFiles
            .GroupBy(iconFileInfo => iconFileInfo.Category!)
            .OrderBy(group => group.Key, StringComparer.Ordinal)
            .ToList();
        sourceText.AppendLine("        Categories = [");
        foreach (var category in categoryGroups.Select(group => group.Key))
        {
            sourceText.AppendLine($"            \"{category}\",");
        }

        sourceText.AppendLine("        ];");
        sourceText.AppendLine("    }");
        sourceText.AppendLine();
        sourceText.AppendLine("    protected partial List<IconInfo> CreateIconInfos(string? category, IconThemeType iconTheme)");
        sourceText.AppendLine("    {");
        sourceText.AppendLine("        return category switch");
        sourceText.AppendLine("        {");
        foreach (var categoryGroup in categoryGroups)
        {
            sourceText.AppendLine($"            \"{categoryGroup.Key}\" => Create{categoryGroup.Key}IconInfos(iconTheme),");
        }

        sourceText.AppendLine("            _ => []");
        sourceText.AppendLine("        };");
        sourceText.AppendLine("    }");

        foreach (var categoryGroup in categoryGroups)
        {
            var themeGroups = categoryGroup.GroupBy(iconFileInfo => iconFileInfo.ThemeType)
                                           .OrderBy(group => group.Key)
                                           .ToList();
            sourceText.AppendLine();
            sourceText.AppendLine($"    private static List<IconInfo> Create{categoryGroup.Key}IconInfos(IconThemeType iconTheme)");
            sourceText.AppendLine("    {");
            sourceText.AppendLine("        return iconTheme switch");
            sourceText.AppendLine("        {");
            foreach (var themeGroup in themeGroups)
            {
                sourceText.AppendLine($"            IconThemeType.{themeGroup.Key} => Create{categoryGroup.Key}{themeGroup.Key}IconInfos(),");
            }

            sourceText.AppendLine("            _ => []");
            sourceText.AppendLine("        };");
            sourceText.AppendLine("    }");

            foreach (var themeGroup in themeGroups)
            {
                sourceText.AppendLine();
                sourceText.AppendLine($"    private static List<IconInfo> Create{categoryGroup.Key}{themeGroup.Key}IconInfos()");
                sourceText.AppendLine("    {");
                sourceText.AppendLine("        return [");
                foreach (var iconFileInfo in themeGroup.OrderBy(info => info.Name, StringComparer.Ordinal))
                {
                    var name = $"{iconFileInfo.Name}{iconFileInfo.ThemeType}";
                    sourceText.AppendLine("            new IconInfo {");
                    sourceText.AppendLine($"                Name = \"{name}\",");
                    sourceText.AppendLine($"                Category = \"{iconFileInfo.Category}\",");
                    sourceText.AppendLine($"                ThemeType = IconThemeType.{iconFileInfo.ThemeType},");
                    sourceText.AppendLine($"                IconType = typeof(AtomUI.Icons.Gravity.{name}),");
                    sourceText.AppendLine($"                Creator = () => new AtomUI.Icons.Gravity.{name}()");
                    sourceText.AppendLine("            },");
                }

                sourceText.AppendLine("        ];");
                sourceText.AppendLine("    }");
            }
        }

        sourceText.AppendLine("}");
        await stream.WriteAsync(Encoding.UTF8.GetBytes(sourceText.ToString()));
    }

    public void Report()
    {
        var outlined  = IconFiles.Count(info => info.ThemeType == IconThemeType.Outlined);
        var filled    = IconFiles.Count(info => info.ThemeType == IconThemeType.Filled);
        var categories = IconFiles.Select(info => info.Category).Distinct().Count();
        Console.WriteLine($"Gravity icons: {IconFiles.Count} (Outlined {outlined}, Filled {filled}); categories: {categories}.");
        foreach (var warning in _warnings)
        {
            Console.WriteLine($"Warning: {warning}");
        }
    }

    private static string RequiredAttribute(XElement element, string name, string className)
    {
        return element.Attribute(name)?.Value
               ?? throw new InvalidDataException($"{className}: <{element.Name.LocalName}> without \"{name}\".");
    }

    private static void EnsureSupportedAttributes(string className, XElement element, params string[] allowedNames)
    {
        foreach (var attribute in element.Attributes())
        {
            if (!allowedNames.Contains(attribute.Name.LocalName))
            {
                throw new InvalidDataException(
                    $"{className}: unsupported svg attribute \"{attribute.Name.LocalName}\" on <{element.Name.LocalName}>.");
            }
        }
    }

    private static InvalidDataException UnsupportedElement(string className, XElement element)
    {
        return new InvalidDataException($"{className}: unsupported svg element <{element.Name.LocalName}>.");
    }

    private static Rect ParseViewBox(string? value, string className)
    {
        var parts = value?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];
        if (parts.Length != 4)
        {
            throw new InvalidDataException($"{className}: invalid viewBox \"{value}\".");
        }

        var numbers = new double[4];
        for (var i = 0; i < parts.Length; i++)
        {
            if (!double.TryParse(parts[i], NumberStyles.Float, CultureInfo.InvariantCulture, out numbers[i]))
            {
                throw new InvalidDataException($"{className}: invalid viewBox \"{value}\".");
            }
        }

        return new Rect(numbers[0], numbers[1], numbers[2], numbers[3]);
    }

    private static FillRule ParseFillRule(string? value)
    {
        return value switch
        {
            // svg 的默认填充规则是 nonzero
            null or "nonzero" => FillRule.NonZero,
            "evenodd"         => FillRule.EvenOdd,
            _                 => throw new InvalidDataException($"Unsupported fill-rule \"{value}\".")
        };
    }

    private static StreamGeometry ParseGeometry(string data, FillRule fillRule, string className)
    {
        try
        {
            return StreamGeometry.Parse(FormatPathData(data, fillRule));
        }
        catch (Exception exception)
        {
            throw new InvalidDataException($"{className}: invalid path data.", exception);
        }
    }

    /// <summary>
    /// PathMarkupParser 不设默认填充规则，规则由平台实现决定，所以每条路径都显式带上 <c>F0</c>（evenodd）
    /// 或 <c>F1</c>（nonzero）。
    /// </summary>
    private static string FormatPathData(string data, FillRule fillRule)
    {
        return $"{(fillRule == FillRule.EvenOdd ? "F0 " : "F1 ")}{data}";
    }

    private static string ToPascalCase(string value)
    {
        return string.Concat(value.Split('-').Select(Capitalize));
    }

    public static string Capitalize(string value)
    {
        return value.Length == 0 ? value : char.ToUpperInvariant(value[0]) + value[1..];
    }

    private static string FormatRect(Rect rect)
    {
        return $"new Rect({FormatDouble(rect.X)}, {FormatDouble(rect.Y)}, {FormatDouble(rect.Width)}, {FormatDouble(rect.Height)})";
    }

    private static string FormatMatrix(Matrix matrix)
    {
        return $"new Matrix({FormatDouble(matrix.M11)}, {FormatDouble(matrix.M12)}, {FormatDouble(matrix.M21)}, "
               + $"{FormatDouble(matrix.M22)}, {FormatDouble(matrix.M31)}, {FormatDouble(matrix.M32)})";
    }

    private static string FormatDouble(double value)
    {
        if (Math.Abs(value) < 1e-12)
        {
            value = 0;
        }

        return value.ToString("G17", CultureInfo.InvariantCulture);
    }

    private static Matrix CalculateZoomToFit(Rect viewbox, Rect iconBounds)
    {
        var viewboxCenter = new Point(
            viewbox.Left + viewbox.Width / 2,
            viewbox.Top + viewbox.Height / 2);

        var leftDelta   = iconBounds.Left - viewbox.Left;
        var rightDelta  = iconBounds.Right - viewbox.Right;
        var topDelta    = iconBounds.Top - viewbox.Top;
        var bottomDelta = iconBounds.Bottom - viewbox.Bottom;

        var minDelta = Math.Min(Math.Min(leftDelta, rightDelta), Math.Min(topDelta, bottomDelta));
        minDelta /= 2;

        var iconLeftDist   = iconBounds.Left - viewboxCenter.X - minDelta;
        var iconRightDist  = iconBounds.Right - viewboxCenter.X - minDelta;
        var iconTopDist    = iconBounds.Top - viewboxCenter.Y - minDelta;
        var iconBottomDist = iconBounds.Bottom - viewboxCenter.Y - minDelta;

        var maxScale = double.MaxValue;
        foreach (var (iconDist, viewboxDist) in new[]
                 {
                     (iconLeftDist, viewbox.Left - viewboxCenter.X),
                     (iconRightDist, viewbox.Right - viewboxCenter.X),
                     (iconTopDist, viewbox.Top - viewboxCenter.Y),
                     (iconBottomDist, viewbox.Bottom - viewboxCenter.Y)
                 })
        {
            if (Math.Abs(iconDist) > 0.0001)
            {
                var scale = viewboxDist / iconDist;
                if (scale > 0 && scale < maxScale)
                {
                    maxScale = scale;
                }
            }
        }

        if (maxScale > 1000 || maxScale <= 0)
        {
            maxScale = 1.0;
        }

        var transform = Matrix.Identity;
        transform *= Matrix.CreateTranslation(-viewboxCenter.X, -viewboxCenter.Y);
        transform *= Matrix.CreateScale(maxScale, maxScale);
        transform *= Matrix.CreateTranslation(viewboxCenter.X, viewboxCenter.Y);

        return transform;
    }

    private sealed record UpstreamIcon(string Name, string Style, string SvgName, string ComponentName,
        IReadOnlyList<string> Categories);

    private sealed record SvgPathSource(string Data, FillRule FillRule);

    private sealed class SvgSource
    {
        public required Rect ViewBox { get; init; }
        public required Rect GeometryBounds { get; init; }
        public required List<SvgPathSource> Paths { get; init; }
    }

    private sealed class GeneratorApplication : Avalonia.Application;
}
