// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class Cubes3OverlapOutlined : GravityIcon
{
    public Cubes3OverlapOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new Cubes3OverlapOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 1, 16, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.88888888888888884, 0, 0, 0.88888888888888884, 0.88888888888888928, 0.88888888888888928);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.5 2.5h-3A1.5 1.5 0 0 0 5 4v1h1a3 3 0 0 1 3 3v.5h.5A1.5 1.5 0 0 0 11 7V4a1.5 1.5 0 0 0-1.5-1.5M9 10v1c0 .546-.146 1.059-.401 1.5H13a1.5 1.5 0 0 0 1.5-1.5V8A1.5 1.5 0 0 0 13 6.5h-.5V7a3 3 0 0 1-3 3zm3.5-5V4a3 3 0 0 0-3-3h-3a3 3 0 0 0-3 3v1H3a3 3 0 0 0-3 3v3a3 3 0 0 0 3 3h10a3 3 0 0 0 3-3V8a3 3 0 0 0-3-3zM6 6.5H3A1.5 1.5 0 0 0 1.5 8v3A1.5 1.5 0 0 0 3 12.5h3A1.5 1.5 0 0 0 7.5 11V8A1.5 1.5 0 0 0 6 6.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
