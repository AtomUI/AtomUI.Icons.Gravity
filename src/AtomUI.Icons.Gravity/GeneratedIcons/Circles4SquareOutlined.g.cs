// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class Circles4SquareOutlined : GravityIcon
{
    public Circles4SquareOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new Circles4SquareOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4993689060211182, 1.4999998807907104, 13.000000953674316, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1034003424857428, 0, 0, 1.1034003424857428, -0.82720273988594251, -0.82720273988594251);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.047 7.125A3 3 0 1 0 4.5 1.5a3 3 0 0 0-1.453 5.625M4.5 6a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3m5.547 1.125A3 3 0 1 0 11.5 1.5a3 3 0 0 0-1.453 5.625M11.5 6a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3m-7 8.5a3 3 0 1 1 0-6 3 3 0 0 1 0 6m1.5-3a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0m4.047 2.625A3 3 0 1 0 11.5 8.5a3 3 0 0 0-1.453 5.625M11.5 13a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
