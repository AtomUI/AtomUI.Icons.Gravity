// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BranchesRightOutlined : GravityIcon
{
    public BranchesRightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BranchesRightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.000679612159729, 0.49900001287460327, 14.000700950622559, 15.001998901367188);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99996142238195918, 0, 0, 0.99996142238195918, 0.00030862094432659859, 0.00030862094432659859);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12 2.75a.75.75 0 1 0 1.5 0 .75.75 0 0 0-1.5 0m-1.372.75a2.251 2.251 0 1 0 0-1.5h-.378a3 3 0 0 0-3 3v2.25H5.372a2.25 2.25 0 1 0 0 1.5H7.25V11a3 3 0 0 0 3 3h.378a2.251 2.251 0 1 0 0-1.5h-.378a1.5 1.5 0 0 1-1.5-1.5V8.75h1.878a2.251 2.251 0 1 0 0-1.5H8.75V5a1.5 1.5 0 0 1 1.5-1.5zM12 13.25a.75.75 0 1 0 1.5 0 .75.75 0 0 0-1.5 0m.75-4.5a.75.75 0 1 1 0-1.5.75.75 0 0 1 0 1.5M2.5 8A.75.75 0 1 0 4 8a.75.75 0 0 0-1.5 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
