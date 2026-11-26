// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeLeftToLineOutlined : GravityIcon
{
    public ArrowShapeLeftToLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeLeftToLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.0000001192092896, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666497124568, 0, 0, 1.0666666497124568, -0.5333331976996547, -0.5333331976996547);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10 6.5V4.029L5.724 7.528a.61.61 0 0 0 0 .944L10 11.971V9.5h3.25a.25.25 0 0 0 .25-.25v-2.5a.25.25 0 0 0-.25-.25zM2.5 7.998V1.75a.75.75 0 0 0-1.5 0v12.5a.75.75 0 0 0 1.5 0zm1.5 0c0-.632.284-1.23.774-1.631l4.319-3.534a1.474 1.474 0 0 1 2.407 1.14V5h1.75c.966 0 1.75.784 1.75 1.75v2.5A1.75 1.75 0 0 1 13.25 11H11.5v1.026a1.474 1.474 0 0 1-2.407 1.14L4.774 9.634c-.49-.4-.774-1-.774-1.632V8"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
