// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowsOppositeToDotsOutlined : GravityIcon
{
    public ArrowsOppositeToDotsOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowsOppositeToDotsOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 0.9812963604927063, 14, 14.037421226501465);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0640112453829043, 0, 0, 1.0640112453829043, -0.51208996306323407, -0.51208996306323407);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.28 4.78a.75.75 0 0 0 0-1.06l-2.5-2.5a.75.75 0 1 0-1.06 1.06L6.94 3.5H1.75a.75.75 0 1 0 0 1.5h5.19L5.72 6.22a.75.75 0 1 0 1.06 1.06zm-.06 3.94-2.5 2.5a.75.75 0 0 0 0 1.06l2.5 2.5a.75.75 0 1 0 1.06-1.06L9.06 12.5h5.19a.75.75 0 0 0 0-1.5H9.06l1.22-1.22a.75.75 0 1 0-1.06-1.06M14 4.25a1.75 1.75 0 1 1-3.5 0 1.75 1.75 0 0 1 3.5 0M3.75 13.5a1.75 1.75 0 1 0 0-3.5 1.75 1.75 0 0 0 0 3.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
