// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class WeightHangingOutlined : GravityIcon
{
    public WeightHangingOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new WeightHangingOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.49992272257804871, 0.0011521696578711271, 14.999154090881348, 14.998847961425781);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0001154198305036, 0, 0, 1.0001154198305036, -0.00092335864402848244, -0.00092335864402848244);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.25 4.886A2.5 2.5 0 0 1 5.5 2.5a2.5 2.5 0 1 1 3.25 2.386V6h2.904a2.5 2.5 0 0 1 2.389 1.765l1.36 4.423A2.173 2.173 0 0 1 13.328 15H2.673a2.173 2.173 0 0 1-2.077-2.812l.252-.82 1.109-3.603A2.5 2.5 0 0 1 4.347 6H7.25zM9 2.5a1 1 0 1 1-2 0 1 1 0 0 1 2 0m-4.654 5a1 1 0 0 0-.955.706L2.03 12.629a.673.673 0 0 0 .643.871h10.654a.673.673 0 0 0 .643-.871l-1.36-4.423a1 1 0 0 0-.956-.706z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
