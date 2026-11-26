// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayersOutlined : GravityIcon
{
    public LayersOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayersOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99999940395355225, 1.4999996423721313, 13.999436378479004, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0323331968941396, 0, 0, 1.0323331968941396, -0.25866557515311683, -0.25866557515311683);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m2.789 5.283 4.037-2.02A2.5 2.5 0 0 1 7.944 3h.112c.388 0 .77.09 1.118.264l4.037 2.019a.522.522 0 0 1 0 .934l-4.037 2.02a2.5 2.5 0 0 1-1.118.263h-.112a2.5 2.5 0 0 1-1.118-.264L2.79 6.217a.523.523 0 0 1 0-.934M1 5.75c0-.766.433-1.466 1.118-1.809l4.037-2.019a4 4 0 0 1 1.79-.422h.11a4 4 0 0 1 1.79.422l4.037 2.019a2.023 2.023 0 0 1 0 3.618l-.882.44.882.442a2.023 2.023 0 0 1 0 3.618l-4.037 2.019a4 4 0 0 1-1.79.422h-.11a4 4 0 0 1-1.79-.422l-4.037-2.02a2.023 2.023 0 0 1 0-3.617L3 8l-.882-.441A2.02 2.02 0 0 1 1 5.75m3.677 3.088-1.888.945a.523.523 0 0 0 0 .934l4.037 2.019A2.5 2.5 0 0 0 7.944 13h.112a2.5 2.5 0 0 0 1.118-.264l4.037-2.019a.523.523 0 0 0 0-.934l-1.888-.945-1.478.74a4 4 0 0 1-1.79.422h-.11a4 4 0 0 1-1.79-.422z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
