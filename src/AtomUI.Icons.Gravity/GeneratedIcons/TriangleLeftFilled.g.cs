// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TriangleLeftFilled : GravityIcon
{
    public TriangleLeftFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TriangleLeftFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99524998664855957, 0.57938128709793091, 13.50475025177002, 14.841238021850586);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.97911796085742275, 0, 0, 0.97911796085742275, 0.16705631314061797, 0.16705631314061797);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2.244 10.164c-1.665-.962-1.665-3.366 0-4.328L10.749.919c1.666-.964 3.751.239 3.751 2.164v9.834c0 1.925-2.085 3.128-3.751 2.164z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
