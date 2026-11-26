// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class RoundBracketsOutlined : GravityIcon
{
    public RoundBracketsOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new RoundBracketsOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.91230732202529907, 1.0187065601348877, 14.175384521484375, 14.000016212463379);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0556414826682907, 0, 0, 1.0556414826682907, -0.44513186134632576, -0.44513186134632576);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.22 2.28a.75.75 0 0 1 1.06-1.06 9.59 9.59 0 0 1 0 13.56.75.75 0 1 1-1.06-1.06 8.09 8.09 0 0 0 0-11.44m-6.44 0a.75.75 0 0 0-1.06-1.06 9.59 9.59 0 0 0 0 13.56.75.75 0 0 0 1.06-1.06 8.09 8.09 0 0 1 0-11.44"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
