// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class GripHorizontalOutlined : GravityIcon
{
    public GripHorizontalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new GripHorizontalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 4, 13, 8);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117647058823528, 0, 0, 0.94117647058823528, 0.47058823529411775, 0.47058823529411775);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3 9a1.5 1.5 0 1 1 0 3 1.5 1.5 0 0 1 0-3m6.5 1.5a1.5 1.5 0 1 0-3 0 1.5 1.5 0 0 0 3 0m0-5a1.5 1.5 0 1 0-3 0 1.5 1.5 0 0 0 3 0m-5 0a1.5 1.5 0 1 0-3 0 1.5 1.5 0 0 0 3 0M13 9a1.5 1.5 0 1 1 0 3 1.5 1.5 0 0 1 0-3m1.5-3.5a1.5 1.5 0 1 0-3 0 1.5 1.5 0 0 0 3 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
