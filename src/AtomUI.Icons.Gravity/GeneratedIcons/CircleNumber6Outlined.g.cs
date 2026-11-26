// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber6Outlined : GravityIcon
{
    public CircleNumber6Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber6Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 13.5a5.5 5.5 0 1 0 0-11 5.5 5.5 0 0 0 0 11M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14m2.5-5.75c0 1.147-1.048 2.25-2.6 2.25-.719 0-1.478-.187-2.054-.765S5 9.31 5 8.25c0-2.046 1.781-3.442 3.89-3.742a.75.75 0 1 1 .21 1.484c-1.057.151-1.808.599-2.224 1.161A4 4 0 0 1 8 7c.638 0 1.255.186 1.727.578.485.402.773.989.773 1.672M8.025 8.5H8c-.65 0-1.02.19-1.187.357a.45.45 0 0 0-.108.525c.063.129.134.224.204.294.2.202.516.324.991.324.835 0 1.1-.538 1.1-.75 0-.236-.09-.4-.231-.518-.15-.125-.4-.227-.744-.232"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
