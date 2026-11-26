// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ToggleOffOutlined : GravityIcon
{
    public ToggleOffOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ToggleOffOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 2.5, 16, 11);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.86486486486486491, 0, 0, 0.86486486486486491, 1.0810810810810807, 1.0810810810810807);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.5 12a4 4 0 1 1 0-8 4 4 0 0 1 0 8m3.775 0A5.5 5.5 0 0 0 11 8a5.5 5.5 0 0 0-1.725-4H10.5a4 4 0 0 1 0 8zM0 8a5.5 5.5 0 0 1 5.5-5.5h5a5.5 5.5 0 1 1 0 11h-5A5.5 5.5 0 0 1 0 8"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
