// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ForwardStepFilled : GravityIcon
{
    public ForwardStepFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ForwardStepFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 2.0085544586181641, 13, 12.055446624755859);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0712373567588862, 0, 0, 1.0712373567588862, -0.56989885407108964, -0.56989885407108964);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M13.684 2.073a.75.75 0 0 1 .816.747v10.494a.75.75 0 0 1-1.5 0V2.82a.75.75 0 0 1 .684-.747M1.5 3.762c0-1.39 1.542-2.226 2.706-1.466l6.497 4.238a1.75 1.75 0 0 1 0 2.932l-6.497 4.239c-1.164.76-2.706-.076-2.706-1.466z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
