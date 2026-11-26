// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AlmostEqualOutlined : GravityIcon
{
    public AlmostEqualOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new AlmostEqualOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4989582300186157, 3.4090745449066162, 13.00111198425293, 9.1592464447021484);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9737205340808972, 0, 0, 0.9737205340808972, 0.21023572735282237, 0.21023572735282237);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M1.747 10.287c1.315-1.185 2.78-1.35 4.016-1.143 1.205.202 2.22.76 2.73 1.045.596.332 1.343.721 2.174.842.794.116 1.682-.01 2.608-.767a.75.75 0 0 1 .95 1.16c-1.286 1.052-2.61 1.261-3.774 1.092-1.127-.165-2.086-.68-2.689-1.017-.502-.28-1.32-.72-2.248-.875-.897-.15-1.865-.032-2.762.777a.75.75 0 0 1-1.005-1.114m0-5.66c1.315-1.184 2.78-1.349 4.016-1.142 1.205.202 2.22.76 2.73 1.045.596.332 1.343.72 2.174.842.794.116 1.682-.01 2.608-.768a.75.75 0 0 1 .95 1.161c-1.286 1.052-2.61 1.261-3.774 1.091-1.127-.164-2.086-.68-2.689-1.016-.502-.28-1.32-.72-2.248-.875-.897-.15-1.865-.032-2.762.777a.75.75 0 0 1-1.005-1.115"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
