// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber0Filled : GravityIcon
{
    public CircleNumber0Filled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber0Filled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8 5.8c.61 0 .978.189 1.209.445.246.274.491.8.491 1.755s-.245 1.481-.491 1.755c-.23.256-.6.445-1.209.445s-.978-.189-1.209-.445C6.545 9.48 6.3 8.955 6.3 8s.245-1.481.491-1.755c.23-.256.6-.445 1.209-.445"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1a7 7 0 1 1 0 14A7 7 0 0 1 8 1m0 3.5C6.2 4.5 5 5.667 5 8s1.2 3.5 3 3.5 3-1.167 3-3.5-1.2-3.5-3-3.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
