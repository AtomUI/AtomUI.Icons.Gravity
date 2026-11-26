// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LocationArrowOutlined : GravityIcon
{
    public LocationArrowOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LocationArrowOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99849420785903931, 1.0007833242416382, 14.001461029052734, 13.998858451843262);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666475596141864, 0, 0, 1.0666475596141864, -0.53318047691349157, -0.53318047691349157);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.16 13.134 6.5 9.5l-3.634-.66a2.272 2.272 0 0 1-.355-4.377l9.358-3.327a2.346 2.346 0 0 1 2.996 2.995l-3.328 9.358a2.272 2.272 0 0 1-4.376-.355m2.964-.148L13.45 3.63a.844.844 0 0 0-1.08-1.08L3.014 5.876a.772.772 0 0 0 .12 1.487l3.634.661 1.022.186.186 1.022.66 3.634a.772.772 0 0 0 1.488.12"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
