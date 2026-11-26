// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectsAlignLeftOutlined : GravityIcon
{
    public ObjectsAlignLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectsAlignLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1.0000001192092896, 12.5, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258048638097, 0, 0, 1.032258048638097, -0.25806438910477603, -0.25806438910477603);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2 1.75a.75.75 0 0 1 1.5 0v12.5a.75.75 0 0 1-1.5 0zM6.5 5.5V4a.5.5 0 0 1 .5-.5h5.5a.5.5 0 0 1 .5.5v1.5a.5.5 0 0 1-.5.5H7a.5.5 0 0 1-.5-.5M5 4a2 2 0 0 1 2-2h5.5a2 2 0 0 1 2 2v1.5a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2zm1.5 8v-1.5A.5.5 0 0 1 7 10h2a.5.5 0 0 1 .5.5V12a.5.5 0 0 1-.5.5H7a.5.5 0 0 1-.5-.5M5 10.5a2 2 0 0 1 2-2h2a2 2 0 0 1 2 2V12a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
