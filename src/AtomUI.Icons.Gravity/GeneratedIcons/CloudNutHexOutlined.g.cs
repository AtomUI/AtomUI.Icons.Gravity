// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CloudNutHexOutlined : GravityIcon
{
    public CloudNutHexOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CloudNutHexOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.0032373031135648489, 0.50124615430831909, 15.996762275695801, 14.498753547668457);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117650072570591, 0, 0, 0.94117650072570591, 0.47058799419435271, 0.47058799419435271);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.5 5.25a3.25 3.25 0 0 1 6.398-.811.75.75 0 0 0 .702.563 3 3 0 0 1 1.94.798c.591.549.96 1.33.96 2.2A.75.75 0 0 0 16 8a4.5 4.5 0 0 0-1.44-3.3 4.5 4.5 0 0 0-2.373-1.148 4.751 4.751 0 0 0-9.184 1.522A3.751 3.751 0 0 0 3.75 12.5h.5a.75.75 0 0 0 0-1.5h-.5a2.25 2.25 0 0 1-.002-4.5h.03a.75.75 0 0 0 .747-.843A3 3 0 0 1 4.5 5.25m7.123 8.25 1.406-2.5-1.406-2.5H8.877L7.471 11l1.406 2.5zm2.713-1.765a1.5 1.5 0 0 0 0-1.47l-1.406-2.5A1.5 1.5 0 0 0 11.623 7H8.877a1.5 1.5 0 0 0-1.307.765l-1.406 2.5a1.5 1.5 0 0 0 0 1.47l1.406 2.5A1.5 1.5 0 0 0 8.877 15h2.746a1.5 1.5 0 0 0 1.307-.765zM11.25 11a1 1 0 1 1-2 0 1 1 0 0 1 2 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
