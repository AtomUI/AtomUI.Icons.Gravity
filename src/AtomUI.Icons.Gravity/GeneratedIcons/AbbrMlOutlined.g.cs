// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AbbrMlOutlined : GravityIcon
{
    public AbbrMlOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new AbbrMlOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99999856948852539, 3.9991469383239746, 14.500001907348633, 8.0008525848388672);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.84210519975572884, 0, 0, 0.84210519975572884, 1.2631584019541693, 1.2631584019541693);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.5 11.25V6.672l1.436 3.39a1.129 1.129 0 0 0 2.076.008l1.513-3.492v4.672a.75.75 0 0 0 1.5 0V5.218a1.218 1.218 0 0 0-2.335-.484L4.98 8.679 3.307 4.732A1.201 1.201 0 0 0 1 5.202v6.048a.75.75 0 1 0 1.5 0m9.5-6.5a.75.75 0 0 0-1.5 0v6.5c0 .414.336.75.75.75h3.5a.75.75 0 0 0 0-1.5H12z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
