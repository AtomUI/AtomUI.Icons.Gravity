// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AbbrQlOutlined : GravityIcon
{
    public AbbrQlOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new AbbrQlOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 4, 13.5, 9.5091400146484375);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.97023442162582296, 0, 0, 0.97023442162582296, 0.2381246269934163, 0.2381246269934163);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10.75 4a.75.75 0 0 1 .75.75v5.75h2.75a.75.75 0 0 1 0 1.5h-3.5a.75.75 0 0 1-.75-.75v-6.5a.75.75 0 0 1 .75-.75m-3.21 6.997c.611-.666.96-1.665.96-2.997 0-2.667-1.4-4-3.5-4S1.5 5.333 1.5 8s1.4 4 3.5 4q.674 0 1.24-.182l1.456 1.461a.75.75 0 1 0 1.063-1.058zM7 8c0 1.083-.282 1.675-.567 1.985-.27.294-.708.515-1.433.515s-1.163-.22-1.433-.515C3.282 9.675 3 9.083 3 8c0-1.082.282-1.675.567-1.985C3.837 5.72 4.275 5.5 5 5.5s1.163.22 1.433.515C6.718 6.325 7 6.918 7 8"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
