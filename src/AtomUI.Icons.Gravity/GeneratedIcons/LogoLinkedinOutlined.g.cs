// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoLinkedinOutlined : GravityIcon
{
    public LogoLinkedinOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoLinkedinOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1.5, 13, 13.00100040435791);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1032960355638561, 0, 0, 1.1032960355638561, -0.82636828451084909, -0.82636828451084909);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M9.25 6.35A2.25 2.25 0 0 1 11.5 8.6V11a.75.75 0 0 1-1.5 0V8.6a.75.75 0 0 0-1.5 0V11A.75.75 0 0 1 7 11V7.25a.75.75 0 0 1 1.167-.624c.321-.176.69-.276 1.083-.276m-3.996.15a.75.75 0 0 1 .75.75V11a.75.75 0 0 1-1.5 0V7.25a.75.75 0 0 1 .75-.75M5.25 4a1 1 0 1 1 0 2.001 1 1 0 0 1 0-2"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.5 1.5a3 3 0 0 1 3 3v7a3 3 0 0 1-2.846 2.997l-.154.004h-7l-.154-.004a3 3 0 0 1-2.842-2.842L1.5 11.5v-7a3 3 0 0 1 3-3zM4.5 3A1.5 1.5 0 0 0 3 4.5v7A1.5 1.5 0 0 0 4.5 13h7a1.5 1.5 0 0 0 1.5-1.5v-7A1.5 1.5 0 0 0 11.5 3z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
