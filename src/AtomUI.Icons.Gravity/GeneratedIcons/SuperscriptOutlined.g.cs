// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SuperscriptOutlined : GravityIcon
{
    public SuperscriptOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SuperscriptOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.25, 1.25, 13.721000671386719, 13.02299976348877);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0211244104508184, 0, 0, 1.0211244104508184, -0.16899528360654692, -0.16899528360654692);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M9.111 4.25a.75.75 0 0 1 0 1.5H6.306v7.023h.587a.75.75 0 0 1 0 1.5H4.226a.75.75 0 0 1 0-1.5h.58V5.75H2a.75.75 0 0 1 0-1.5zm3.834-3A1.92 1.92 0 0 1 14.1 4.701L12.707 5.75h1.514a.75.75 0 0 1 0 1.5h-2.2a1.27 1.27 0 0 1-1.264-1.14l-.007-.13.009-.149a1.27 1.27 0 0 1 .498-.867l1.94-1.461a.419.419 0 0 0-.252-.753h-.135a.58.58 0 0 0-.529.342l-.097.216a.75.75 0 1 1-1.368-.616l.098-.216A2.08 2.08 0 0 1 12.81 1.25z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
