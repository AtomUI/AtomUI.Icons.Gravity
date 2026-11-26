// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LifeRingOutlined : GravityIcon
{
    public LifeRingOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LifeRingOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 13.5c1.248 0 2.4-.416 3.323-1.117l-1.436-1.435A3.5 3.5 0 0 1 8 11.5a3.5 3.5 0 0 1-1.887-.552l-1.436 1.435A5.48 5.48 0 0 0 8 13.5M5.052 9.887A3.5 3.5 0 0 1 4.5 8c0-.695.203-1.343.552-1.887L3.617 4.677A5.48 5.48 0 0 0 2.5 8c0 1.248.416 2.4 1.117 3.323zm1.06-4.835L4.678 3.617A5.48 5.48 0 0 1 8 2.5c1.248 0 2.4.416 3.323 1.117L9.887 5.052A3.5 3.5 0 0 0 8 4.5c-.695 0-1.343.203-1.887.552m4.836 1.06c.35.545.552 1.193.552 1.888s-.203 1.343-.552 1.887l1.435 1.436A5.48 5.48 0 0 0 13.5 8c0-1.248-.416-2.4-1.117-3.323zM8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14m2-7a2 2 0 1 1-4 0 2 2 0 0 1 4 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
