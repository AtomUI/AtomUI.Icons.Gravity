// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoAppStoreOutlined : GravityIcon
{
    public LogoAppStoreOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoAppStoreOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99725830554962158, 1.4947273731231689, 14.006741762161255, 13.006690263748169);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0318198740112923, 0, 0, 1.0318198740112923, -0.25455899209033817, -0.25455899209033817);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M3.675 12.089a.5.5 0 0 1 .433.75l-.743 1.287a.75.75 0 0 1-1.299-.75l.599-1.037a.5.5 0 0 1 .433-.25zm5.191-5.986a.5.5 0 0 1 .866-.001l2.166 3.75h1.105l.919-.001h.332a.75.75 0 0 1 .75.75.75.75 0 0 1-.672.746l-.077.004h-1.492l1.17 2.025a.75.75 0 0 1-1.3.75L8.58 7.102a.5.5 0 0 1 0-.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8.707 1.875a.75.75 0 0 1 1.299.75l-1.14 1.974.001.003-.866 1.5-.002-.003L5.834 9.85H9.01a.5.5 0 0 1 .432.25l.29.5a.5.5 0 0 1-.432.75H1.746a.75.75 0 0 1 .002-1.5h2.354l3.032-5.252-1.14-1.974a.75.75 0 1 1 1.299-.75l.706 1.224z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
