// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChartLinePointsOutlined : GravityIcon
{
    public ChartLinePointsOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChartLinePointsOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.4996827244758606, 2.7632770538330078, 15.488053321838379, 11.236722946166992);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.8901017963562361, 0, 0, 0.8901017963562361, 0.87918562915011123, 0.87918562915011123);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M14.75 12.5a.75.75 0 0 1 0 1.5H1.25a.75.75 0 0 1 0-1.5zm-.05-9.511a.751.751 0 0 1 1.1 1.022l-3.027 3.258a2.25 2.25 0 1 1-4.273.98l.001-.035-1.691-.846a2.24 2.24 0 0 1-2.831.238l-2.149 2.62a.75.75 0 0 1-1.16-.952L3.03 6.4l.051-.057A2.25 2.25 0 1 1 7.5 5.75q-.001.14-.02.276l1.55.775a2.245 2.245 0 0 1 2.674-.586zm-3.95 4.51a.75.75 0 1 0 0 1.501.75.75 0 0 0 0-1.5M5.25 5a.75.75 0 1 0 0 1.501.75.75 0 0 0 0-1.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
