// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TrafficLightOutlined : GravityIcon
{
    public TrafficLightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TrafficLightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000541210174561, 0.5, 13.999892234802246, 15);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99999664724997239, 0, 0, 0.99999664724997239, 2.6822000220860787E-05, 2.6822000220860787E-05);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.5 12.5v-9A1.5 1.5 0 0 1 6 2h4a1.5 1.5 0 0 1 1.5 1.5v9A1.5 1.5 0 0 1 10 14H6a1.5 1.5 0 0 1-1.5-1.5m10.374-7.834L13 7.477v.773h1.25a.75.75 0 0 1 .624 1.166L13 12.227v.273a3 3 0 0 1-3 3H6a3 3 0 0 1-3-3v-.273L1.126 9.416A.75.75 0 0 1 1.75 8.25H3v-.773L1.126 4.666A.75.75 0 0 1 1.75 3.5H3a3 3 0 0 1 3-3h4a3 3 0 0 1 3 3h1.25a.75.75 0 0 1 .624 1.166M8 7.25a1.75 1.75 0 1 0 0-3.5 1.75 1.75 0 0 0 0 3.5m0 5a1.75 1.75 0 1 0 0-3.5 1.75 1.75 0 0 0 0 3.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
