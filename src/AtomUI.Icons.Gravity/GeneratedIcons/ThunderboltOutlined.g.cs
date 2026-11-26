// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ThunderboltOutlined : GravityIcon
{
    public ThunderboltOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ThunderboltOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.1934566497802734, 0.25123158097267151, 11.55931282043457, 15.497109413146973);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.90171770085921243, 0, 0, 0.90171770085921243, 0.78625839312630053, 0.78625839312630053);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.262.498a.75.75 0 0 1 1.275.717L9.229 5.622h3.272c1.104 0 1.665 1.328.897 2.12l-7.542 7.779a.75.75 0 0 1-1.248-.764l1.602-4.723H3.445c-1.083-.001-1.653-1.286-.926-2.09zM4.01 8.534h3.246a.75.75 0 0 1 .711.99l-.869 2.56 4.813-4.962H8.224a.75.75 0 0 1-.719-.963l.656-2.21z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
