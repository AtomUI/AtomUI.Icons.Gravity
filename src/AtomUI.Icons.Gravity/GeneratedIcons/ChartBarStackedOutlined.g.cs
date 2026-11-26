// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChartBarStackedOutlined : GravityIcon
{
    public ChartBarStackedOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChartBarStackedOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 2, 15, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117647058823528, 0, 0, 0.94117647058823528, 0.47058823529411775, 0.47058823529411775);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14 12a.5.5 0 0 1-.5.5h-11A.5.5 0 0 1 2 12v-1a.5.5 0 0 1 .5-.5h11a.5.5 0 0 1 .5.5zm0-3.5a.5.5 0 0 1-.5.5H12a.5.5 0 0 1-.5-.5v-1A.5.5 0 0 1 12 7h1.5a.5.5 0 0 1 .5.5zM14 5V4a.5.5 0 0 0-.5-.5H8a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h5.5A.5.5 0 0 0 14 5M2.5 3.5A.5.5 0 0 0 2 4v1a.5.5 0 0 0 .5.5h3A.5.5 0 0 0 6 5V4a.5.5 0 0 0-.5-.5zm-.5 4v1a.5.5 0 0 0 .5.5h7a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5h-7a.5.5 0 0 0-.5.5M.5 12a2 2 0 0 0 2 2h11a2 2 0 0 0 2-2V4a2 2 0 0 0-2-2h-11a2 2 0 0 0-2 2z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
