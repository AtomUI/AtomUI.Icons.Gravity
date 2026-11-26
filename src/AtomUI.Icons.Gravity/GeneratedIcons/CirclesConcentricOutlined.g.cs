// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CirclesConcentricOutlined : GravityIcon
{
    public CirclesConcentricOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CirclesConcentricOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99752485752105713, 0.99752485752105713, 14.003952980041504, 14.004953384399414);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0664193536189559, 0, 0, 1.0664193536189559, -0.53135482895164721, -0.53135482895164721);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.5 8a5.5 5.5 0 0 1 8.14-4.827.75.75 0 1 0 .72-1.315 7 7 0 0 0-9.502 9.502.75.75 0 0 0 1.315-.72A5.5 5.5 0 0 1 2.5 8m11.642-3.36a.75.75 0 1 0-1.315.72 5.5 5.5 0 0 1-7.466 7.466.75.75 0 1 0-.722 1.316 7 7 0 0 0 9.502-9.502M9.5 8a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0M11 8a3 3 0 1 1-6 0 3 3 0 0 1 6 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
