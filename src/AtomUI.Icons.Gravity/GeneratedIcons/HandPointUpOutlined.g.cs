// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HandPointUpOutlined : GravityIcon
{
    public HandPointUpOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HandPointUpOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4999576807022095, -0.00082704570377245545, 13.251527786254883, 16.001792907714844);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.92751223716586917, 0, 0, 0.92751223716586917, 0.57990210267304665, 0.57990210267304665);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m6 13.5-3.737-2.906a1.978 1.978 0 0 1 1.694-3.48L5 7.375V1.942a1.942 1.942 0 0 1 3.838-.421L9.5 4.5l2.744.457A3 3 0 0 1 14.65 8.69L13.5 13zm7.2-5.197-.872 3.272-5.858.39L3.184 9.41a.478.478 0 0 1 .41-.84l1.042.26 1.864.466V1.942a.442.442 0 0 1 .874-.096l.662 2.98.22.987.997.167 2.744.457A1.5 1.5 0 0 1 13.2 8.303m.103 7.195a.75.75 0 0 0-.106-1.496l-7 .5a.75.75 0 1 0 .106 1.496z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
