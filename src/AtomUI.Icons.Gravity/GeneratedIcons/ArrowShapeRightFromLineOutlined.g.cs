// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeRightFromLineOutlined : GravityIcon
{
    public ArrowShapeRightFromLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeRightFromLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.0000001192092896, 13.999807357788086, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666529508870877, 0, 0, 1.0666529508870877, -0.53322360709670136, -0.53322360709670136);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9 9.5v2.471l4.276-3.499a.61.61 0 0 0 0-.944L9 4.029V6.5H5.75a.25.25 0 0 0-.25.25v2.5c0 .138.112.25.25.25zM4 6.75v2.501A1.75 1.75 0 0 0 5.75 11H7.5v1.026a1.474 1.474 0 0 0 2.407 1.14l4.319-3.533a2.11 2.11 0 0 0 0-3.266L9.907 2.833A1.474 1.474 0 0 0 7.5 3.973V5H5.75A1.75 1.75 0 0 0 4 6.75m-1.5 7.5a.75.75 0 0 1-1.5 0V1.75a.75.75 0 0 1 1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
