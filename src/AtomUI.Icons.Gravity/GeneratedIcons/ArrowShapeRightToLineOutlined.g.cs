// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeRightToLineOutlined : GravityIcon
{
    public ArrowShapeRightToLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeRightToLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.0000001192092896, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666497124568, 0, 0, 1.0666666497124568, -0.5333331976996547, -0.5333331976996547);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6 9.5v2.471l4.276-3.499a.61.61 0 0 0 0-.944L6 4.029V6.5H2.75a.25.25 0 0 0-.25.25v2.5c0 .138.112.25.25.25zm7.5-1.498v6.248a.75.75 0 0 0 1.5 0V1.75a.75.75 0 0 0-1.5 0zm-1.5 0a2.11 2.11 0 0 1-.774 1.631l-4.319 3.534a1.474 1.474 0 0 1-2.407-1.14V11H2.75A1.75 1.75 0 0 1 1 9.25v-2.5C1 5.784 1.784 5 2.75 5H4.5V3.974a1.474 1.474 0 0 1 2.407-1.14l4.319 3.533c.49.4.774 1 .774 1.632V8"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
