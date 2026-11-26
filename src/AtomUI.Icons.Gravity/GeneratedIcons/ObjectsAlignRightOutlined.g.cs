// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectsAlignRightOutlined : GravityIcon
{
    public ObjectsAlignRightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectsAlignRightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1.0000001192092896, 12.5, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99999998509883903, 0, 0, 0.99999998509883903, 1.1920928777442441E-07, 1.1920928777442441E-07);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14 1.75a.75.75 0 0 0-1.5 0v12.5a.75.75 0 0 0 1.5 0zM9.5 5.5V4a.5.5 0 0 0-.5-.5H3.5A.5.5 0 0 0 3 4v1.5a.5.5 0 0 0 .5.5H9a.5.5 0 0 0 .5-.5M11 4a2 2 0 0 0-2-2H3.5a2 2 0 0 0-2 2v1.5a2 2 0 0 0 2 2H9a2 2 0 0 0 2-2zm-1.5 8v-1.5A.5.5 0 0 0 9 10H7a.5.5 0 0 0-.5.5V12a.5.5 0 0 0 .5.5h2a.5.5 0 0 0 .5-.5m1.5-1.5a2 2 0 0 0-2-2H7a2 2 0 0 0-2 2V12a2 2 0 0 0 2 2h2a2 2 0 0 0 2-2z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
