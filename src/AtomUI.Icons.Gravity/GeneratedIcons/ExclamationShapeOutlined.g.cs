// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ExclamationShapeOutlined : GravityIcon
{
    public ExclamationShapeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ExclamationShapeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(5.0898361206054688, -7.7283157651208967E-09, 5.8203277587890625, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.75865928593412757, 0, 0, 0.75865928593412757, 1.9307257125269794, 1.9307257125269794);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m9.41 1.762-.325 6.5a.25.25 0 0 1-.25.238h-1.67a.25.25 0 0 1-.25-.238l-.325-6.5a.25.25 0 0 1 .25-.262h2.32a.25.25 0 0 1 .25.262m1.173 6.575.325-6.5A1.75 1.75 0 0 0 9.16 0H6.84a1.75 1.75 0 0 0-1.748 1.837l.325 6.5A1.75 1.75 0 0 0 7.165 10h1.67a1.75 1.75 0 0 0 1.748-1.663M8 12.5a1 1 0 1 1 0 2 1 1 0 0 1 0-2m2.5 1a2.5 2.5 0 1 0-5 0 2.5 2.5 0 0 0 5 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
