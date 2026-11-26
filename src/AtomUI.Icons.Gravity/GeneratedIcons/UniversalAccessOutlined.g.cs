// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class UniversalAccessOutlined : GravityIcon
{
    public UniversalAccessOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new UniversalAccessOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M10.32 5.812a.75.75 0 0 1 .684 1.334 6.6 6.6 0 0 1-1.742.6 63 63 0 0 0 .018.938l1.074 2.083a.75.75 0 0 1-1.333.688l-1.006-1.95-1.038 1.958a.75.75 0 1 1-1.325-.703L6.75 8.688V7.75a6.6 6.6 0 0 1-1.753-.602.75.75 0 0 1 .684-1.335 5.09 5.09 0 0 0 4.638-.001"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8 3.558a1.125 1.125 0 1 1 0 2.25 1.125 1.125 0 0 1 0-2.25"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.36 1.009A7 7 0 0 1 15 8l-.009.36A7 7 0 0 1 8 15l-.36-.009a7 7 0 0 1-6.631-6.63L1 8a7 7 0 0 1 7-7zM8 2.5a5.5 5.5 0 1 0 0 11 5.5 5.5 0 0 0 0-11"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
