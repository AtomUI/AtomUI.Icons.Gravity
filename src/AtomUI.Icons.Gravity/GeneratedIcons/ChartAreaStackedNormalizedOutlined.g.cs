// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChartAreaStackedNormalizedOutlined : GravityIcon
{
    public ChartAreaStackedNormalizedOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChartAreaStackedNormalizedOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 2, 15, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117647058823528, 0, 0, 0.94117647058823528, 0.47058823529411775, 0.47058823529411775);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 12.5h-11A.5.5 0 0 1 2 12v-1.611l2.812-1.985a1.25 1.25 0 0 1 1.414-.019l1.753 1.169a2.75 2.75 0 0 0 3.757-.681L14 5.728V12a.5.5 0 0 1-.5.5m.22-8.95-3.201 4.446a1.25 1.25 0 0 1-1.708.31L7.058 7.137a2.75 2.75 0 0 0-3.111.042L2 8.553V4a.5.5 0 0 1 .5-.5h11q.119.001.22.05M.5 9.992V4a2 2 0 0 1 2-2h11a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2h-11a2 2 0 0 1-2-2V9.991"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
