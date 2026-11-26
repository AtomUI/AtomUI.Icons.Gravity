// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class XmarkShapeFilled : GravityIcon
{
    public XmarkShapeFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new XmarkShapeFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.550320029258728, 1.5503203868865967, 12.900360107421875, 12.899360656738281);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1071377758702108, 0, 0, 1.1071377758702108, -0.85710220696168626, -0.85710220696168626);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 12.243 6.232 14.01a1.5 1.5 0 0 1-2.121 0L1.99 11.89a1.5 1.5 0 0 1 0-2.122L3.757 8 1.99 6.232a1.5 1.5 0 0 1 0-2.121L4.11 1.99a1.5 1.5 0 0 1 2.122 0L8 3.757 9.768 1.99a1.5 1.5 0 0 1 2.121 0l2.122 2.12a1.5 1.5 0 0 1 0 2.122L12.243 8l1.767 1.768a1.5 1.5 0 0 1 0 2.121l-2.12 2.121a1.5 1.5 0 0 1-2.122 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
