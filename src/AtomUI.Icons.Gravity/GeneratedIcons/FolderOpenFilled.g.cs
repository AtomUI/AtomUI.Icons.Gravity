// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FolderOpenFilled : GravityIcon
{
    public FolderOpenFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FolderOpenFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(-3.6664813407583097E-09, 1.5, 16.001123428344727, 12.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.88877794721340231, 0, 0, 0.88877794721340231, 0.88977642229278153, 0.88977642229278153);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M0 4.5a3 3 0 0 1 3-3h1.257a3 3 0 0 1 2.122.879L7 3h4a3 3 0 0 1 3 3H5.449a3 3 0 0 0-2.573 1.457L1.43 9.867a.75.75 0 0 0 1.287.772l1.446-2.41A1.5 1.5 0 0 1 5.45 7.5h9.376a1.175 1.175 0 0 1 1.008 1.779l-1.96 3.265A3 3 0 0 1 11.302 14H2.94q-.179 0-.35-.028A3 3 0 0 1 0 11z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
