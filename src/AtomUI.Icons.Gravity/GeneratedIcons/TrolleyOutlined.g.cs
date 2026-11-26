// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TrolleyOutlined : GravityIcon
{
    public TrolleyOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TrolleyOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.50000005960464478, 0.5, 14.413732528686523, 14.999478340148926);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99470171559194909, 0, 0, 0.99470171559194909, 0.042386275264407303, 0.042386275264407303);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.988 11A1.5 1.5 0 1 0 7 11zM10 12.476v.024a3 3 0 1 1-4.473-2.614l-1.955-7.33A.75.75 0 0 0 2.848 2H1.25a.75.75 0 0 1 0-1.5h1.598a2.25 2.25 0 0 1 2.174 1.67l.542 2.035a2.3 2.3 0 0 1 .69-.317l4.602-1.231A2.25 2.25 0 0 1 13.61 4.25l1.228 4.607a2.25 2.25 0 0 1-1.595 2.753zm1.243-8.37a.75.75 0 0 1 .919.531l1.227 4.607a.75.75 0 0 1-.531.918l-3.244.865A3 3 0 0 0 7 9.5h-.024l-.865-3.245a.75.75 0 0 1 .53-.918l1.595-.427.642 2.291a.75.75 0 0 0 1.444-.403l-.637-2.275z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
