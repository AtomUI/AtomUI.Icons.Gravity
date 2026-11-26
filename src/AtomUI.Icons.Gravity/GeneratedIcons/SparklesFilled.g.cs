// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SparklesFilled : GravityIcon
{
    public SparklesFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SparklesFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.0027449131011962891, -1.4258543501455279E-07, 15.99835205078125, 16.002973556518555);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99962845244566578, 0, 0, 0.99962845244566578, 0.0029723804346737381, 0.0029723804346737381);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M13 10a.75.75 0 0 1 .725.556 2.37 2.37 0 0 0 1.72 1.72.75.75 0 0 1 0 1.449 2.37 2.37 0 0 0-1.72 1.72.75.75 0 0 1-1.45 0 2.37 2.37 0 0 0-1.72-1.72.75.75 0 0 1 0-1.45 2.37 2.37 0 0 0 1.72-1.72l.043-.117A.75.75 0 0 1 13 10M7 0a1 1 0 0 1 .986.836c.279 1.67.815 2.8 1.596 3.582.781.781 1.912 1.317 3.582 1.596a1 1 0 0 1 0 1.972c-1.67.279-2.8.815-3.582 1.596-.781.781-1.317 1.912-1.596 3.582a1 1 0 0 1-1.972 0c-.279-1.67-.815-2.8-1.596-3.582-.781-.781-1.912-1.317-3.582-1.596a1 1 0 0 1 0-1.972c1.67-.279 2.8-.815 3.582-1.596.781-.781 1.317-1.912 1.596-3.582l.018-.089A1 1 0 0 1 7 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
