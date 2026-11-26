// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SquareLineVerticalOutlined : GravityIcon
{
    public SquareLineVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SquareLineVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 0, 13, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.91428571428571426, 0, 0, 0.91428571428571426, 0.68571428571428594, 0.68571428571428594);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.75.75a.75.75 0 0 0-1.5 0v.75H4.5a3 3 0 0 0-3 3v7a3 3 0 0 0 3 3h2.75v.75a.75.75 0 0 0 1.5 0v-.75h2.75a3 3 0 0 0 3-3v-7a3 3 0 0 0-3-3H8.75zM7.25 3H4.5A1.5 1.5 0 0 0 3 4.5v7A1.5 1.5 0 0 0 4.5 13h2.75zm1.5 10V3h2.75A1.5 1.5 0 0 1 13 4.5v7a1.5 1.5 0 0 1-1.5 1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
