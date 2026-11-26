// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayoutSplitRowsOutlined : GravityIcon
{
    public LayoutSplitRowsOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayoutSplitRowsOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.5, 14, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258064516129, 0, 0, 1.032258064516129, -0.25806451612903203, -0.25806451612903203);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 4v1a1 1 0 0 1-1 1h-9a1 1 0 0 1-1-1V4a1 1 0 0 1 1-1h9a1 1 0 0 1 1 1M15 5V4a2.5 2.5 0 0 0-2.5-2.5h-9A2.5 2.5 0 0 0 1 4v1a2.5 2.5 0 0 0 2.5 2.5h9A2.5 2.5 0 0 0 15 5m-1.5 6v1a1 1 0 0 1-1 1h-9a1 1 0 0 1-1-1v-1a1 1 0 0 1 1-1h9a1 1 0 0 1 1 1m1.5 1v-1a2.5 2.5 0 0 0-2.5-2.5h-9A2.5 2.5 0 0 0 1 11v1a2.5 2.5 0 0 0 2.5 2.5h9A2.5 2.5 0 0 0 15 12"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
