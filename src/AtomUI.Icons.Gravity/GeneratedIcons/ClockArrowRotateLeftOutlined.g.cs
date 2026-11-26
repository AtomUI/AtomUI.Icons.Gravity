// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ClockArrowRotateLeftOutlined : GravityIcon
{
    public ClockArrowRotateLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ClockArrowRotateLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4999954700469971, 1.500552773475647, 13.000004768371582, 12.953185081481934);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0999388926151932, 0, 0, 1.0999388926151932, -0.7995111409215454, -0.7995111409215454);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M1.5 8a6.5 6.5 0 1 1 7.348 6.445.75.75 0 1 1-.194-1.487A5.001 5.001 0 1 0 4.5 11.57v-1.32a.75.75 0 0 1 1.5 0v3a.75.75 0 0 1-.75.75h-3a.75.75 0 0 1 0-1.5h1.06A6.48 6.48 0 0 1 1.5 8M8 4.25a.75.75 0 0 1 .75.75v2.625l1.033.775a.75.75 0 1 1-.9 1.2l-1.333-1a.75.75 0 0 1-.3-.6V5A.75.75 0 0 1 8 4.25"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
