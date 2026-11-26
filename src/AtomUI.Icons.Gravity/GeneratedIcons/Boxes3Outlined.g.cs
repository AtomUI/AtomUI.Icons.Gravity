// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class Boxes3Outlined : GravityIcon
{
    public Boxes3Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new Boxes3Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 0.5, 15, 14.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.25 2H6.5a1 1 0 0 0-1 1v3a1 1 0 0 0 1 1h3a1 1 0 0 0 1-1V3a1 1 0 0 0-1-1h-.75v1.75a.75.75 0 0 1-1.5 0zM6.5.5A2.5 2.5 0 0 0 4 3v3c0 .356.074.694.208 1H3A2.5 2.5 0 0 0 .5 9.5v3A2.5 2.5 0 0 0 3 15h10a2.5 2.5 0 0 0 2.5-2.5v-3A2.5 2.5 0 0 0 13 7h-1.208c.134-.306.208-.644.208-1V3A2.5 2.5 0 0 0 9.5.5zm.75 9a1 1 0 0 0-1-1h-1v1.75a.75.75 0 0 1-1.5 0V8.5H3a1 1 0 0 0-1 1v3a1 1 0 0 0 1 1h3.25a1 1 0 0 0 1-1zm1.5 3a1 1 0 0 0 1 1H13a1 1 0 0 0 1-1v-3a1 1 0 0 0-1-1h-.75v1.75a.75.75 0 0 1-1.5 0V8.5h-1a1 1 0 0 0-1 1z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
