// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ScalesBalancedOutlined : GravityIcon
{
    public ScalesBalancedOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ScalesBalancedOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.094366602599620819, 1.5, 15.809267044067383, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9244671460157371, 0, 0, 0.9244671460157371, 0.60426283187410323, 0.60426283187410323);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.25 3h-4.5v10h2.5a.75.75 0 0 1 0 1.5h-6.5a.75.75 0 0 1 0-1.5h2.5V3h-4.5a.75.75 0 0 1 0-1.5h10.5a.75.75 0 0 1 0 1.5M1.643 8.568l.007.018a1.454 1.454 0 0 0 2.7 0l.007-.018L3 5.854zM3 4c-.46 0-.88.26-1.085.67L.2 8.099a1 1 0 0 0-.034.819l.09.226a2.954 2.954 0 0 0 5.486 0l.09-.226a1 1 0 0 0-.034-.819L4.085 4.671A1.21 1.21 0 0 0 3 4m8.643 4.568.007.018a1.454 1.454 0 0 0 2.7 0l.007-.018L13 5.854zM13 4c-.46 0-.88.26-1.085.67L10.2 8.099a1 1 0 0 0-.034.819l.09.226a2.954 2.954 0 0 0 5.486 0l.09-.226a1 1 0 0 0-.034-.819l-1.714-3.427A1.21 1.21 0 0 0 13 4"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
