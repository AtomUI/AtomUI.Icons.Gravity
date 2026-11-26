// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FactoryOutlined : GravityIcon
{
    public FactoryOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FactoryOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 13.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258064516129, 0, 0, 1.032258064516129, -0.25806451612903203, -0.25806451612903203);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.5 5.5v2.803l2.332-1.555L13.5 5.636V12.5a.5.5 0 0 1-.5.5H3a.5.5 0 0 1-.5-.5V3a.5.5 0 0 1 .5-.5h1.5A.5.5 0 0 1 5 3v5.446l2.382-1.733L9.5 5.173zM6.5 3v2.5L8 4.41l.903-.657A1.32 1.32 0 0 1 11 4.82v.68l1.02-.68.463-.309.429-.285A1.343 1.343 0 0 1 15 5.343V12.5a2 2 0 0 1-2 2H3a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1.5a2 2 0 0 1 2 2m-1.75 7a.75.75 0 0 0 0 1.5h6.5a.75.75 0 0 0 0-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
