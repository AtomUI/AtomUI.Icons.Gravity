// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SquareLineHorizontalOutlined : GravityIcon
{
    public SquareLineHorizontalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SquareLineHorizontalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 1.5, 16, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.91428571428571426, 0, 0, 0.91428571428571426, 0.68571428571428594, 0.68571428571428594);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M.75 7.25a.75.75 0 0 0 0 1.5h.75v2.75a3 3 0 0 0 3 3h7a3 3 0 0 0 3-3V8.75h.75a.75.75 0 0 0 0-1.5h-.75V4.5a3 3 0 0 0-3-3h-7a3 3 0 0 0-3 3v2.75zM3 8.75v2.75A1.5 1.5 0 0 0 4.5 13h7a1.5 1.5 0 0 0 1.5-1.5V8.75zm10-1.5H3V4.5A1.5 1.5 0 0 1 4.5 3h7A1.5 1.5 0 0 1 13 4.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
