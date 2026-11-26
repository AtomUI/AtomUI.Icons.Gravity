// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class Shapes3Outlined : GravityIcon
{
    public Shapes3Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new Shapes3Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.44132015109062195, 0.31309783458709717, 15.058679580688477, 14.937394142150879);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0159047839044746, 0, 0, 1.0159047839044746, -0.12723827123579667, -0.12723827123579667);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 2.075 10.193 6H5.807zM6.909.953a1.25 1.25 0 0 1 2.182 0l2.62 4.687A1.25 1.25 0 0 1 10.62 7.5H5.38a1.25 1.25 0 0 1-1.09-1.86zM4 15.25a3.5 3.5 0 1 1 .001-6.999A3.5 3.5 0 0 1 4 15.25m2-3.5a2 2 0 1 1-4 0 2 2 0 0 1 4 0m8 1.75h-3.5V10H14zM9 9.75c0-.69.56-1.25 1.25-1.25h4c.69 0 1.25.56 1.25 1.25v4c0 .69-.56 1.25-1.25 1.25h-4C9.56 15 9 14.44 9 13.75z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
