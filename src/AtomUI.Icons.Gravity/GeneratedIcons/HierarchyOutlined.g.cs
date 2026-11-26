// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HierarchyOutlined : GravityIcon
{
    public HierarchyOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HierarchyOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1, 13, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.032258064516129, 0, 0, 1.032258064516129, -0.25806451612903203, -0.25806451612903203);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.25 2.5h-8.5a.75.75 0 0 0-.75.75v1.5c0 .414.336.75.75.75h8.5a.75.75 0 0 0 .75-.75v-1.5a.75.75 0 0 0-.75-.75m0 4.5H5v3.13c0 .69.56 1.25 1.25 1.25H7v-.13A2.25 2.25 0 0 1 9.25 9h3a2.25 2.25 0 0 1 2.25 2.25v1.5A2.25 2.25 0 0 1 12.25 15h-3a2.25 2.25 0 0 1-2.246-2.12H6.25a2.75 2.75 0 0 1-2.75-2.75V6.986a2.25 2.25 0 0 1-2-2.236v-1.5A2.25 2.25 0 0 1 3.75 1h8.5a2.25 2.25 0 0 1 2.25 2.25v1.5A2.25 2.25 0 0 1 12.25 7m-3 3.5h3a.75.75 0 0 1 .75.75v1.5a.75.75 0 0 1-.75.75h-3a.75.75 0 0 1-.75-.75v-1.5a.75.75 0 0 1 .75-.75"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
