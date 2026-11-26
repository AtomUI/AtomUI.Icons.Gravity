// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class Shapes4Outlined : GravityIcon
{
    public Shapes4Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new Shapes4Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.13005457818508148, 0.31309738755226135, 15.369285583496094, 14.937553405761719);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0160001268394152, 0, 0, 1.0160001268394152, -0.12800101471532166, -0.12800101471532166);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.193 6 4 2.075 1.807 6zM5.091.953a1.25 1.25 0 0 0-2.182 0L.289 5.64A1.25 1.25 0 0 0 1.38 7.5h5.24a1.25 1.25 0 0 0 1.09-1.86zM2.534 14.929a3.5 3.5 0 1 0 2.932-6.36 3.5 3.5 0 0 0-2.932 6.36M4 13.75a2 2 0 1 0 0-4 2 2 0 0 0 0 4M15.28 1.22a.75.75 0 0 1 0 1.06l-5 5a.75.75 0 1 1-1.06-1.06l5-5a.75.75 0 0 1 1.06 0m-5.03 12.03v-3.5h3.5v3.5zM8.75 9.5c0-.69.56-1.25 1.25-1.25h4c.69 0 1.25.56 1.25 1.25v4c0 .69-.56 1.25-1.25 1.25h-4c-.69 0-1.25-.56-1.25-1.25z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
