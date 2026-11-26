// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectsAlignCenterHorizontalOutlined : GravityIcon
{
    public ObjectsAlignCenterHorizontalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectsAlignCenterHorizontalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1.0000001192092896, 13, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258048638097, 0, 0, 1.032258048638097, -0.25806438910477603, -0.25806438910477603);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13 5.5V4a.5.5 0 0 0-.5-.5h-9A.5.5 0 0 0 3 4v1.5a.5.5 0 0 0 .5.5h9a.5.5 0 0 0 .5-.5m-4.25 2h3.75a2 2 0 0 0 2-2V4a2 2 0 0 0-2-2H8.75v-.25a.75.75 0 0 0-1.5 0V2H3.5a2 2 0 0 0-2 2v1.5a2 2 0 0 0 2 2h3.75v1H6a2 2 0 0 0-2 2V12a2 2 0 0 0 2 2h1.25v.25a.75.75 0 0 0 1.5 0V14H10a2 2 0 0 0 2-2v-1.5a2 2 0 0 0-2-2H8.75zM8 10H6a.5.5 0 0 0-.5.5V12a.5.5 0 0 0 .5.5h4a.5.5 0 0 0 .5-.5v-1.5a.5.5 0 0 0-.5-.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
