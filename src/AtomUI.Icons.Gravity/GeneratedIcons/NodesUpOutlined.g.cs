// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class NodesUpOutlined : GravityIcon
{
    public NodesUpOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new NodesUpOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0032563209533691, 1.9997591972351074, 13.996744155883789, 12.999996185302734);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666492041161817, 0, 0, 1.0666492041161817, -0.53319363292945354, -0.53319363292945354);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.5 5a1.5 1.5 0 1 0 3 0 1.5 1.5 0 0 0-3 0M4 2a3 3 0 1 0 .79 5.895L5.908 9.85a3 3 0 1 0 4.185 0l1.117-1.955A3.003 3.003 0 0 0 15 5a3 3 0 1 0-5.092 2.15L8.79 9.105a3 3 0 0 0-1.58 0L6.092 7.15A3 3 0 0 0 4 2m6.5 3a1.5 1.5 0 1 0 3 0 1.5 1.5 0 0 0-3 0M8 13.5a1.5 1.5 0 1 1 0-3 1.5 1.5 0 0 1 0 3"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
