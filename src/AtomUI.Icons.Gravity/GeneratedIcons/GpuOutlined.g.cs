// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class GpuOutlined : GravityIcon
{
    public GpuOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new GpuOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 0.5, 16, 14.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117647058823528, 0, 0, 0.94117647058823528, 0.47058823529411775, 0.47058823529411775);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M0 1.25A.75.75 0 0 1 .75.5h.5A2.25 2.25 0 0 1 3.5 2.75V3H13a3 3 0 0 1 3 3v4a3 3 0 0 1-3 3H3.5v1.25a.75.75 0 0 1-1.5 0V2.75A.75.75 0 0 0 1.25 2h-.5A.75.75 0 0 1 0 1.25M13 4.5H3.5v7H13a1.5 1.5 0 0 0 1.5-1.5V6A1.5 1.5 0 0 0 13 4.5M8.5 8a1 1 0 1 1-2 0 1 1 0 0 1 2 0M10 8a2.5 2.5 0 1 1-5 0 2.5 2.5 0 0 1 5 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
