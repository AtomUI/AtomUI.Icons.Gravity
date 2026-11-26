// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SquareBracketsOutlined : GravityIcon
{
    public SquareBracketsOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SquareBracketsOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1, 13, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258064516129, 0, 0, 1.032258064516129, -0.25806451612903203, -0.25806451612903203);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.75 1A2.25 2.25 0 0 0 1.5 3.25v9.5A2.25 2.25 0 0 0 3.75 15h.5a.75.75 0 0 0 0-1.5h-.5a.75.75 0 0 1-.75-.75v-9.5a.75.75 0 0 1 .75-.75h.5a.75.75 0 0 0 0-1.5zm8.5 14a2.25 2.25 0 0 0 2.25-2.25v-9.5A2.25 2.25 0 0 0 12.25 1h-.5a.75.75 0 0 0 0 1.5h.5a.75.75 0 0 1 .75.75v9.5a.75.75 0 0 1-.75.75h-.5a.75.75 0 0 0 0 1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
