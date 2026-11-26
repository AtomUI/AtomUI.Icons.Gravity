// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LetterMOutlined : GravityIcon
{
    public LetterMOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LetterMOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.75, 1.9994627237319946, 10.5, 12.000537872314453);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0847456750428737, 0, 0, 1.0847456750428737, -0.67796540034298935, -0.67796540034298935);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.062 2c.454 0 .876.234 1.115.62L8 7.162l2.823-4.542a1.312 1.312 0 0 1 2.427.692v9.938a.75.75 0 0 1-1.5 0V3.97L8.637 8.98a.75.75 0 0 1-1.274 0L4.25 3.97v9.28a.75.75 0 0 1-1.5 0V3.312C2.75 2.588 3.338 2 4.062 2"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
