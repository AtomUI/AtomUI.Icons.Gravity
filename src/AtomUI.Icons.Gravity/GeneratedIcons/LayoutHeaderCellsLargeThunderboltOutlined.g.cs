// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayoutHeaderCellsLargeThunderboltOutlined : GravityIcon
{
    public LayoutHeaderCellsLargeThunderboltOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayoutHeaderCellsLargeThunderboltOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 2, 14, 12.999783515930176);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666512724660968, 0, 0, 1.0666512724660968, -0.53321017972877449, -0.53321017972877449);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4 3.5h8A1.5 1.5 0 0 1 13.5 5v.5h-11V5A1.5 1.5 0 0 1 4 3.5m-1.5 7v.5A1.5 1.5 0 0 0 4 12.5h3.25v-2zm0-1.5h4.75V7H2.5zm6.25 1.5V14H4a3 3 0 0 1-3-3V5a3 3 0 0 1 3-3h8a3 3 0 0 1 3 3v2H8.75zm4.592-.91A.75.75 0 0 0 12 8.92l-1.25 2.5a.75.75 0 0 0 .67 1.085h1.287L12 13.92a.75.75 0 0 0 1.342.67l1.25-2.5a.75.75 0 0 0-.671-1.085h-1.287z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
