// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeUpOutlined : GravityIcon
{
    public ArrowShapeUpOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeUpOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5007493495941162, 1.0008953809738159, 12.995502471923828, 13.999104499816895);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0320085221879898, 0, 0, 1.0320085221879898, -0.25606817750391819, -0.25606817750391819);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10 8.5h2.67a.33.33 0 0 0 .252-.542L8.5 2.733a.656.656 0 0 0-1.002 0l-4.42 5.225a.33.33 0 0 0 .252.542H6V13a.5.5 0 0 0 .5.5h3a.5.5 0 0 0 .5-.5zm1.5 4.5a2 2 0 0 1-2 2h-3a2 2 0 0 1-2-2v-3H3.33a1.83 1.83 0 0 1-1.398-3.01l4.42-5.225a2.156 2.156 0 0 1 3.293 0l4.42 5.225A1.83 1.83 0 0 1 12.67 10H11.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
