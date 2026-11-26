// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BackwardStepFilled : GravityIcon
{
    public BackwardStepFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BackwardStepFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1.97853684425354, 13.062000274658203, 12.085464477539062);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0624170531667918, 0, 0, 1.0624170531667918, -0.49933642533433442, -0.49933642533433442);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2.316 2.073A.75.75 0 0 1 3 2.82v10.494a.75.75 0 0 1-1.5 0V2.82a.75.75 0 0 1 .816-.747m9.54.193c1.164-.76 2.706.076 2.706 1.465v8.478c0 1.39-1.542 2.225-2.706 1.466l-6.498-4.24a1.75 1.75 0 0 1 0-2.93z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
