// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayoutHeaderCursorOutlined : GravityIcon
{
    public LayoutHeaderCursorOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayoutHeaderCursorOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.5, 14, 14.255288124084473);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96907580689525785, 0, 0, 0.96907580689525785, 0.24739354483793718, 0.24739354483793718);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4 3h8a1.5 1.5 0 0 1 1.5 1.5V5h-11v-.5A1.5 1.5 0 0 1 4 3m9.5 5.25V6.5h-11V10A1.5 1.5 0 0 0 4 11.5h2.75a.75.75 0 0 1 0 1.5H4a3 3 0 0 1-3-3V4.5a3 3 0 0 1 3-3h8a3 3 0 0 1 3 3v3.75a.75.75 0 0 1-1.5 0m-3.272-.078A.75.75 0 0 0 9 8.75v5.544a.75.75 0 0 0 1.335.469l.898-1.12.846 1.692a.75.75 0 1 0 1.342-.67l-.827-1.654H14a.75.75 0 0 0 .478-1.328z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
