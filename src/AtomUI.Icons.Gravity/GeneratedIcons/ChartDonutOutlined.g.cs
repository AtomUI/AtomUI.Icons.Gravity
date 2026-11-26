// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChartDonutOutlined : GravityIcon
{
    public ChartDonutOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChartDonutOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0476372241973877, 0.96816843748092651, 14.000000953674316, 14.000000953674316);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0577038978738786, 0, 0, 1.0577038978738786, -0.46163118299102912, -0.46163118299102912);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.111 2.18a7 7 0 1 1 7.778 11.64A7 7 0 0 1 4.111 2.18M8 6.02a1.98 1.98 0 1 0 0 3.96 1.98 1.98 0 0 0 0-3.96m-.75-3.469a5.5 5.5 0 1 0 6.199 6.199h-2.05a3.481 3.481 0 0 1-5.86 1.71A3.48 3.48 0 0 1 7.25 4.603zm1.5 0v2.05a3.48 3.48 0 0 1 2.648 2.649h2.05A5.5 5.5 0 0 0 8.75 2.551"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
