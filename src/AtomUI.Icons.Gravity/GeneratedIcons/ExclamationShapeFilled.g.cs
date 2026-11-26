// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ExclamationShapeFilled : GravityIcon
{
    public ExclamationShapeFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ExclamationShapeFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(5.0771236419677734, 0, 5.8457517623901367, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.75911682959392679, 0, 0, 0.75911682959392679, 1.9270653632485857, 1.9270653632485857);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m10.921 1.575-.35 7A1.5 1.5 0 0 1 9.073 10H6.927a1.5 1.5 0 0 1-1.498-1.425l-.35-7A1.5 1.5 0 0 1 6.577 0h2.846a1.5 1.5 0 0 1 1.498 1.575M8 11a2.5 2.5 0 1 1 0 5 2.5 2.5 0 0 1 0-5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
