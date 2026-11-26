// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowsExpandHorizontalOutlined : GravityIcon
{
    public ArrowsExpandHorizontalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowsExpandHorizontalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99986952543258667, 4.731290340423584, 13.999833106994629, 6.5374159812927246);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.85421265103732302, 0, 0, 0.85421265103732302, 1.1662987917014158, 1.1662987917014158);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M1.168 8.474A.75.75 0 0 1 1.22 7.47l2.5-2.5.056-.052a.75.75 0 0 1 1.056 1.056l-.052.056-1.22 1.22h8.88l-1.22-1.22a.75.75 0 1 1 1.06-1.06l2.5 2.5.094.114a.75.75 0 0 1-.094.946l-2.5 2.5-.056.052a.75.75 0 0 1-1.056-1.056l.052-.056 1.22-1.22H3.56l1.22 1.22a.75.75 0 1 1-1.06 1.06l-2.5-2.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
