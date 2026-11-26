// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleLetterGOutlined : GravityIcon
{
    public CircleLetterGOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleLetterGOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 8a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0M15 8A7 7 0 1 1 1 8a7 7 0 0 1 14 0M6.458 8c0-.8.2-1.289.445-1.569C7.136 6.165 7.487 6 8 6c.602 0 .995.225 1.235.62a.75.75 0 1 0 1.283-.776C9.964 4.93 9.04 4.5 8 4.5c-.862 0-1.657.293-2.226.944-.557.637-.816 1.523-.816 2.556s.259 1.92.816 2.556c.569.65 1.364.944 2.226.944.574 0 1.228-.118 1.767-.422.56-.316 1.05-.877 1.05-1.703 0-.068.003-.132.006-.21l.005-.144a3 3 0 0 0-.012-.473 1.3 1.3 0 0 0-.23-.633A1.02 1.02 0 0 0 9.75 7.5H8.5a.75.75 0 0 0 0 1.5h.828l-.003.07a8 8 0 0 0-.008.305c0 .14-.057.267-.287.397C8.778 9.914 8.398 10 8 10c-.513 0-.864-.165-1.097-.431-.245-.28-.445-.77-.445-1.569m2.863.69.002.007z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
