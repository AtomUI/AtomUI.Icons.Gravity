// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TrapezoidLeftLineHorizontalOutlined : GravityIcon
{
    public TrapezoidLeftLineHorizontalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TrapezoidLeftLineHorizontalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 0.99917423725128174, 16, 14.001651763916016);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94122220297872627, 0, 0, 0.94122220297872627, 0.4702223761701898, 0.4702223761701898);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M.75 7.25a.75.75 0 0 0 0 1.5H2v2.234a2.5 2.5 0 0 0 1.97 2.443l7 1.517A2.5 2.5 0 0 0 14 12.5V8.75h1.25a.75.75 0 0 0 0-1.5H14V3.5a2.5 2.5 0 0 0-3.03-2.444l-7 1.517A2.5 2.5 0 0 0 2 5.016V7.25zm2.75 1.5v2.234a1 1 0 0 0 .788.977l7 1.517A1 1 0 0 0 12.5 12.5V8.75zm9-1.5h-9V5.016a1 1 0 0 1 .788-.977l7-1.517A1 1 0 0 1 12.5 3.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
