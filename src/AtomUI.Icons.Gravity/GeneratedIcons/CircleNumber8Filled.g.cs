// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber8Filled : GravityIcon
{
    public CircleNumber8Filled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber8Filled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8 8.3c.746 0 1.194.16 1.419.32.165.118.281.277.281.63s-.116.512-.281.63c-.225.16-.673.32-1.419.32s-1.194-.16-1.419-.32c-.165-.118-.281-.277-.281-.63s.116-.512.281-.63c.225-.16.673-.32 1.419-.32m0-3c.582 0 .891.133 1.024.234.083.063.176.163.176.466s-.093.403-.176.466C8.891 6.567 8.582 6.7 8 6.7s-.891-.133-1.024-.234C6.893 6.403 6.8 6.303 6.8 6s.093-.403.176-.466C7.109 5.433 7.418 5.3 8 5.3"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1a7 7 0 1 1 0 14A7 7 0 0 1 8 1m0 3c-1.5 0-2.5.667-2.5 2 0 .608.21 1.076.578 1.406C5.398 7.773 5 8.386 5 9.25c0 1.5 1.2 2.25 3 2.25s3-.75 3-2.25c0-.863-.398-1.477-1.08-1.844.37-.33.58-.798.58-1.406 0-1.333-1-2-2.5-2"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
