// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowUpFromSquareSlashOutlined : GravityIcon
{
    public ArrowUpFromSquareSlashOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowUpFromSquareSlashOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99999994039535522, 1.0006601810455322, 14, 15.018051147460938);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.93910917549719974, 0, 0, 0.93910917549719974, 0.48712659602240205, 0.48712659602240205);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.47 1.22a.75.75 0 0 1 1.06 0l2.5 2.5a.75.75 0 1 1-1.06 1.06L8.75 3.56v3.738l-1.5-1.5V3.56L6.131 4.679l-1.06-1.06zm-.22 8.84v1.19a.75.75 0 0 0 1.453.263l1.986 1.987H4A1.5 1.5 0 0 1 2.5 12V9.5A1.5 1.5 0 0 1 4 8h1.19zM3.704 6.515 1.97 4.78a.75.75 0 0 1 1.06-1.06l11 11a.75.75 0 1 1-1.06 1.06l-.786-.785A3 3 0 0 1 12 15H4a3 3 0 0 1-3-3V9.5a3 3 0 0 1 2.704-2.986m9.795 5.533 1.22 1.22A3 3 0 0 0 15 12V9.5a3 3 0 0 0-3-3h-.25a.75.75 0 0 0 0 1.5H12a1.5 1.5 0 0 1 1.5 1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
