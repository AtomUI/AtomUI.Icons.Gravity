// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoMarkdownOutlined : GravityIcon
{
    public LogoMarkdownOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoMarkdownOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 4, 14.018722534179688, 8);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.88704358845514175, 0, 0, 0.88704358845514175, 0.90365129235886599, 0.90365129235886599);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.443 4.699A1.294 1.294 0 0 0 1 5.294v5.956a.75.75 0 0 0 1.5 0V6.139l1.834 3.54a.75.75 0 0 0 1.332 0L7.5 6.138v5.111a.75.75 0 0 0 1.5 0V5.294A1.294 1.294 0 0 0 6.557 4.7L5 7.703zm9.807.051a.75.75 0 0 0-1.5 0v4.69l-.47-.47a.75.75 0 1 0-1.06 1.06l1.75 1.75a.75.75 0 0 0 1.06 0l1.75-1.75a.75.75 0 1 0-1.06-1.06l-.47.47z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
