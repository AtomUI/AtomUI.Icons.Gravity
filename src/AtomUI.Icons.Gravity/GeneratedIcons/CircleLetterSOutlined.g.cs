// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleLetterSOutlined : GravityIcon
{
    public CircleLetterSOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleLetterSOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 8a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0M15 8A7 7 0 1 1 1 8a7 7 0 0 1 14 0M8.054 4.502c-.708 0-1.34.18-1.811.558a1.95 1.95 0 0 0-.74 1.545c0 .764.474 1.265.94 1.559.457.287 1.007.448 1.448.547.462.102.844.191 1.119.341.227.125.274.224.274.376 0 .102-.04.217-.248.341-.224.135-.577.229-.982.229-.344 0-.682-.114-.952-.29-.282-.184-.42-.388-.457-.506a.75.75 0 1 0-1.43.452c.17.543.59 1 1.067 1.31a3.27 3.27 0 0 0 1.772.534c.602 0 1.24-.134 1.754-.443.53-.319.976-.864.976-1.627 0-.864-.51-1.394-1.055-1.692-.478-.26-1.056-.389-1.46-.478l-.053-.012c-.386-.086-.736-.202-.973-.352-.227-.142-.24-.236-.24-.29a.45.45 0 0 1 .18-.375c.134-.108.403-.227.87-.227.47 0 .742.11.9.218a.83.83 0 0 1 .316.41.75.75 0 0 0 1.407-.52A2.33 2.33 0 0 0 9.8 4.98c-.455-.31-1.037-.478-1.745-.478"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
