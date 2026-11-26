// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChevronsCollapseVerticalFromLinesOutlined : GravityIcon
{
    public ChevronsCollapseVerticalFromLinesOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChevronsCollapseVerticalFromLinesOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 0, 12.000000953674316, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.88888893598391938, 0, 0, 0.88888893598391938, 0.88888851212864495, 0.88888851212864495);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2 15.25a.75.75 0 0 1 .75-.75h10.5a.75.75 0 0 1 0 1.5H2.75a.75.75 0 0 1-.75-.75M2 .75A.75.75 0 0 1 2.75 0h10.5a.75.75 0 0 1 0 1.5H2.75A.75.75 0 0 1 2 .75m2.97 11.78a.75.75 0 0 1 0-1.06l2.5-2.5a.75.75 0 0 1 1.06 0l2.5 2.5a.75.75 0 1 1-1.06 1.06L8 10.56l-1.97 1.97a.75.75 0 0 1-1.06 0m0-8a.75.75 0 1 1 1.06-1.06L8 5.44l1.97-1.97a.75.75 0 1 1 1.06 1.06l-2.5 2.5a.75.75 0 0 1-1.06 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
