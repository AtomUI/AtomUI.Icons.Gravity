// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoDebianOutlined : GravityIcon
{
    public LogoDebianOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoDebianOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.2499015331268311, 1.2498055696487427, 11.500225067138672, 14.000430107116699);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.95520422031199648, 0, 0, 0.95520422031199648, 0.35836623750402818, 0.35836623750402818);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M5.494 2.04c1.274-.678 2.808-.976 4.24-.67 1.458.31 2.769 1.24 3.525 2.915.808 1.789.548 3.419-.264 4.602-.786 1.145-2.088 1.861-3.34 1.861-1.172 0-2.036-.541-2.526-1.309-.469-.734-.578-1.654-.328-2.42.227-.696.624-1.22 1.157-1.561.523-.334 1.12-.455 1.697-.455a.75.75 0 0 1 0 1.5c-.374 0-.67.08-.89.22-.209.134-.407.358-.538.76-.108.332-.066.786.167 1.15.211.331.597.615 1.261.615.709 0 1.569-.432 2.104-1.21.509-.742.73-1.815.133-3.136-.554-1.226-1.465-1.85-2.471-2.065-1.034-.22-2.209-.012-3.222.527-1.28.682-2.438 2.41-2.449 4.412-.01 1.932 1.06 4.242 4.475 6.062a.75.75 0 0 1-.706 1.324C3.715 13.135 2.236 10.364 2.25 7.77c.014-2.526 1.452-4.774 3.244-5.729"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
