// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayoutSplitColumns3Outlined : GravityIcon
{
    public LayoutSplitColumns3Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayoutSplitColumns3Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 2, 15, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117647058823528, 0, 0, 0.94117647058823528, 0.47058823529411775, 0.47058823529411775);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.5 12.5H3a.5.5 0 0 0 .5-.5V4a.5.5 0 0 0-.5-.5h-.5A.5.5 0 0 0 2 4v8a.5.5 0 0 0 .5.5M3 14h-.5a2 2 0 0 1-2-2V4a2 2 0 0 1 2-2H3a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2m4.75-1.5h.5a.5.5 0 0 0 .5-.5V4a.5.5 0 0 0-.5-.5h-.5a.5.5 0 0 0-.5.5v8a.5.5 0 0 0 .5.5m.5 1.5h-.5a2 2 0 0 1-2-2V4a2 2 0 0 1 2-2h.5a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2m5.25-1.5H13a.5.5 0 0 1-.5-.5V4a.5.5 0 0 1 .5-.5h.5a.5.5 0 0 1 .5.5v8a.5.5 0 0 1-.5.5M13 14h.5a2 2 0 0 0 2-2V4a2 2 0 0 0-2-2H13a2 2 0 0 0-2 2v8a2 2 0 0 0 2 2"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
