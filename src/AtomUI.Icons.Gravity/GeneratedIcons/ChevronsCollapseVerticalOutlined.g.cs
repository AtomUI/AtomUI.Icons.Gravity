// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChevronsCollapseVerticalOutlined : GravityIcon
{
    public ChevronsCollapseVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChevronsCollapseVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(3.3472929000854492, 0.84729266166687012, 9.3014097213745117, 14.283490180969238);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9084269798743807, 0, 0, 0.9084269798743807, 0.73258416100495438, 0.73258416100495438);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.42 2.141a.75.75 0 1 0-1.061-1.06L8 4.439 4.646 1.086a.75.75 0 1 0-1.06 1.06L7.47 6.03a.75.75 0 0 0 1.06 0zM3.58 13.86a.75.75 0 0 0 1.061 1.06L8 11.561l3.354 3.353a.75.75 0 0 0 1.06-1.06L8.53 9.97a.75.75 0 0 0-1.06 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
