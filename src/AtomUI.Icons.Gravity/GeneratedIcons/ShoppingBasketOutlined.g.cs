// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ShoppingBasketOutlined : GravityIcon
{
    public ShoppingBasketOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ShoppingBasketOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.49975445866584778, 1, 15.000491142272949, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94114927680636096, 0, 0, 0.94114927680636096, 0.47080578554911234, 0.47080578554911234);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12 4.5h1.307a2.193 2.193 0 0 1 2.109 2.795l-1.294 4.53A3 3 0 0 1 11.237 14H4.763a3 3 0 0 1-2.885-2.176L.584 7.295A2.193 2.193 0 0 1 2.693 4.5H4V3a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2zm-6.5 0V3a.5.5 0 0 1 .5-.5h4a.5.5 0 0 1 .5.5v1.5zm5.737 8H4.763a1.5 1.5 0 0 1-1.442-1.088L2.027 6.883A.693.693 0 0 1 2.693 6h10.614a.693.693 0 0 1 .666.883l-1.294 4.53a1.5 1.5 0 0 1-1.442 1.087m-4.59-1.265a.75.75 0 0 1-.882-.588l-.5-2.5a.75.75 0 0 1 1.47-.294l.5 2.5a.75.75 0 0 1-.588.882m4.088-3.088a.75.75 0 1 0-1.47-.294l-.5 2.5a.75.75 0 1 0 1.47.294z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
