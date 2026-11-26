// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class WalletOutlined : GravityIcon
{
    public WalletOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new WalletOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99699997901916504, 1.5, 14.010000228881836, 12.99899959564209);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0312600163842653, 0, 0, 1.0312600163842653, -0.25008013107412275, -0.25008013107412275);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M10.753 8.005a.75.75 0 0 1 0 1.5h-1a.75.75 0 0 1 0-1.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.75 1.5a.75.75 0 0 1 0 1.5H3.195a.7.7 0 0 0-.698.7l.004.081a.8.8 0 0 0 .796.718h8.96a2.75 2.75 0 0 1 2.75 2.75v4.5a2.75 2.75 0 0 1-2.75 2.75h-8.51a2.75 2.75 0 0 1-2.75-2.75V3.7c0-1.215.984-2.2 2.198-2.2zM2.497 11.75c0 .69.56 1.25 1.25 1.25h8.51c.691 0 1.25-.56 1.25-1.25v-4.5c0-.69-.56-1.25-1.25-1.25h-8.96c-.281 0-.55-.054-.8-.146z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
