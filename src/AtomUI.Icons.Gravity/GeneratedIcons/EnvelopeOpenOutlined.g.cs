// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class EnvelopeOpenOutlined : GravityIcon
{
    public EnvelopeOpenOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new EnvelopeOpenOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 0.94708800315856934, 15, 13.552911758422852);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96969695568522607, 0, 0, 0.96969695568522607, 0.24242435451819144, 0.24242435451819144);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14 6.498V11.5a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 11.5V6.498l.001-.06L6.35 9.7a2.75 2.75 0 0 0 3.3 0l4.349-3.262zm-.806-1.33L8.74 2.642a1.5 1.5 0 0 0-1.48 0L2.806 5.167 7.25 8.5a1.25 1.25 0 0 0 1.5 0zM.5 6.497a3 3 0 0 1 1.521-2.61l4.5-2.55a3 3 0 0 1 2.958 0l4.5 2.55a3 3 0 0 1 1.521 2.61V11.5a3 3 0 0 1-3 3h-9a3 3 0 0 1-3-3z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
