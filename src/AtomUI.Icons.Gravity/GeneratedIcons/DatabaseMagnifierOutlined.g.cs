// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class DatabaseMagnifierOutlined : GravityIcon
{
    public DatabaseMagnifierOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new DatabaseMagnifierOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 0.50199997425079346, 14.990776062011719, 14.987285494804382);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0327733414573594, 0, 0, 1.0327733414573594, -0.26218673165887552, -0.26218673165887552);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.25 8.249a3 3 0 0 1 3 3c0 .556-.154 1.075-.418 1.521l1.448 1.448a.75.75 0 0 1-1.06 1.061l-1.449-1.448a3 3 0 0 1-1.521.418 3 3 0 0 1 0-6m0 1.5a1.5 1.5 0 1 0 0 3 1.5 1.5 0 0 0 0-3"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.5.502c3.314 0 6 1 6 3v2.75a.75.75 0 0 1-1.5 0v-.63c-1.1.586-2.708.88-4.5.88s-3.4-.294-4.5-.88v1.63c0 .18.078.517.885.888.772.356 1.945.587 3.378.61a.75.75 0 0 1-.025 1.5c-1.55-.024-2.95-.273-3.98-.747A5 5 0 0 1 2 9.373v1.88c0 .18.078.516.885.887.772.356 1.945.587 3.378.61a.75.75 0 0 1-.025 1.5c-1.55-.024-2.95-.273-3.98-.747C1.166 13 .5 12.247.5 11.253v-8a.8.8 0 0 1 .059-.292q.014-.029.029-.055C1.072 1.303 3.534.502 6.5.502m0 1.5c-1.538 0-2.799.236-3.615.612-.814.375-.885.713-.885.888 0 .174.071.513.885.887.816.376 2.077.613 3.615.613s2.799-.237 3.615-.613c.814-.374.885-.713.885-.887s-.071-.513-.885-.888C9.3 2.238 8.038 2.002 6.5 2.002"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
