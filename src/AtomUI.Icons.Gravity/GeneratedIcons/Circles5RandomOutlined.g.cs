// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class Circles5RandomOutlined : GravityIcon
{
    public Circles5RandomOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new Circles5RandomOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(-1.5392426178095775E-07, 1.0000002384185791, 16, 15.000001907348633);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99999972215890931, 0, 0, 0.99999972215890931, 2.2227287255205397E-06, 2.2227287255205397E-06);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M1.069 5.55A2.497 2.497 0 0 0 5 3.5a2.5 2.5 0 1 0-3.931 2.05M2.5 4.5a1 1 0 1 0 0-2 1 1 0 0 0 0 2m11 1.5A2.497 2.497 0 0 1 11 3.5 2.5 2.5 0 1 1 13.5 6m1-2.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0M6.069 8.55A2.497 2.497 0 0 0 10 6.5a2.5 2.5 0 1 0-3.931 2.05M7.5 7.5a1 1 0 1 0 0-2 1 1 0 0 0 0 2M12 14a2.497 2.497 0 0 1-2.5-2.5A2.5 2.5 0 1 1 12 14m1-2.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0M4.5 16A2.497 2.497 0 0 1 2 13.5 2.5 2.5 0 1 1 4.5 16m1-2.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
