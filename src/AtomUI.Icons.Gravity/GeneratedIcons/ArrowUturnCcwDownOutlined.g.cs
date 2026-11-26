// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowUturnCcwDownOutlined : GravityIcon
{
    public ArrowUturnCcwDownOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowUturnCcwDownOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5187115669250488, 2.25, 12.481288909912109, 11.499341011047363);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1227550207790991, 0, 0, 1.1227550207790991, -0.98204016623279244, -0.98204016623279244);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.72 13.53a.75.75 0 0 0 1.06 0l3-3a.75.75 0 1 0-1.06-1.06L6 11.19V7a3.25 3.25 0 0 1 6.5 0v1A.75.75 0 0 0 14 8V7a4.75 4.75 0 1 0-9.5 0v4.19L2.78 9.47a.75.75 0 0 0-1.06 1.06z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
