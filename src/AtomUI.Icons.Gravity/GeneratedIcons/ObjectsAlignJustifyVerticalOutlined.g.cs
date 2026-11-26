// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectsAlignJustifyVerticalOutlined : GravityIcon
{
    public ObjectsAlignJustifyVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectsAlignJustifyVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666497124568, 0, 0, 1.0666666497124568, -0.5333331976996547, -0.5333331976996547);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M15 14.25a.75.75 0 0 1-.75.75H1.75a.75.75 0 0 1 0-1.5h12.5a.75.75 0 0 1 .75.75M12 11h-1.5a.5.5 0 0 1-.5-.5v-5a.5.5 0 0 1 .5-.5H12a.5.5 0 0 1 .5.5v5a.5.5 0 0 1-.5.5m2-.5a2 2 0 0 1-2 2h-1.5a2 2 0 0 1-2-2v-5a2 2 0 0 1 2-2H12a2 2 0 0 1 2 2zm-8.5.5H4a.5.5 0 0 1-.5-.5v-5A.5.5 0 0 1 4 5h1.5a.5.5 0 0 1 .5.5v5a.5.5 0 0 1-.5.5m2-.5a2 2 0 0 1-2 2H4a2 2 0 0 1-2-2v-5a2 2 0 0 1 2-2h1.5a2 2 0 0 1 2 2zM14.25 1a.75.75 0 0 1 0 1.5H1.75a.75.75 0 0 1 0-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
