// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CookieOutlined : GravityIcon
{
    public CookieOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CookieOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0509445667266846, 1.3814378976821899, 13.897998809814453, 13.567330360412598);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0702972222318579, 0, 0, 1.0702972222318579, -0.56237777785486287, -0.56237777785486287);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M7.005 9.755a1 1 0 1 1 0 2 1 1 0 0 1 0-2M10.25 8.75a1 1 0 1 1 0 2 1 1 0 0 1 0-2M5 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.846 1.398a.75.75 0 0 1 .906.7 2.25 2.25 0 0 0 2.734 2.097l.141-.017a.75.75 0 0 1 .733.518A2.25 2.25 0 0 0 12.5 6.25c.418 0 .81-.117 1.148-.32l.08-.04a.75.75 0 0 1 1.035.513 6.949 6.949 0 1 1-9.001-4.982zm-.404 1.79a5.45 5.45 0 1 0 7.992 4.44 3.7 3.7 0 0 1-.934.122 3.75 3.75 0 0 1-3.317-2.006q-.09.005-.183.006a3.75 3.75 0 0 1-3.558-2.562"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
