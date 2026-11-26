// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BroomMotionFilled : GravityIcon
{
    public BroomMotionFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BroomMotionFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 0.71860301494598389, 13.510066986083984, 14.370039939880371);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0549066431115592, 0, 0, 1.0549066431115592, -0.43925314489247391, -0.43925314489247391);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M10.537.745a.75.75 0 0 1 .921.527l1.295 4.739c1.43.496 2.454 1.895 2.225 3.513-.238 1.674-.607 2.955-.922 3.825-.157.434-.3.767-.407.995a7 7 0 0 1-.13.264l-.038.072-.013.02-.006.012a.75.75 0 0 1-.764.368l-1.086-.166a.5.5 0 0 1-.38-.56l.319-2.078a.34.34 0 0 0-.633-.212l-1.04 1.918a1 1 0 0 1-.978.516l-4.91-.752c-.866-.133-1.087-1.236-.43-1.73l.31-.24c.795-.642 2.067-1.843 2.912-3.488.773-1.504 2.401-2.868 4.332-2.587L10.01 1.666a.75.75 0 0 1 .526-.92M3.375 8a.75.75 0 1 1 0 1.5.75.75 0 0 1 0-1.5M2.25 5a.75.75 0 1 1 0 1.5.75.75 0 0 1 0-1.5m3.64-2a.75.75 0 1 1 0 1.5.75.75 0 0 1 0-1.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
