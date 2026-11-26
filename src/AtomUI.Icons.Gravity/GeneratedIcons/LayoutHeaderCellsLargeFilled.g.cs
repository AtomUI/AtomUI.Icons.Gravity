// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayoutHeaderCellsLargeFilled : GravityIcon
{
    public LayoutHeaderCellsLargeFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayoutHeaderCellsLargeFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 2, 14, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 6H8.75v2.5h4.75zM7.25 6H2.5v2.5h4.75zM1 6V5a3 3 0 0 1 3-3h8a3 3 0 0 1 3 3v6a3 3 0 0 1-3 3H4a3 3 0 0 1-3-3zm7.75 4h4.75v1a1.5 1.5 0 0 1-1.5 1.5H8.75zM2.5 10h4.75v2.5H4A1.5 1.5 0 0 1 2.5 11z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
