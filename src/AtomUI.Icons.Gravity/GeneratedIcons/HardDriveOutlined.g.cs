// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HardDriveOutlined : GravityIcon
{
    public HardDriveOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HardDriveOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.9999998807907104, 14, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9999999925494194, 0, 0, 0.9999999925494194, 5.9604644775390625E-08, 5.9604644775390625E-08);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12 8.5a1.5 1.5 0 0 1 1.5 1.5v1a1.5 1.5 0 0 1-1.5 1.5H4A1.5 1.5 0 0 1 2.5 11v-1A1.5 1.5 0 0 1 4 8.5zm.89-1.366L11.488 4.33a1.5 1.5 0 0 0-1.342-.829H5.854a1.5 1.5 0 0 0-1.342.83L3.11 7.133A3 3 0 0 1 4 7h8a3 3 0 0 1 .89.134M15 9.18V11a3 3 0 0 1-3 3H4a3 3 0 0 1-3-3V9.18a5 5 0 0 1 .528-2.236L3.17 3.658A3 3 0 0 1 5.854 2h4.292a3 3 0 0 1 2.683 1.658l1.643 3.286A5 5 0 0 1 15 9.18m-6 .57a.75.75 0 0 0 0 1.5h2.5a.75.75 0 0 0 0-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
