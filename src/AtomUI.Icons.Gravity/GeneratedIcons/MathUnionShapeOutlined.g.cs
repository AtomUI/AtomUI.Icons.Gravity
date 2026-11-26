// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MathUnionShapeOutlined : GravityIcon
{
    public MathUnionShapeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MathUnionShapeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1, 13, 14.000001907348633);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0322578104676743, 0, 0, 1.0322578104676743, -0.25806248374139429, -0.25806248374139429);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3 2.75V8.5a5 5 0 1 0 10 0V2.75a.25.25 0 0 0-.25-.25h-1.5a.25.25 0 0 0-.25.25V8.5a3 3 0 1 1-6 0V2.75a.25.25 0 0 0-.25-.25h-1.5a.25.25 0 0 0-.25.25M1.5 8.5V2.75C1.5 1.783 2.284 1 3.25 1h1.5c.966 0 1.75.783 1.75 1.75V8.5a1.5 1.5 0 1 0 3 0V2.75c0-.967.784-1.75 1.75-1.75h1.5c.966 0 1.75.783 1.75 1.75V8.5a6.5 6.5 0 0 1-13 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
