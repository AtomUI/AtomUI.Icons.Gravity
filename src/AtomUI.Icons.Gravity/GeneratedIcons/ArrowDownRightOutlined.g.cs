// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowDownRightOutlined : GravityIcon
{
    public ArrowDownRightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowDownRightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.5204060077667236, 2.5209062099456787, 10.956594467163086, 10.957093238830566);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1870318178200954, 0, 0, 1.1870318178200954, -1.496254542560763, -1.496254542560763);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M3.802 2.741A.75.75 0 0 0 2.74 3.802l8.176 8.176H7.07a.75.75 0 0 0 0 1.5h5.657a.75.75 0 0 0 .75-.75V7.072a.751.751 0 0 0-1.5 0v3.846z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
