// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeDownOutlined : GravityIcon
{
    public ArrowShapeDownOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeDownOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5009051561355591, 1, 12.998188972473145, 13.999512672424316);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0322626453487824, 0, 0, 1.0322626453487824, -0.25810116279025941, -0.25810116279025941);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6 7.5H3.33a.33.33 0 0 0-.252.542l4.42 5.225a.656.656 0 0 0 1.003 0l4.42-5.225a.33.33 0 0 0-.251-.542H10V3a.5.5 0 0 0-.5-.5h-3A.5.5 0 0 0 6 3zM4.5 3a2 2 0 0 1 2-2h3a2 2 0 0 1 2 2v3h1.17a1.83 1.83 0 0 1 1.397 3.011l-4.421 5.225a2.156 2.156 0 0 1-3.292 0L1.933 9.011A1.83 1.83 0 0 1 3.329 6H4.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
