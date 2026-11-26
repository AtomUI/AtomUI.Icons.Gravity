// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectsAlignJustifyHorizontalOutlined : GravityIcon
{
    public ObjectsAlignJustifyHorizontalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectsAlignJustifyHorizontalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14.25 1a.75.75 0 0 1 .75.75v12.5a.75.75 0 0 1-1.5 0V1.75a.75.75 0 0 1 .75-.75M11 4v1.5a.5.5 0 0 1-.5.5h-5a.5.5 0 0 1-.5-.5V4a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 .5.5m-.5-2a2 2 0 0 1 2 2v1.5a2 2 0 0 1-2 2h-5a2 2 0 0 1-2-2V4a2 2 0 0 1 2-2zm.5 8.5V12a.5.5 0 0 1-.5.5h-5A.5.5 0 0 1 5 12v-1.5a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 .5.5m-.5-2a2 2 0 0 1 2 2V12a2 2 0 0 1-2 2h-5a2 2 0 0 1-2-2v-1.5a2 2 0 0 1 2-2zM1 1.75a.75.75 0 0 1 1.5 0v12.5a.75.75 0 0 1-1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
