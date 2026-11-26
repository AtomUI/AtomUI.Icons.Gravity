// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SlidersVerticalOutlined : GravityIcon
{
    public SlidersVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SlidersVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.9990469217300415, 0.99699997901916504, 11.999904632568359, 14.004001617431641);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99980930895730857, 0, 0, 0.99980930895730857, 0.0015255283415314125, 0.0015255283415314125);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10.999 8.499a1.5 1.5 0 1 0 0 3 1.5 1.5 0 0 0 0-3m-.75-1.406a3.001 3.001 0 0 0 0 5.811v1.347a.75.75 0 0 0 1.5 0v-1.347a3.001 3.001 0 0 0 0-5.811V1.748a.75.75 0 0 0-1.5 0zm-4.5 7.158V8.906a3.001 3.001 0 0 0 0-5.81V1.747a.75.75 0 1 0-1.5 0v1.347a3.001 3.001 0 0 0 0 5.811v5.345a.75.75 0 0 0 1.5 0M6.499 6a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
