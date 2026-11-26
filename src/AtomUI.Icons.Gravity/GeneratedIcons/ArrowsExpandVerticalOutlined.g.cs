// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowsExpandVerticalOutlined : GravityIcon
{
    public ArrowsExpandVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowsExpandVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(4.731299877166748, 0.9998699426651001, 6.5374188423156738, 14.000259399414062);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.85417429801142541, 0, 0, 0.85417429801142541, 1.1666056159085967, 1.1666056159085967);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M7.526 1.168a.75.75 0 0 1 1.004.052l2.5 2.5.052.056a.75.75 0 0 1-1.056 1.056L9.97 4.78 8.75 3.56v8.88l1.22-1.22a.75.75 0 1 1 1.06 1.06l-2.5 2.5-.056.052a.75.75 0 0 1-1.004-.052l-2.5-2.5-.052-.056a.75.75 0 0 1 1.056-1.056l.056.052 1.22 1.22V3.56L6.03 4.78a.75.75 0 1 1-1.06-1.06l2.5-2.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
