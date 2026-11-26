// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TrapezoidUpLineVerticalOutlined : GravityIcon
{
    public TrapezoidUpLineVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TrapezoidUpLineVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99917423725128174, 0, 14.001651763916016, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94122220297872627, 0, 0, 0.94122220297872627, 0.4702223761701898, 0.4702223761701898);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.75.75a.75.75 0 0 0-1.5 0V2H5.016a2.5 2.5 0 0 0-2.443 1.97l-1.517 7A2.5 2.5 0 0 0 3.5 14h3.75v1.25a.75.75 0 0 0 1.5 0V14h3.75a2.5 2.5 0 0 0 2.444-3.03l-1.517-7A2.5 2.5 0 0 0 10.984 2H8.75zM7.25 3.5H5.016a1 1 0 0 0-.977.788l-1.517 7A1 1 0 0 0 3.5 12.5h3.75zm1.5 9v-9h2.233a1 1 0 0 1 .978.788l1.516 7A1 1 0 0 1 12.5 12.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
