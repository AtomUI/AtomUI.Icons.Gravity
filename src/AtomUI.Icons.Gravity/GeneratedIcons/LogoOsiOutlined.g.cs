// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoOsiOutlined : GravityIcon
{
    public LogoOsiOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoOsiOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99999982118606567, 1.0014549493789673, 13.999999046325684, 13.46599006652832);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.030094684971421, 0, 0, 1.030094684971421, -0.24075747977136785, -0.24075747977136785);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 2.5a5.5 5.5 0 0 0-2.977 10.126l.79-2.571a3 3 0 1 1 4.372 0l.792 2.57A5.5 5.5 0 0 0 8 2.5M1 8a7 7 0 1 1 9.832 6.403.75.75 0 0 1-1.02-.465l-1.2-3.901a.75.75 0 0 1 .273-.826 1.5 1.5 0 1 0-1.77 0 .75.75 0 0 1 .274.826l-1.2 3.901a.75.75 0 0 1-1.021.465A7 7 0 0 1 1 8"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
