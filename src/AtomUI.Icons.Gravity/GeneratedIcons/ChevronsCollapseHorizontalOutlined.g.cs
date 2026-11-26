// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChevronsCollapseHorizontalOutlined : GravityIcon
{
    public ChevronsCollapseHorizontalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChevronsCollapseHorizontalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.84729033708572388, 3.3697135448455811, 14.282485008239746, 9.2829952239990234);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.90873764137018587, 0, 0, 0.90873764137018587, 0.73009886903851307, 0.73009886903851307);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.141 3.58a.75.75 0 0 0-1.06 1.061L4.439 8l-3.353 3.354a.75.75 0 1 0 1.06 1.06L6.03 8.53a.75.75 0 0 0 0-1.06zm11.718 8.84a.75.75 0 0 0 1.06-1.061L11.561 8l3.353-3.354a.75.75 0 0 0-1.06-1.06L9.97 7.47a.75.75 0 0 0 0 1.06z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
