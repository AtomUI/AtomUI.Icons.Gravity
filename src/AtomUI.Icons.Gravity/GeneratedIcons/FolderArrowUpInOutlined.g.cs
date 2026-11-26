// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FolderArrowUpInOutlined : GravityIcon
{
    public FolderArrowUpInOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FolderArrowUpInOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 1, 15, 15);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96969696969696972, 0, 0, 0.96969696969696972, 0.24242424242424221, 0.24242424242424221);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m6.44 3.56.439.44H12.5A1.5 1.5 0 0 1 14 5.5v5a1.5 1.5 0 0 1-1.5 1.5h-1.75a.75.75 0 0 0 0 1.5h1.75a3 3 0 0 0 3-3v-5a3 3 0 0 0-3-3h-5l-.621-.621A3 3 0 0 0 4.757 1H3.5a3 3 0 0 0-3 3v6.5a3 3 0 0 0 3 3h1.75a.75.75 0 0 0 0-1.5H3.5A1.5 1.5 0 0 1 2 10.5V4a1.5 1.5 0 0 1 1.5-1.5h1.257a1.5 1.5 0 0 1 1.061.44zm2.31 5 .72.72a.75.75 0 1 0 1.06-1.06l-2-2a.75.75 0 0 0-1.06 0l-2 2a.75.75 0 0 0 1.06 1.06l.72-.72v6.69a.75.75 0 0 0 1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
