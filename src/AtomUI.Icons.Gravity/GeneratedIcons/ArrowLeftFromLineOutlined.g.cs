// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowLeftFromLineOutlined : GravityIcon
{
    public ArrowLeftFromLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowLeftFromLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0006600618362427, 1.0000001192092896, 13.999340057373047, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666581895616, 0, 0, 1.0666666581895616, -0.53333326551649307, -0.53333326551649307);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M1.22 8.53a.75.75 0 0 1 0-1.06l2.5-2.5a.75.75 0 0 1 1.06 1.06L3.56 7.25h7.69a.75.75 0 0 1 0 1.5H3.56l1.22 1.22a.75.75 0 1 1-1.06 1.06zm12.28 5.72a.75.75 0 0 0 1.5 0V1.75a.75.75 0 0 0-1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
