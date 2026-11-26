// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PulseOutlined : GravityIcon
{
    public PulseOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PulseOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 0.99986118078231812, 16, 14.000038146972656);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117089707134349, 0, 0, 0.94117089707134349, 0.47063282342925206, 0.47063282342925206);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.235 1a.75.75 0 0 1 .74.56l2.034 7.726 1.09-1.908A.75.75 0 0 1 13.75 7h1.5a.75.75 0 0 1 0 1.5h-1.065l-1.784 3.122a.75.75 0 0 1-1.376-.181l-1.71-6.496-2.083 9.466a.75.75 0 0 1-1.446.07L3.544 7.55l-.65 1.085A.75.75 0 0 1 2.25 9H.75a.75.75 0 1 1 0-1.5h1.075l1.282-2.136a.75.75 0 0 1 1.357.155l1.898 5.868 2.156-9.798A.75.75 0 0 1 9.235 1"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
