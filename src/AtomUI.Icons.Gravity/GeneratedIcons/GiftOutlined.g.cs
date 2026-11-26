// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class GiftOutlined : GravityIcon
{
    public GiftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new GiftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 0.32268229126930237, 14, 14.67731761932373);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666603088379, 0, 0, 1.0666666603088379, -0.53333328247070355, -0.53333328247070355);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m9.035 3.863.182-1.276a.92.92 0 0 1 .818-.783.914.914 0 0 1 .272 1.805zM7.25 5.5v2H3a.5.5 0 0 1-.5-.5V6a.5.5 0 0 1 .5-.5zM8 1.564A2.415 2.415 0 1 0 3.83 4H3a2 2 0 0 0-2 2v1a2 2 0 0 0 1 1.732V12a3 3 0 0 0 3 3h6a3 3 0 0 0 3-3V8.732A2 2 0 0 0 15 7V6a2 2 0 0 0-2-2h-.83A2.415 2.415 0 1 0 8 1.565m.75 4.186V7.5H13a.5.5 0 0 0 .5-.5V6a.5.5 0 0 0-.5-.5H8.75zM7.25 9H3.5v3A1.5 1.5 0 0 0 5 13.5h2.25zm1.5 4.5V9h3.75v3a1.5 1.5 0 0 1-1.5 1.5zM6.783 2.587l.182 1.276-1.272-.254a.914.914 0 0 1 .272-1.805.92.92 0 0 1 .818.783"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
