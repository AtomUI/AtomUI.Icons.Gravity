// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeUpFromLineOutlined : GravityIcon
{
    public ArrowShapeUpFromLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeUpFromLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 1.0001928806304932, 14, 13.999807357788086);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666412353523, 0, 0, 1.0666666412353523, -0.53333312988281811, -0.53333312988281811);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.5 7h2.471L8.472 2.724a.61.61 0 0 0-.944 0L4.029 7H6.5v3.25c0 .138.112.25.25.25h2.5a.25.25 0 0 0 .25-.25zm-2.75 5h2.501A1.75 1.75 0 0 0 11 10.25V8.5h1.026a1.474 1.474 0 0 0 1.14-2.407L9.634 1.774a2.11 2.11 0 0 0-3.266 0L2.833 6.093A1.474 1.474 0 0 0 3.973 8.5H5v1.75c0 .966.784 1.75 1.75 1.75m7.5 1.5a.75.75 0 0 1 0 1.5H1.75a.75.75 0 0 1 0-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
