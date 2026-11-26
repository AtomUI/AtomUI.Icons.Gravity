// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeRightOutlined : GravityIcon
{
    public ArrowShapeRightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeRightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.5017485618591309, 13.999512672424316, 12.998191833496094);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0323190080020153, 0, 0, 1.0323190080020153, -0.25855206401612207, -0.25855206401612207);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.5 10v2.67a.33.33 0 0 0 .542.252l5.225-4.421a.656.656 0 0 0 0-1.002L8.042 3.078a.33.33 0 0 0-.543.252V6H3a.5.5 0 0 0-.5.5v3a.5.5 0 0 0 .5.5zM3 11.5a2 2 0 0 1-2-2v-3a2 2 0 0 1 2-2h3V3.33a1.83 1.83 0 0 1 3.01-1.397l5.226 4.421a2.156 2.156 0 0 1 0 3.292L9.01 14.067a1.83 1.83 0 0 1-3.012-1.397V11.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
