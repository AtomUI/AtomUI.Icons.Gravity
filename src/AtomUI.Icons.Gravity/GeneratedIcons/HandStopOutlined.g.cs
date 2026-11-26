// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HandStopOutlined : GravityIcon
{
    public HandStopOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HandStopOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.9999660849571228, 0.0027916042599827051, 13.73491096496582, 15.462160110473633);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.98795763742684461, 0, 0, 0.98795763742684461, 0.096338900585243081, 0.096338900585243081);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.618 8.405 3.47 8.118a1.988 1.988 0 0 0-1.8 3.417l2.198 1.946a7.9 7.9 0 0 0 6.14 1.932A5.34 5.34 0 0 0 14.72 9.71l-.437-5.83a2.033 2.033 0 0 0-2.511-1.822l-.005-.113a2.02 2.02 0 0 0-3.866-.739A2.04 2.04 0 0 0 4.97 2.91zm1.673-2.64.126-1.968.045-.707.006-.084a.54.54 0 0 1 1.077-.015l.007.084.064.706.032.346.147 1.618.201 2.216L8 8h1l.004-.091.146-3.822.049-1.256.03-.792.002-.04A.52.52 0 0 1 10.268 2l.002.04.03.792.02.576.02.524.153 4.125.002.063.003.077.002.053h1l.002-.037.04-.762.139-2.64.039-.738.003-.068a.53.53 0 0 1 .533-.505c.278 0 .51.215.531.493l.005.068.055.737.198 2.636.18 2.388a3.84 3.84 0 0 1-3.389 4.1 6.4 6.4 0 0 1-4.974-1.565l-1.259-1.114L3.328 11l-.473-.42-.19-.168a.488.488 0 0 1 .442-.84l.246.062.613.154.357.089.198.05 1.479.37.098-1.523z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
