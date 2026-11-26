// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ObjectsAlignBottomOutlined : GravityIcon
{
    public ObjectsAlignBottomOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ObjectsAlignBottomOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 1.5, 14, 12.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99999998509883903, 0, 0, 0.99999998509883903, 1.1920928777442441E-07, 1.1920928777442441E-07);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M1.75 14a.75.75 0 0 1 0-1.5h12.5a.75.75 0 0 1 0 1.5zM5.5 9.5H4a.5.5 0 0 1-.5-.5V3.5A.5.5 0 0 1 4 3h1.5a.5.5 0 0 1 .5.5V9a.5.5 0 0 1-.5.5M4 11a2 2 0 0 1-2-2V3.5a2 2 0 0 1 2-2h1.5a2 2 0 0 1 2 2V9a2 2 0 0 1-2 2zm8-1.5h-1.5A.5.5 0 0 1 10 9V7a.5.5 0 0 1 .5-.5H12a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-.5.5M10.5 11a2 2 0 0 1-2-2V7a2 2 0 0 1 2-2H12a2 2 0 0 1 2 2v2a2 2 0 0 1-2 2z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
