// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber6Filled : GravityIcon
{
    public CircleNumber6Filled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber6Filled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8 8.4c.376 0 .658.11.833.255a.73.73 0 0 1 .267.595c0 .274-.317.85-1.2.85-.49 0-.836-.126-1.062-.353a1.2 1.2 0 0 1-.23-.339l-.003-.01a.55.55 0 0 1 .137-.612c.192-.19.59-.386 1.258-.386"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1a7 7 0 1 1 0 14A7 7 0 0 1 8 1m.903 3.606C6.823 4.903 5.1 6.273 5.1 8.25c0 1.044.266 1.861.817 2.414s1.281.736 1.983.736c1.504 0 2.5-1.065 2.5-2.15 0-.653-.275-1.211-.737-1.595C9.213 7.281 8.62 7.1 8 7.1h-.016a3.7 3.7 0 0 0-1.345.245c.384-.705 1.225-1.277 2.448-1.451a.65.65 0 0 0-.184-1.288"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
