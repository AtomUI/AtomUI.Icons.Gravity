// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ThunderboltFilled : GravityIcon
{
    public ThunderboltFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ThunderboltFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.4023032188415527, 0.2540135383605957, 11.143199920654297, 15.49366569519043);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.89137208673724533, 0, 0, 0.89137208673724533, 0.86902330610203737, 0.86902330610203737);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M9.453.489a.751.751 0 0 1 1.287.636l-.856 5.122 2.41.003c1.113 0 1.67 1.347.883 2.134L6.03 15.528a.75.75 0 0 1-1.258-.712l1.266-5.068-2.382.003c-1.095 0-1.662-1.307-.913-2.106z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
