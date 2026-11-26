// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HourglassStartOutlined : GravityIcon
{
    public HourglassStartOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HourglassStartOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1, 12.001001358032227, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0000625887941261, 0, 0, 1.0000625887941261, -0.00050071035300902622, -0.00050071035300902622);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.25 1a.75.75 0 0 1 0 1.5h-.5v1.822a3.75 3.75 0 0 1-1.386 2.91L10.42 8l.945.768a3.75 3.75 0 0 1 1.386 2.91v1.821h.5a.75.75 0 0 1 0 1.5h-1.23L12 15H4l-.02-.001H2.754a.75.75 0 0 1 0-1.5h.496v-1.821c0-1.13.51-2.198 1.386-2.91L5.579 8l-.943-.768a3.75 3.75 0 0 1-1.386-2.91V2.5h-.5a.75.75 0 0 1 0-1.5zM8.982 8.765a1.9 1.9 0 0 0-1.972.005L5.58 9.932a2.25 2.25 0 0 0-.831 1.746v1.821h6.5v-1.821a2.25 2.25 0 0 0-.831-1.746zM4.75 2.504v1.248h6.5V2.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
