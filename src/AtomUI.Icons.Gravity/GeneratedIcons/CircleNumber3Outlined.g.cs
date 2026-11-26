// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber3Outlined : GravityIcon
{
    public CircleNumber3Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber3Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 8a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0M15 8A7 7 0 1 1 1 8a7 7 0 0 1 14 0M6.5 4.75a.75.75 0 0 0 0 1.5h1.467l-.809 1.04a.75.75 0 0 0 .715 1.2c.608-.102.952.023 1.123.148a.61.61 0 0 1 .254.512c0 .28-.261.85-1.25.85-.777 0-1.22-.533-1.288-.737a.75.75 0 1 0-1.424.474C5.554 10.533 6.554 11.5 8 11.5c1.701 0 2.75-1.13 2.75-2.35a2.11 2.11 0 0 0-.871-1.725 2.4 2.4 0 0 0-.665-.335l.878-1.13A.75.75 0 0 0 9.5 4.75z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
