// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TriangleLeftOutlined : GravityIcon
{
    public TriangleLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TriangleLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99524998664855957, 0.57894551753997803, 13.50475025177002, 14.841673851013184);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.97911795371475996, 0, 0, 0.97911795371475996, 0.16705637028192033, 0.16705637028192033);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.995 7.134 11.5 2.217a1 1 0 0 1 1.5.866v9.834a1 1 0 0 1-1.5.866L2.995 8.866a1 1 0 0 1 0-1.732m-.751 3.03c-1.665-.962-1.665-3.366 0-4.329L10.749.918c1.666-.963 3.751.24 3.751 2.165v9.834c0 1.925-2.085 3.128-3.751 2.164z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
