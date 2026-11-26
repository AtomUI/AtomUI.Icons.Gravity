// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeLeftFromLineOutlined : GravityIcon
{
    public ArrowShapeLeftFromLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeLeftFromLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0001926422119141, 1.0000001192092896, 13.999807357788086, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666497124568, 0, 0, 1.0666666497124568, -0.5333331976996547, -0.5333331976996547);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7 6.5V4.029L2.724 7.528a.61.61 0 0 0 0 .944L7 11.971V9.5h3.25a.25.25 0 0 0 .25-.25v-2.5a.25.25 0 0 0-.25-.25zm5 2.75V6.749A1.75 1.75 0 0 0 10.25 5H8.5V3.974a1.474 1.474 0 0 0-2.407-1.14L1.774 6.366a2.11 2.11 0 0 0 0 3.266l4.319 3.534a1.474 1.474 0 0 0 2.407-1.14V11h1.75A1.75 1.75 0 0 0 12 9.25m1.5-7.5a.75.75 0 0 1 1.5 0v12.5a.75.75 0 0 1-1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
