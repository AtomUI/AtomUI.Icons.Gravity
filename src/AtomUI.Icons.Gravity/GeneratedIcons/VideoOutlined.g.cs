// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class VideoOutlined : GravityIcon
{
    public VideoOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new VideoOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 3, 16, 10);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.84210526315789469, 0, 0, 0.84210526315789469, 1.2631578947368425, 1.2631578947368425);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3 4.5h5.5A1.5 1.5 0 0 1 10 6v4a1.5 1.5 0 0 1-1.5 1.5H3A1.5 1.5 0 0 1 1.5 10V6A1.5 1.5 0 0 1 3 4.5m8.452 6.037A3 3 0 0 1 8.5 13H3a3 3 0 0 1-3-3V6a3 3 0 0 1 3-3h5.5a3 3 0 0 1 2.952 2.463l1.554-1.11A1.893 1.893 0 0 1 16 5.893v4.214a1.893 1.893 0 0 1-2.994 1.54zm.048-1.809 2.378 1.699a.393.393 0 0 0 .622-.32V5.893a.393.393 0 0 0-.622-.32L11.5 7.272z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
