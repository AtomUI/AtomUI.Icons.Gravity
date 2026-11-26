// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FontCursorOutlined : GravityIcon
{
    public FontCursorOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FontCursorOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4959065914154053, 1.4999967813491821, 13.004093170166016, 13.250005722045898);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666662936741755, 0, 0, 1.0666662936741755, -0.53333034939340429, -0.53333034939340429);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10 2.25a.75.75 0 0 1 .75-.75c.576 0 1.102.217 1.5.573a2.24 2.24 0 0 1 1.5-.573.75.75 0 0 1 0 1.5.75.75 0 0 0-.75.75v8.75c0 .414.336.75.75.75a.75.75 0 0 1 0 1.5 2.24 2.24 0 0 1-1.5-.573 2.24 2.24 0 0 1-1.5.573.75.75 0 0 1 0-1.5.75.75 0 0 0 .75-.75V3.75a.75.75 0 0 0-.75-.75.75.75 0 0 1-.75-.75M5.75 3c-.618 0-1.168.39-1.374.972L1.543 12a.75.75 0 1 0 1.414.5L3.84 10h3.822l.882 2.5a.75.75 0 1 0 1.414-.5L7.124 3.972A1.46 1.46 0 0 0 5.75 3m1.381 5.5L5.75 4.587 4.369 8.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
