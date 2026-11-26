// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleLetterQOutlined : GravityIcon
{
    public CircleLetterQOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleLetterQOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 8a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0M15 8A7 7 0 1 1 1 8a7 7 0 0 1 14 0M6.938 6.426c-.24.28-.438.771-.438 1.574s.197 1.294.438 1.574C7.165 9.838 7.504 10 8 10q.231 0 .419-.045l-.158-.136a.75.75 0 1 1 .976-1.138l.175.15C9.468 8.6 9.5 8.326 9.5 8c0-.802-.196-1.294-.436-1.573C8.838 6.162 8.5 6 8.001 6c-.497 0-.836.162-1.063.426M8 11.5c.61 0 1.185-.151 1.668-.475l.343.294a.75.75 0 1 0 .976-1.138l-.355-.305C10.883 9.34 11 8.704 11 8c0-1.028-.25-1.911-.797-2.55-.559-.652-1.345-.95-2.202-.95-.854 0-1.64.297-2.2.949C5.252 6.086 5 6.969 5 8c0 1.03.253 1.914.8 2.551.56.652 1.347.949 2.2.949"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
