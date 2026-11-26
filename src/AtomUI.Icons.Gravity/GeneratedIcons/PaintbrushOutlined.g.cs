// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PaintbrushOutlined : GravityIcon
{
    public PaintbrushOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PaintbrushOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.48010346293449402, 0.274076908826828, 15.029397010803223, 15.208818435668945);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0298591171349512, 0, 0, 1.0298591171349512, -0.23887293707960922, -0.23887293707960922);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.135.693A1.003 1.003 0 0 1 9.567.486l.091.082 5.559 5.559c.39.39.39 1.025 0 1.416l-4.332 4.332a2.003 2.003 0 0 1-2.833 0l-.383-.383c-.11-.11-.295-.084-.391.038l-2.391 3.01a2.467 2.467 0 1 1-3.464-3.464l3.014-2.389c.122-.096.148-.28.038-.39l-.312-.311a2.004 2.004 0 0 1 .001-2.834L6.917 2.4a6 6 0 0 0 1.031-1.378l.123-.224zM5.227 6.215a.5.5 0 0 0-.001.708l.311.313c.86.86.525 2.08-.167 2.629l-3.013 2.389a.963.963 0 1 0 1.353 1.352l2.39-3.01h.002c.555-.698 1.776-1.02 2.63-.167l.382.383a.5.5 0 0 0 .708 0l.416-.416L5.64 5.8zm3.835-4.12c-.307.497-.67.956-1.082 1.368L6.703 4.738 11.3 9.335l2.502-2.5-.759-.76-1.067 1.082a.405.405 0 0 1-.68-.384l.493-1.951z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
