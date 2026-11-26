// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PlusShapeOutlined : GravityIcon
{
    public PlusShapeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PlusShapeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.5 9.5h3.75a.25.25 0 0 0 .25-.25v-2.5a.25.25 0 0 0-.25-.25H9.5V2.75a.25.25 0 0 0-.25-.25h-2.5a.25.25 0 0 0-.25.25V6.5H2.75a.25.25 0 0 0-.25.25v2.5c0 .138.112.25.25.25H6.5v3.75c0 .138.112.25.25.25h2.5a.25.25 0 0 0 .25-.25zM5 5H2.75A1.75 1.75 0 0 0 1 6.75v2.5c0 .966.784 1.75 1.75 1.75H5v2.25c0 .966.784 1.75 1.75 1.75h2.5A1.75 1.75 0 0 0 11 13.25V11h2.25A1.75 1.75 0 0 0 15 9.25v-2.5A1.75 1.75 0 0 0 13.25 5H11V2.75A1.75 1.75 0 0 0 9.25 1h-2.5A1.75 1.75 0 0 0 5 2.75z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
