// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowsExpandOutlined : GravityIcon
{
    public ArrowsExpandOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowsExpandOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99986952543258667, 0.9998699426651001, 14.000260353088379, 14.000259399414062);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666573927943888, 0, 0, 1.0666573927943888, -0.53325914235511007, -0.53325914235511007);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M7.526 1.168a.75.75 0 0 1 1.004.052l1.75 1.75.052.056a.75.75 0 0 1-1.056 1.056L9.22 4.03l-.47-.47v3.69h3.69l-.47-.47a.75.75 0 0 1 1.06-1.06l1.75 1.75.052.056a.75.75 0 0 1-.052 1.004l-1.75 1.75-.056.052a.75.75 0 0 1-1.056-1.056l.052-.056.47-.47H8.75v3.69l.47-.47a.75.75 0 1 1 1.06 1.06l-1.75 1.75-.056.052a.75.75 0 0 1-1.004-.052l-1.75-1.75-.052-.056a.75.75 0 0 1 1.056-1.056l.056.052.47.47V8.75H3.56l.47.47a.75.75 0 1 1-1.06 1.06L1.22 8.53l-.052-.056A.75.75 0 0 1 1.22 7.47l1.75-1.75.056-.052a.75.75 0 0 1 1.056 1.056l-.052.056-.47.47h3.69V3.56l-.47.47a.75.75 0 1 1-1.06-1.06l1.75-1.75z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
