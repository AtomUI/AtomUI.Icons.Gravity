// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleTreeOutlined : GravityIcon
{
    public CircleTreeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleTreeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 0.5, 12.000276565551758, 15.000000953674316);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9143000640007255, 0, 0, 0.9143000640007255, 0.68559948799419601, 0.68559948799419601);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.327.504A.75.75 0 0 1 3 1.25V2a1.5 1.5 0 0 0 1.5 1.5h2.588A3.25 3.25 0 0 1 10.25 1l.167.004A3.25 3.25 0 0 1 13.5 4.25l-.004.167A3.25 3.25 0 0 1 10.25 7.5l-.167-.004A3.25 3.25 0 0 1 7.088 5H4.5c-.547 0-1.058-.15-1.5-.405V10a1.5 1.5 0 0 0 1.5 1.5h2.588a3.25 3.25 0 1 1 0 1.5H4.5a3 3 0 0 1-3-3V1.25A.75.75 0 0 1 2.25.5zM10.25 10.5a1.75 1.75 0 1 0 0 3.5 1.75 1.75 0 0 0 0-3.5m0-8a1.75 1.75 0 1 0 0 3.5 1.75 1.75 0 0 0 0-3.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
