// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CheckShapeFilled : GravityIcon
{
    public CheckShapeFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CheckShapeFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.63127607107162476, 1.6888597011566162, 14.307662010192871, 12.655961036682129);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0300613474003015, 0, 0, 1.0300613474003015, -0.24049077920241224, -0.24049077920241224);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 m8.475 13.782 6.135-7.67a1.5 1.5 0 0 0-.174-2.058L12.2 2.068a1.5 1.5 0 0 0-2.184.204L6.75 6.5 5.122 5.02a1.5 1.5 0 0 0-2.13.114L1.01 7.364a1.5 1.5 0 0 0 .139 2.13l5.173 4.484a1.5 1.5 0 0 0 2.154-.196"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
