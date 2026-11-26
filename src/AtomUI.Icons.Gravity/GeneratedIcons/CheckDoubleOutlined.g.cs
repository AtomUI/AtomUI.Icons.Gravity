// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CheckDoubleOutlined : GravityIcon
{
    public CheckDoubleOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CheckDoubleOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.74973392486572266, 4.0047135353088379, 14.481561660766602, 7.9983477592468262);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.86676096882552478, 0, 0, 0.86676096882552478, 1.0659122493958018, 1.0659122493958018);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M13.97 5.223a.75.75 0 0 1 1.06 1.06l-5.5 5.5a.75.75 0 0 1-1.088-.028l-.5-.555a.75.75 0 0 1 1.084-1.034zm-4-1.008a.75.75 0 0 1 1.06 1.061l-5.5 5.5a.75.75 0 0 1-1.095-.036l-3.5-4a.75.75 0 0 1 1.13-.988l2.97 3.396z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
