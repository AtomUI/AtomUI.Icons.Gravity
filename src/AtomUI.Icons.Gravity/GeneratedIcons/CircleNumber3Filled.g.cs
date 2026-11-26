// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber3Filled : GravityIcon
{
    public CircleNumber3Filled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber3Filled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1a7 7 0 1 1 0 14A7 7 0 0 1 8 1M6.5 4.85a.65.65 0 0 0 0 1.3h1.67l-.933 1.2a.651.651 0 0 0 .62 1.042c.626-.105 1 .02 1.198.165a.71.71 0 0 1 .295.593c0 .343-.314.95-1.35.95-.822 0-1.302-.561-1.384-.805a.65.65 0 1 0-1.232.41C5.636 10.461 6.599 11.4 8 11.4c1.654 0 2.65-1.093 2.65-2.25a2.01 2.01 0 0 0-.83-1.644 2.3 2.3 0 0 0-.778-.36l.97-1.247A.65.65 0 0 0 9.5 4.85z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
