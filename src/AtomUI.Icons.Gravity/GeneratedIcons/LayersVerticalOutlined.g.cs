// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LayersVerticalOutlined : GravityIcon
{
    public LayersVerticalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LayersVerticalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4999996423721313, 1.0005648136138916, 13, 13.999436378479004);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0322578819187895, 0, 0, 1.0322578819187895, -0.25806305535031626, -0.25806305535031626);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m5.283 13.211-2.02-4.037A2.5 2.5 0 0 1 3 8.056v-.112c0-.388.09-.77.264-1.118L5.283 2.79a.523.523 0 0 1 .934 0l2.02 4.037A2.5 2.5 0 0 1 8.5 7.944v.112c0 .388-.09.77-.264 1.118L6.217 13.21a.523.523 0 0 1-.934 0M5.75 15a2.02 2.02 0 0 1-1.809-1.118L1.922 9.845a4 4 0 0 1-.422-1.79v-.11a4 4 0 0 1 .422-1.79l2.019-4.037a2.023 2.023 0 0 1 3.618 0l.44.882.442-.882a2.023 2.023 0 0 1 3.618 0l2.019 4.037a4 4 0 0 1 .422 1.79v.11a4 4 0 0 1-.422 1.79l-2.02 4.037a2.022 2.022 0 0 1-3.617 0L8 13l-.441.882A2.02 2.02 0 0 1 5.75 15m3.088-3.677.945 1.888a.523.523 0 0 0 .934 0l2.019-4.037A2.5 2.5 0 0 0 13 8.056v-.112a2.5 2.5 0 0 0-.264-1.118L10.717 2.79a.523.523 0 0 0-.934 0l-.945 1.888.74 1.478A4 4 0 0 1 10 7.945v.11a4 4 0 0 1-.422 1.79z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
