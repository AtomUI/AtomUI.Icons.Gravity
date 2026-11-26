// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MinusShapeFilled : GravityIcon
{
    public MinusShapeFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MinusShapeFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 5, 14, 6);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.84210526315789469, 0, 0, 0.84210526315789469, 1.2631578947368425, 1.2631578947368425);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2.5 11h11A1.5 1.5 0 0 0 15 9.5v-3A1.5 1.5 0 0 0 13.5 5h-11A1.5 1.5 0 0 0 1 6.5v3A1.5 1.5 0 0 0 2.5 11"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
