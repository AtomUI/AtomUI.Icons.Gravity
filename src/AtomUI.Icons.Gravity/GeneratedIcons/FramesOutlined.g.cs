// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FramesOutlined : GravityIcon
{
    public FramesOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FramesOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.75, 0.75, 14.5, 14.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0491803278688525, 0, 0, 1.0491803278688525, -0.39344262295082011, -0.39344262295082011);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.25.75a.75.75 0 0 1 .75.75V2h.5a.75.75 0 0 1 0 1.5H14v5h.5a.75.75 0 0 1 0 1.5H14v.5a.75.75 0 0 1-1.5 0V10H10v2.5h.5a.75.75 0 0 1 0 1.5H10v.5a.75.75 0 0 1-1.5 0V14h-5v.5a.75.75 0 0 1-1.5 0V14h-.5a.75.75 0 0 1 0-1.5H2v-5h-.5a.75.75 0 0 1 0-1.5H2v-.5a.75.75 0 0 1 1.5 0V6H6V3.5h-.5a.75.75 0 0 1 0-1.5H6v-.5a.75.75 0 0 1 1.5 0V2h5v-.5a.75.75 0 0 1 .75-.75M7.5 6h1v-.5a.75.75 0 0 1 1.5 0V6h.5a.75.75 0 0 1 0 1.5H10v1h2.5v-5h-5zm-4 6.5v-5h5v5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
