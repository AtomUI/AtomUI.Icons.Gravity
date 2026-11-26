// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowUpRightOutlined : GravityIcon
{
    public ArrowUpRightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowUpRightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.5307207107543945, 2.5209999084472656, 10.94727897644043, 10.948771476745605);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1863954852918766, 0, 0, 1.1863954852918766, -1.4911638823350124, -1.4911638823350124);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M12.728 2.521a.75.75 0 0 1 .75.75v5.657a.751.751 0 0 1-1.5 0V5.083l-8.176 8.176a.75.75 0 0 1-1.061-1.06l8.176-8.177H7.07a.75.75 0 0 1 .001-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
