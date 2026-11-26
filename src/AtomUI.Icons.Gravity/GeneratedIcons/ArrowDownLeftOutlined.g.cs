// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowDownLeftOutlined : GravityIcon
{
    public ArrowDownLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowDownLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.5199999809265137, 2.5307009220123291, 10.94879150390625, 10.947299003601074);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1863092469059096, 0, 0, 1.1863092469059096, -1.4904739752472764, -1.4904739752472764);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M12.198 2.741a.75.75 0 0 1 1.06 1.061l-8.175 8.176h3.846a.75.75 0 0 1 0 1.5H3.27a.75.75 0 0 1-.75-.75V7.072a.751.751 0 0 1 1.501 0v3.846z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
