// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class VolumeOffFilled : GravityIcon
{
    public VolumeOffFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new VolumeOffFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 1.9996976852416992, 9.5, 12.000605583190918);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.86483651052832233, 0, 0, 0.86483651052832233, 1.0813079157734213, 1.0813079157734213);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.5 11h-3A1.5 1.5 0 0 1 0 9.5v-3A1.5 1.5 0 0 1 1.5 5h3l2.586-2.586a1.414 1.414 0 0 1 2.414 1v9.172a1.414 1.414 0 0 1-2.414 1z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
