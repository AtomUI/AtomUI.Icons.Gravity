// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ThumbsDownFilled : GravityIcon
{
    public ThumbsDownFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ThumbsDownFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.1301157474517822, 0.76363164186477661, 13.620850563049316, 14.23741626739502);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0491026249293718, 0, 0, 1.0491026249293718, -0.39282099943497428, -0.39282099943497428);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.9 14.315a1.38 1.38 0 0 1-2.542-.984L7.07 10H3.13a2 2 0 0 1-1.927-2.535l.879-3.162A4 4 0 0 1 6.404 1.4L11.5 2l.5 7zm4.352-5.762a.75.75 0 1 0 1.496-.106l-.5-7a.75.75 0 0 0-1.496.106z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
