// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BellFilled : GravityIcon
{
    public BellFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BellFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.499861478805542, 1, 13.000276565551758, 13.996452331542969);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0327400130495858, 0, 0, 1.0327400130495858, -0.26192010439668678, -0.26192010439668678);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M9.955 13.416a2 2 0 0 1-3.911 0c1.3.141 2.611.141 3.911 0M8 1a4.27 4.27 0 0 1 4.187 3.432l.619 3.096c.127.634.438 1.216.895 1.673l.436.436a1.24 1.24 0 0 1-.598 2.085l-1.462.338a18.1 18.1 0 0 1-8.154 0l-1.462-.338a1.24 1.24 0 0 1-.598-2.085L2.3 9.2a3.27 3.27 0 0 0 .895-1.673l.62-3.096A4.27 4.27 0 0 1 8 1"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
