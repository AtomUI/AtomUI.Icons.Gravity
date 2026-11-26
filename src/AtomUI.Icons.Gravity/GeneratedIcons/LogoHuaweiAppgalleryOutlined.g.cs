// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoHuaweiAppgalleryOutlined : GravityIcon
{
    public LogoHuaweiAppgalleryOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoHuaweiAppgalleryOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1.5, 13, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.103448275862069, 0, 0, 1.103448275862069, -0.8275862068965516, -0.8275862068965516);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M9.884 4.915a.75.75 0 0 1 1.342.67C10.75 6.536 9.49 7.268 8 7.268s-2.75-.732-3.226-1.683a.75.75 0 0 1 1.342-.67c.164.326.82.853 1.884.853s1.72-.527 1.884-.853"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.5 1.5a3 3 0 0 1 3 3v7a3 3 0 0 1-2.846 2.996l-.154.004h-7l-.154-.004a3 3 0 0 1-2.842-2.842L1.5 11.5v-7a3 3 0 0 1 3-3zM4.5 3A1.5 1.5 0 0 0 3 4.5v7A1.5 1.5 0 0 0 4.5 13h7a1.5 1.5 0 0 0 1.5-1.5v-7A1.5 1.5 0 0 0 11.5 3z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
