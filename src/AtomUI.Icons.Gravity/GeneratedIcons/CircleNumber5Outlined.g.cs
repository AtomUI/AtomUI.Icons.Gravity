// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber5Outlined : GravityIcon
{
    public CircleNumber5Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber5Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 8a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0M15 8A7 7 0 1 1 1 8a7 7 0 0 1 14 0M6.861 4.75a.75.75 0 0 0-.736.606l-.461 2.35a.75.75 0 0 0 .64.888l.055.997h-.002.002a.75.75 0 0 0-.718 1.318L6 10.25l-.359.659h.002l.001.001.005.003.014.007a3 3 0 0 0 .188.091c.122.056.295.128.506.2a5.3 5.3 0 0 0 1.676.289c1.653 0 2.717-1.311 2.717-2.5 0-.726-.304-1.32-.805-1.714-.48-.378-1.09-.536-1.678-.536-.324 0-.629.03-.901.073l.112-.573H9.44a.75.75 0 1 0 0-1.5zM6.36 9.591l-.055-.997a.75.75 0 0 0 .384-.051l.018-.008.087-.03a4.6 4.6 0 0 1 1.475-.254c.337-.001.594.091.749.213.133.106.233.262.233.536 0 .37-.403 1-1.217 1-.45 0-.875-.102-1.194-.21a4 4 0 0 1-.461-.189zm-.055-.997-.179-3.238z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
