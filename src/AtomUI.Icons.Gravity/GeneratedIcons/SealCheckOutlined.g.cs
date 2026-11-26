// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SealCheckOutlined : GravityIcon
{
    public SealCheckOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SealCheckOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.34242662787437439, 0.34242671728134155, 15.315147399902344, 15.315147399902344);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0218696580256481, 0, 0, 1.0218696580256481, -0.17495726420518487, -0.17495726420518487);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.515 3.5h.621l.44-.44 1.07-1.07a.5.5 0 0 1 .708 0l1.07 1.07.44.44H12a.5.5 0 0 1 .5.5v2.136l.44.44 1.07 1.07a.5.5 0 0 1 0 .708l-1.07 1.07-.44.44V12a.5.5 0 0 1-.5.5H9.864l-.44.44-1.07 1.07a.5.5 0 0 1-.708 0l-1.07-1.07-.44-.44H4a.5.5 0 0 1-.5-.5V9.864l-.44-.44-1.07-1.07a.5.5 0 0 1 0-.708l1.07-1.07.44-.44V4a.5.5 0 0 1 .5-.5zm3.9-2.571a2 2 0 0 0-2.83 0L5.516 2H4a2 2 0 0 0-2 2v1.515L.929 6.585a2 2 0 0 0 0 2.83L2 10.484V12a2 2 0 0 0 2 2h1.515l1.07 1.071a2 2 0 0 0 2.83 0L10.484 14H12a2 2 0 0 0 2-2v-1.515l1.071-1.07a2 2 0 0 0 0-2.83L14 5.516V4a2 2 0 0 0-2-2h-1.515zM11.1 6.45a.75.75 0 1 0-1.2-.9L7.419 8.858 6.03 7.47a.75.75 0 0 0-1.06 1.06l2 2a.75.75 0 0 0 1.13-.08z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
