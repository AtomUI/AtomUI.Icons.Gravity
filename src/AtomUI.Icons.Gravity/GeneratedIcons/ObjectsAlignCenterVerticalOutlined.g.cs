// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectsAlignCenterVerticalOutlined : GravityIcon
{
    public ObjectsAlignCenterVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectsAlignCenterVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 1.5, 14, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258048638097, 0, 0, 1.032258048638097, -0.25806438910477603, -0.25806438910477603);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.5 3H4a.5.5 0 0 0-.5.5v9a.5.5 0 0 0 .5.5h1.5a.5.5 0 0 0 .5-.5v-9a.5.5 0 0 0-.5-.5m2 4.25V3.5a2 2 0 0 0-2-2H4a2 2 0 0 0-2 2v3.75h-.25a.75.75 0 0 0 0 1.5H2v3.75a2 2 0 0 0 2 2h1.5a2 2 0 0 0 2-2V8.75h1V10a2 2 0 0 0 2 2H12a2 2 0 0 0 2-2V8.75h.25a.75.75 0 0 0 0-1.5H14V6a2 2 0 0 0-2-2h-1.5a2 2 0 0 0-2 2v1.25zM10 8v2a.5.5 0 0 0 .5.5H12a.5.5 0 0 0 .5-.5V6a.5.5 0 0 0-.5-.5h-1.5a.5.5 0 0 0-.5.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
