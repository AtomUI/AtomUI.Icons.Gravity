// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SquareHashtagOutlined : GravityIcon
{
    public SquareHashtagOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SquareHashtagOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1.5, 13, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.103448275862069, 0, 0, 1.103448275862069, -0.8275862068965516, -0.8275862068965516);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.5 3h-7A1.5 1.5 0 0 0 3 4.5v7A1.5 1.5 0 0 0 4.5 13h7a1.5 1.5 0 0 0 1.5-1.5v-7A1.5 1.5 0 0 0 11.5 3m-7-1.5a3 3 0 0 0-3 3v7a3 3 0 0 0 3 3h7a3 3 0 0 0 3-3v-7a3 3 0 0 0-3-3zm5.623 2.76a.75.75 0 0 1 .617.863l-.105.627h.865a.75.75 0 0 1 0 1.5h-1.115l-.25 1.5H11a.75.75 0 0 1 0 1.5H9.885l-.145.873a.75.75 0 1 1-1.48-.246l.105-.627h-1.48l-.145.873a.75.75 0 1 1-1.48-.246l.105-.627H4.5a.75.75 0 0 1 0-1.5h1.115l.25-1.5H5a.75.75 0 0 1 0-1.5h1.115l.145-.873a.75.75 0 1 1 1.48.246l-.105.627h1.48l.145-.873a.75.75 0 0 1 .863-.617M7.135 8.75h1.48l.25-1.5h-1.48z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
