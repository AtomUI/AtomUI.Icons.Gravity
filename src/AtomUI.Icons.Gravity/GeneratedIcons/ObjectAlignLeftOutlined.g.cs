// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectAlignLeftOutlined : GravityIcon
{
    public ObjectAlignLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectAlignLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1.0000001192092896, 12.5, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258048638097, 0, 0, 1.032258048638097, -0.25806438910477603, -0.25806438910477603);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2 14.25a.75.75 0 0 0 1.5 0V1.75a.75.75 0 0 0-1.5 0zM6.5 7v2a1 1 0 0 0 1 1H12a1 1 0 0 0 1-1V7a1 1 0 0 0-1-1H7.5a1 1 0 0 0-1 1m1-2.5A2.5 2.5 0 0 0 5 7v2a2.5 2.5 0 0 0 2.5 2.5H12A2.5 2.5 0 0 0 14.5 9V7A2.5 2.5 0 0 0 12 4.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
