// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class StethoscopeOutlined : GravityIcon
{
    public StethoscopeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new StethoscopeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.49999991059303284, 0.99194705486297607, 15.500999450683594, 14.008157730102539);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94107162759245577, 0, 0, 0.94107162759245577, 0.47142697926035382, 0.47142697926035382);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.513 2.452a.75.75 0 0 0-.526-1.404l-1.027.385A2.25 2.25 0 0 0 .5 3.539V6a4.75 4.75 0 0 0 4.274 4.727 4.75 4.75 0 0 0 9.476-.477v-.364a2.501 2.501 0 1 0-1.5 0v.364a3.25 3.25 0 0 1-6.477.39A4.75 4.75 0 0 0 10 6V3.54a2.25 2.25 0 0 0-1.46-2.107l-1.027-.385a.75.75 0 1 0-.526 1.404l1.026.385a.75.75 0 0 1 .487.702V6A3.25 3.25 0 1 1 2 6V3.54a.75.75 0 0 1 .487-.703zM13.5 8.5a1 1 0 1 0 0-2 1 1 0 0 0 0 2"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
