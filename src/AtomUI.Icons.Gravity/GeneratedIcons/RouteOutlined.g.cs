// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class RouteOutlined : GravityIcon
{
    public RouteOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new RouteOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99920910596847534, 0.9980003833770752, 14.002863883972168, 14.003000259399414);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0664430451413309, 0, 0, 1.0664430451413309, -0.5315443611306474, -0.5315443611306474);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.25 5a1.25 1.25 0 1 0 0-2.5 1.25 1.25 0 0 0 0 2.5m0 1.5a2.75 2.75 0 0 1-2.646-2H4.577a.827.827 0 0 0-.238 1.619l7.753 2.326A2.327 2.327 0 0 1 11.423 13H6.397a2.751 2.751 0 1 1 0-1.5h5.026a.827.827 0 0 0 .238-1.619L3.908 7.556A2.327 2.327 0 0 1 4.577 3h5.027a2.751 2.751 0 1 1 2.646 3.5M5 12.25a1.25 1.25 0 1 1-2.5 0 1.25 1.25 0 0 1 2.5 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
