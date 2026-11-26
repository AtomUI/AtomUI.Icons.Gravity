// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TvRetroOutlined : GravityIcon
{
    public TvRetroOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TvRetroOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 0.5002409815788269, 14, 14.994579315185547);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0006478823842635, 0, 0, 1.0006478823842635, -0.0051830590741079874, -0.0051830590741079874);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.086.782a.75.75 0 0 0-1.172.937L5.94 3H4a3 3 0 0 0-3 3v5a3 3 0 0 0 2.79 2.993l-.21.421a.75.75 0 0 0 1.34.671l.5-1A1 1 0 0 0 5.458 14h5.086q.015.043.036.085l.5 1a.75.75 0 0 0 1.342-.67l-.211-.422A3 3 0 0 0 15 11V6a3 3 0 0 0-3-3h-1.94l1.026-1.281A.75.75 0 0 0 9.914.782L8.14 3h-.28zM7.494 4.5H12A1.5 1.5 0 0 1 13.5 6v5a1.5 1.5 0 0 1-1.5 1.5H4A1.5 1.5 0 0 1 2.5 11V6A1.5 1.5 0 0 1 4 4.5zM5.5 7.5v2H8v-2zM5 6a1 1 0 0 0-1 1v3a1 1 0 0 0 1 1h3.5a1 1 0 0 0 1-1V7a1 1 0 0 0-1-1zm7 .75a.75.75 0 0 0-1.5 0v3.5a.75.75 0 0 0 1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
