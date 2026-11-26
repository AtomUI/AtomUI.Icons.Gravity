// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AtOutlined : GravityIcon
{
    public AtOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new AtOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99984157085418701, 0.9055023193359375, 14.021369934082031, 14.095395088195801);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0637218871940854, 0, 0, 1.0637218871940854, -0.50977509755268358, -0.50977509755268358);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M1.18 6.423A7 7 0 1 1 14.808 9.62a2.499 2.499 0 0 1-4.403.92 3.5 3.5 0 1 1 1.005-1.753 1 1 0 0 0 1.949.452l.056-.277a5.5 5.5 0 1 0-2.938 3.949.75.75 0 0 1 .677 1.339A7 7 0 0 1 1.18 6.423m7.27-.371a2 2 0 1 0-.9 3.897 2 2 0 0 0 .9-3.897"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
