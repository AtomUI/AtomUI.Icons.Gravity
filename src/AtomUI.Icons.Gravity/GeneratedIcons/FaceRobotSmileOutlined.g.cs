// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FaceRobotSmileOutlined : GravityIcon
{
    public FaceRobotSmileOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FaceRobotSmileOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 0, 15.000001907348633, 14.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96969674550911977, 0, 0, 0.96969674550911977, 0.24242603592704182, 0.24242603592704182);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M9.238 9.451a.75.75 0 1 1 1.024 1.096 3.316 3.316 0 0 1-4.524.004.75.75 0 0 1 1.024-1.097 1.816 1.816 0 0 0 2.476-.003M6.25 5.5a.75.75 0 0 1 .75.75v1a.75.75 0 0 1-1.5 0v-1a.75.75 0 0 1 .75-.75m3.5 0a.75.75 0 0 1 .75.75v1a.75.75 0 0 1-1.5 0v-1a.75.75 0 0 1 .75-.75"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 0a.75.75 0 0 1 .75.75V2H11a3 3 0 0 1 3 3 2.19 2.19 0 0 1 1.5 2.081V9.42l-.007.176A2.19 2.19 0 0 1 14 11.5a3 3 0 0 1-3 3H5a3 3 0 0 1-3-3A2.19 2.19 0 0 1 .507 9.595L.5 9.419V7.081C.5 6.137 1.104 5.3 2 5a3 3 0 0 1 3-3h2.25V.75A.75.75 0 0 1 8 0M5 3.5A1.5 1.5 0 0 0 3.5 5v1.081l-1.025.342A.69.69 0 0 0 2 7.08v2.34c0 .299.191.564.475.658l1.025.342v1.08A1.5 1.5 0 0 0 5 13h6a1.5 1.5 0 0 0 1.5-1.5v-1.081l1.025-.342A.69.69 0 0 0 14 9.42V7.081a.69.69 0 0 0-.475-.658L12.5 6.08V5A1.5 1.5 0 0 0 11 3.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
