// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TriangleThunderboltOutlined : GravityIcon
{
    public TriangleThunderboltOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TriangleThunderboltOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.57938128709793091, 0.99424999952316284, 14.841238021850586, 13.505749702453613);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9791179287154409, 0, 0, 0.9791179287154409, 0.1670565702764728, 0.1670565702764728);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.134 2.994 2.217 11.5a1 1 0 0 0 .866 1.5h9.834a1 1 0 0 0 .866-1.5L8.866 2.993a1 1 0 0 0-1.732 0m3.03-.75c-.962-1.665-3.366-1.665-4.328 0L.919 10.749c-.964 1.666.239 3.751 2.164 3.751h9.834c1.925 0 3.128-2.085 2.164-3.751zM8.671 6.585a.75.75 0 0 0-1.342-.67l-1.25 2.5A.75.75 0 0 0 6.75 9.5h1.287l-.707 1.415a.75.75 0 1 0 1.342.67l1.25-2.5A.75.75 0 0 0 9.25 8H7.963z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
