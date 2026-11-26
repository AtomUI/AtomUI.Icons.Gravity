// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TimestampsOutlined : GravityIcon
{
    public TimestampsOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TimestampsOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.50000005960464478, 0.50024908781051636, 15.000000953674316, 15.001825332641602);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0319819043192568, 0, 0, 1.0319819043192568, -0.25585523455405479, -0.25585523455405479);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14.5 12.75a2.75 2.75 0 0 0-2-2.646V8.75h2.25a.75.75 0 0 0 0-1.5h-6V5.896a2.75 2.75 0 0 0 2-2.646 2.75 2.75 0 1 0-3.5 2.646V7.25h-6a.75.75 0 0 0 0 1.5H3.5v1.354a2.75 2.75 0 0 0-2 2.646A2.75 2.75 0 1 0 5 10.104V8.75h6v1.354a2.751 2.751 0 1 0 3.5 2.646M11.75 14a1.25 1.25 0 1 0 0-2.5 1.25 1.25 0 0 0 0 2.5M8 4.5A1.25 1.25 0 1 0 8 2a1.25 1.25 0 0 0 0 2.5M4.25 14a1.25 1.25 0 1 0 0-2.5 1.25 1.25 0 0 0 0 2.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
