// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CalendarXmarkOutlined : GravityIcon
{
    public CalendarXmarkOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CalendarXmarkOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 0.94999998807907104, 13, 13.423999786376953);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.093942277674546, 0, 0, 1.093942277674546, -0.75153822139636794, -0.75153822139636794);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M9.151 6.47a.751.751 0 0 1 1.062 1.06L9.15 8.59l1.06 1.061a.751.751 0 0 1-1.06 1.062L8.091 9.65l-1.06 1.062A.75.75 0 0 1 5.97 9.65l1.06-1.06-1.06-1.06a.75.75 0 0 1 1.06-1.06l1.06 1.06z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11 .95a.75.75 0 0 1 .75.75v.687a3 3 0 0 1 2.75 2.987v6l-.004.154a3 3 0 0 1-2.842 2.842l-.154.004h-7a3 3 0 0 1-2.996-2.846l-.004-.154v-6a3 3 0 0 1 2.75-2.99V1.7a.75.75 0 0 1 1.5 0v.674h4.5V1.7A.75.75 0 0 1 11 .95M5.75 4.476a.75.75 0 0 1-1.5 0v-.58A1.5 1.5 0 0 0 3 5.373v6a1.5 1.5 0 0 0 1.5 1.5h7a1.5 1.5 0 0 0 1.5-1.5v-6a1.5 1.5 0 0 0-1.25-1.479v.581a.75.75 0 0 1-1.5 0v-.602h-4.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
