// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class DiamondFilled : GravityIcon
{
    public DiamondFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new DiamondFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.0506405308842659, 0.050640683621168137, 15.898719787597656, 15.89871883392334);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0031749786214952, 0, 0, 1.0031749786214952, -0.025399828971961469, -0.025399828971961469);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M5.879.929a3 3 0 0 1 4.242 0l4.95 4.95a3 3 0 0 1 0 4.242l-4.95 4.95a3 3 0 0 1-4.242 0l-4.95-4.95a3 3 0 0 1 0-4.242z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
