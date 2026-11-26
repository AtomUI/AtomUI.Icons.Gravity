// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ServerPlusOutlined : GravityIcon
{
    public ServerPlusOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ServerPlusOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 1.9999998807907104, 16.003000259399414, 12.003000378608704);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.88874075262240571, 0, 0, 0.88874075262240571, 0.89007397902075436, 0.89007397902075436);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M13.001 8a.75.75 0 0 1 .75.75v1.501h1.502a.75.75 0 0 1 0 1.5H13.75v1.502a.75.75 0 0 1-1.5 0V11.75h-1.5a.75.75 0 0 1 0-1.5h1.501v-1.5a.75.75 0 0 1 .75-.75"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M10.747 2a3 3 0 0 1 3.001 3v1a.75.75 0 0 1-1.5 0V5a1.5 1.5 0 0 0-1.5-1.5H3A1.5 1.5 0 0 0 1.5 5v2.25h7.25a.75.75 0 0 1 0 1.5H1.5V11A1.5 1.5 0 0 0 3 12.5h5.5a.75.75 0 0 1 0 1.5H3a3 3 0 0 1-3-3V5a3 3 0 0 1 3-3z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M6 9.75a.75.75 0 0 1 0 1.5H3.5a.75.75 0 0 1 0-1.5zm0-5a.75.75 0 0 1 0 1.5H3.5a.75.75 0 0 1 0-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
