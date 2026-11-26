// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeUpToLineOutlined : GravityIcon
{
    public ArrowShapeUpToLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeUpToLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666497124568, 0, 0, 1.0666666497124568, -0.5333331976996547, -0.5333331976996547);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.5 10h2.471L8.472 5.724a.61.61 0 0 0-.944 0L4.029 10H6.5v3.25c0 .138.112.25.25.25h2.5a.25.25 0 0 0 .25-.25zM8.002 2.5h6.248a.75.75 0 0 0 0-1.5H1.75a.75.75 0 0 0 0 1.5zm0 1.5a2.11 2.11 0 0 1 1.631.774l3.534 4.319a1.474 1.474 0 0 1-1.14 2.407H11v1.75A1.75 1.75 0 0 1 9.25 15h-2.5A1.75 1.75 0 0 1 5 13.25V11.5H3.974a1.474 1.474 0 0 1-1.14-2.407l3.533-4.319c.4-.49 1-.774 1.632-.774H8"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
