// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class DiamondExclamationFilled : GravityIcon
{
    public DiamondExclamationFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new DiamondExclamationFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(-0.0008593727252446115, 0.10114060342311859, 15.900717735290527, 15.899717330932617);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99367417665276758, 0, 0, 0.99367417665276758, 0.050606586777859341, 0.050606586777859341);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.828.98a3 3 0 0 1 4.243 0l4.95 4.949a3 3 0 0 1 0 4.243l-4.95 4.95a3 3 0 0 1-4.243 0l-4.95-4.95a3 3 0 0 1 0-4.243zM7.95 9.55a1 1 0 1 0 0 2 1 1 0 0 0 0-2m0-5.25a.75.75 0 0 0-.75.75v2.5a.75.75 0 1 0 1.5 0v-2.5a.75.75 0 0 0-.75-.75"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
