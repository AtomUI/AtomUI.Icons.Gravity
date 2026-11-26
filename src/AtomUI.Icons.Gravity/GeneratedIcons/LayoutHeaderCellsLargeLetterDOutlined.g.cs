// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayoutHeaderCellsLargeLetterDOutlined : GravityIcon
{
    public LayoutHeaderCellsLargeLetterDOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayoutHeaderCellsLargeLetterDOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 2, 14.670001983642578, 13.005000114440918);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.97949165755562972, 0, 0, 0.97949165755562972, 0.1640667395549622, 0.1640667395549622);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4 3.5h8A1.5 1.5 0 0 1 13.5 5v.5h-11V5A1.5 1.5 0 0 1 4 3.5m-1.5 7v.5A1.5 1.5 0 0 0 4 12.5h3.25v-2zm0-1.5h4.75V7H2.5zm6.25 1.5V14H4a3 3 0 0 1-3-3V5a3 3 0 0 1 3-3h8a3 3 0 0 1 3 3v2H8.75zm3.67-1.995a3.25 3.25 0 0 1 0 6.5h-1.17a.75.75 0 0 1-.75-.75v-5a.75.75 0 0 1 .75-.75zm0 5a1.75 1.75 0 1 0 0-3.5H12v3.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
