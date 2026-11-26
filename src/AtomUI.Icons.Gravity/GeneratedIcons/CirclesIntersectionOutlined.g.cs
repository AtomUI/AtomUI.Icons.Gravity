// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CirclesIntersectionOutlined : GravityIcon
{
    public CirclesIntersectionOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CirclesIntersectionOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.0020010471343994141, 2.4999995231628418, 15.995998382568359, 11);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.86505193415790205, 0, 0, 0.86505193415790205, 1.0795845267367836, 1.0795845267367836);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.576 11.854a4 4 0 1 1 0-7.707A5.48 5.48 0 0 0 5 8c0 1.5.601 2.861 1.576 3.854M8 12.9a5.5 5.5 0 1 1 0-9.8 5.5 5.5 0 1 1 0 9.8m1.424-8.754A4.003 4.003 0 0 1 14.5 8a4 4 0 0 1-5.076 3.854A5.48 5.48 0 0 0 11 8c0-1.5-.601-2.861-1.576-3.854M8 4.877C8.914 5.61 9.5 6.737 9.5 8s-.586 2.39-1.5 3.123A4 4 0 0 1 6.5 8c0-1.263.586-2.39 1.5-3.123"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
