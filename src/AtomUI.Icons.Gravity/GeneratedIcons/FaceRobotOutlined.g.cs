// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FaceRobotOutlined : GravityIcon
{
    public FaceRobotOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FaceRobotOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.499998539686203, 0, 15.000003814697266, 14.50100040435791);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96975548977366599, 0, 0, 0.96975548977366599, 0.24195608181067207, 0.24195608181067207);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.75.75a.75.75 0 0 0-1.5 0V2H5a3 3 0 0 0-3 3A2.19 2.19 0 0 0 .5 7.081V9.42c0 .944.604 1.782 1.5 2.081a3 3 0 0 0 3 3h6a3 3 0 0 0 3-3 2.19 2.19 0 0 0 1.5-2.081V7.08c0-.943-.604-1.78-1.5-2.08a3 3 0 0 0-3-3H8.75zM3.5 10.419V11.5A1.5 1.5 0 0 0 5 13h6a1.5 1.5 0 0 0 1.5-1.5v-1.081l1.026-.342A.69.69 0 0 0 14 9.419V7.08a.69.69 0 0 0-.474-.658L12.5 6.081V5A1.5 1.5 0 0 0 11 3.5H5A1.5 1.5 0 0 0 3.5 5v1.081l-1.026.342A.69.69 0 0 0 2 7.081V9.42c0 .298.191.564.474.658zM9.75 8A.75.75 0 0 1 9 7.25v-1a.75.75 0 0 1 1.5 0v1a.75.75 0 0 1-.75.75m.75 2.25a.75.75 0 0 1-.75.75h-3.5a.75.75 0 0 1 0-1.5h3.5a.75.75 0 0 1 .75.75m-5-3a.75.75 0 0 0 1.5 0v-1a.75.75 0 0 0-1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
