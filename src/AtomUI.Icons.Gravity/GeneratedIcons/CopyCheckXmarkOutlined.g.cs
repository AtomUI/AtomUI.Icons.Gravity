// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CopyCheckXmarkOutlined : GravityIcon
{
    public CopyCheckXmarkOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CopyCheckXmarkOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4 6.5A1.5 1.5 0 0 0 2.5 8v4A1.5 1.5 0 0 0 4 13.5h4A1.5 1.5 0 0 0 9.5 12V8A1.5 1.5 0 0 0 8 6.5zm6-1.56.97-.97a.75.75 0 0 1 1.06 1.06l-.97.97.97.97A.75.75 0 0 1 11 8.059V9.5h1A1.5 1.5 0 0 0 13.5 8V4c0-.414-.168-.79-.44-1.06A1.5 1.5 0 0 0 12 2.5H8a1.495 1.495 0 0 0-1.415 1A1.5 1.5 0 0 0 6.5 4v1h1.441A.75.75 0 0 1 8 3.941a.75.75 0 0 1 1.03.028zM8 9.075l.085-.107Zm0 0-1.39 1.738-.002.001-.522.654a.75.75 0 0 1-1.116.061l-1-1a.75.75 0 0 1 1.06-1.06l.408.407 1.476-1.845L6.94 8a.75.75 0 0 1 1.144.97M15 8a3 3 0 0 1-3 3h-1v1a3 3 0 0 1-3 3H4a3 3 0 0 1-3-3V8a3 3 0 0 1 3-3h1V4a3 3 0 0 1 3-3h4a3 3 0 0 1 3 3z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
