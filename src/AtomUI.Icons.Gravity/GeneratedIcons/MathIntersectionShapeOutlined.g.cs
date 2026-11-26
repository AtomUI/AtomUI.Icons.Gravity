// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MathIntersectionShapeOutlined : GravityIcon
{
    public MathIntersectionShapeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MathIntersectionShapeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 0.99999994039535522, 13, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0322580724551453, 0, 0, 1.0322580724551453, -0.25806457964116269, -0.25806457964116269);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13 13.25V7.5a5 5 0 0 0-10 0v5.75c0 .138.112.25.25.25h1.5a.25.25 0 0 0 .25-.25V7.5a3 3 0 0 1 6 0v5.75c0 .138.112.25.25.25h1.5a.25.25 0 0 0 .25-.25m1.5-5.75v5.75A1.75 1.75 0 0 1 12.75 15h-1.5a1.75 1.75 0 0 1-1.75-1.75V7.5a1.5 1.5 0 1 0-3 0v5.75A1.75 1.75 0 0 1 4.75 15h-1.5a1.75 1.75 0 0 1-1.75-1.75V7.5a6.5 6.5 0 0 1 13 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
