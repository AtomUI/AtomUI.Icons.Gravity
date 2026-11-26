// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class EnvelopeOpenXmarkOutlined : GravityIcon
{
    public EnvelopeOpenXmarkOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new EnvelopeOpenXmarkOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 0.94808799028396606, 15, 13.551912307739258);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96969698721164987, 0, 0, 0.96969698721164987, 0.242424102306801, 0.242424102306801);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14 6.498V11.5a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 11.5V6.498c0-.54.29-1.038.76-1.305l4.5-2.55a1.5 1.5 0 0 1 1.48 0l4.5 2.55c.47.267.76.765.76 1.305m-13.5 0a3 3 0 0 1 1.521-2.61l4.5-2.55a3 3 0 0 1 2.958 0l4.5 2.55a3 3 0 0 1 1.521 2.61V11.5a3 3 0 0 1-3 3h-9a3 3 0 0 1-3-3zm6.03-.528a.75.75 0 0 0-1.06 1.06L6.94 8.5 5.47 9.97a.75.75 0 0 0 1.06 1.06L8 9.56l1.47 1.47a.75.75 0 1 0 1.06-1.06L9.06 8.5l1.47-1.47a.75.75 0 1 0-1.06-1.06L8 7.44z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
