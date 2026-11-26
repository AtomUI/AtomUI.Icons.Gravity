// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeLeftOutlined : GravityIcon
{
    public ArrowShapeLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99948674440383911, 1.5000600814819336, 14.000513076782227, 12.999879837036133);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0322540870843577, 0, 0, 1.0322540870843577, -0.25803269667486184, -0.25803269667486184);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.5 6V3.33a.33.33 0 0 0-.543-.252L2.732 7.499a.656.656 0 0 0 0 1.002l5.225 4.421a.33.33 0 0 0 .543-.252V10H13a.5.5 0 0 0 .5-.5v-3A.5.5 0 0 0 13 6zM13 4.5a2 2 0 0 1 2 2v3a2 2 0 0 1-2 2h-3v1.17a1.83 1.83 0 0 1-3.012 1.397L1.763 9.646a2.156 2.156 0 0 1 0-3.292l5.225-4.421A1.83 1.83 0 0 1 10 3.33V4.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
