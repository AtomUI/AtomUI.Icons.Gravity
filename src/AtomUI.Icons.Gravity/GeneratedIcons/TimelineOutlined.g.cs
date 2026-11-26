// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TimelineOutlined : GravityIcon
{
    public TimelineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TimelineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 0.50000005960464478, 16, 15.000000953674316);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96969702924688472, 0, 0, 0.96969702924688472, 0.24242376602492222, 0.24242376602492222);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.25 1.25v13.5a.75.75 0 0 0 1.5 0V1.25a.75.75 0 0 0-1.5 0M2.5 2H6v1.5H2.5a1 1 0 0 0-1 1v1.75a1 1 0 0 0 1 1H6v1.5h-.5a1 1 0 0 0-1 1v1.75a1 1 0 0 0 1 1H6V14h-.5A2.5 2.5 0 0 1 3 11.5V9.75c0-.356.074-.694.208-1H2.5A2.5 2.5 0 0 1 0 6.25V4.5A2.5 2.5 0 0 1 2.5 2m8 5.25H10v1.5h3.5a1 1 0 0 1 1 1v1.75a1 1 0 0 1-1 1H10V14h3.5a2.5 2.5 0 0 0 2.5-2.5V9.75a2.5 2.5 0 0 0-2.5-2.5h-.708c.134-.306.208-.644.208-1V4.5A2.5 2.5 0 0 0 10.5 2H10v1.5h.5a1 1 0 0 1 1 1v1.75a1 1 0 0 1-1 1"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
