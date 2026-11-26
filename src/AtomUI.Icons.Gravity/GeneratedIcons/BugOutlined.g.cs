// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BugOutlined : GravityIcon
{
    public BugOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BugOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.0062261610291898251, 0.0055616209283471107, 15.987927436828613, 16.013774871826172);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99722525888276226, 0, 0, 0.99722525888276226, 0.022197928937901956, 0.022197928937901956);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.865.031a.75.75 0 0 1 .918.53l.531 1.981a5.55 5.55 0 0 1 2.384.225 2.5 2.5 0 1 1 3.535 3.535 5.5 5.5 0 0 1 .225 2.384l1.98.53a.75.75 0 0 1-.388 1.45l-1.98-.531q-.271.64-.687 1.188l1.45 1.45a.75.75 0 0 1-1.06 1.06l-1.45-1.45a5.5 5.5 0 0 1-1.188.687l.53 1.98a.75.75 0 1 1-1.448.388l-.531-1.98a5.5 5.5 0 0 1-6.144-6.143l-1.98-.532A.75.75 0 0 1 .95 5.334l1.98.531q.27-.64.687-1.188l-1.45-1.45a.75.75 0 0 1 1.06-1.06l1.45 1.45a5.5 5.5 0 0 1 1.188-.687L5.335.95a.75.75 0 0 1 .53-.919M8 12a4 4 0 1 0-3.309-1.752L8.42 6.52a.75.75 0 0 1 1.06 1.06l-3.728 3.73c.64.435 1.414.69 2.248.69"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
