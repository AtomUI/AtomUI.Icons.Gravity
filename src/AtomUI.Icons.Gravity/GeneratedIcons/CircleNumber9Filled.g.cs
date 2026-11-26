// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber9Filled : GravityIcon
{
    public CircleNumber9Filled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber9Filled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8.1 5.9c.49 0 .836.126 1.062.353q.124.121.23.338 0 .005.003.01a.55.55 0 0 1-.137.613c-.192.19-.59.386-1.258.386-.376 0-.658-.11-.833-.255A.73.73 0 0 1 6.9 6.75c0-.274.317-.85 1.2-.85"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1a7 7 0 1 1 0 14A7 7 0 0 1 8 1m.1 3.6c-1.504 0-2.5 1.065-2.5 2.15 0 .653.275 1.211.737 1.595.45.374 1.044.555 1.663.555l.015-.002a3.7 3.7 0 0 0 1.345-.244c-.384.706-1.224 1.278-2.447 1.452a.65.65 0 0 0 .184 1.288c2.08-.297 3.803-1.667 3.803-3.644 0-1.044-.266-1.861-.817-2.414S8.802 4.6 8.1 4.6"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
