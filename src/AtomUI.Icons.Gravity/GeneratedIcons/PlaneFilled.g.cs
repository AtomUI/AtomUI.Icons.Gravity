// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PlaneFilled : GravityIcon
{
    public PlaneFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PlaneFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.92148065567016602, 0.92165243625640869, 14.155385971069336, 14.156696319580078);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0610198563954643, 0, 0, 1.0610198563954643, -0.48815885116371405, -0.48815885116371405);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M10.985 1.814a4.27 4.27 0 0 1 3.505-.798l.09.026c.173.065.31.202.376.375l.026.09.043.231a4.24 4.24 0 0 1-.852 3.278l-1.695 2.157 1.24 3.845a2 2 0 0 1-.179 1.627l-.912 1.55a.7.7 0 0 1-1.194.022l-2.671-4.173-1.618 1.617.324 1.124a.9.9 0 0 1-.234.89l-1.273 1.259a.5.5 0 0 1-.759-.066l-.567-.798a11.5 11.5 0 0 0-2.708-2.706l-.794-.565a.5.5 0 0 1-.063-.764l1.276-1.26.093-.08a.9.9 0 0 1 .794-.143l1.097.323 1.617-1.618-4.163-2.688a.7.7 0 0 1 .035-1.197l1.59-.901a2 2 0 0 1 1.586-.167L8.805 3.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
