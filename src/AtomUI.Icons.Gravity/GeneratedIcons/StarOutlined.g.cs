// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class StarOutlined : GravityIcon
{
    public StarOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new StarOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.35063719749450684, 0.019999995827674866, 15.29897403717041, 14.669187545776367);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96327310987723991, 0, 0, 0.96327310987723991, 0.29381512098208074, 0.29381512098208074);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m9.194 5 .351.873.94.064 3.197.217-2.46 2.055-.722.603.23.914.782 3.108-2.714-1.704L8 10.629l-.798.5-2.714 1.705.782-3.108.23-.914-.723-.603-2.46-2.055 3.198-.217.94-.064.35-.874L8 2.025zm-7.723-.292 3.943-.268L6.886.773C7.29-.231 8.71-.231 9.114.773l1.472 3.667 3.943.268c1.08.073 1.518 1.424.688 2.118L12.185 9.36l.964 3.832c.264 1.05-.886 1.884-1.802 1.31L8 12.4l-3.347 2.101c-.916.575-2.066-.26-1.802-1.309l.964-3.832L.783 6.826c-.83-.694-.391-2.045.688-2.118"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
