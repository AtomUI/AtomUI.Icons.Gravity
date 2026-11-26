// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HandPointLeftOutlined : GravityIcon
{
    public HandPointLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HandPointLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(-0.0008269793470390141, 1.4999576807022095, 16.001792907714844, 13.251526832580566);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.92751217875358904, 0, 0, 0.92751217875358904, 0.57990256997128764, 0.57990256997128764);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m13.5 6-2.906-3.737a1.978 1.978 0 0 0-3.48 1.694L7.375 5H1.942a1.942 1.942 0 0 0-.421 3.838L4.5 9.5l.457 2.744A3 3 0 0 0 8.69 14.65L13 13.5zm-5.197 7.2 3.272-.872.39-5.858L9.41 3.184a.478.478 0 0 0-.84.41l.26 1.042.466 1.864H1.942a.442.442 0 0 0-.096.874l2.98.662.987.22.167.997.457 2.744A1.5 1.5 0 0 0 8.303 13.2m7.195.103a.75.75 0 0 1-1.496-.106l.5-7a.75.75 0 1 1 1.496.106z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
