// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowUpLeftOutlined : GravityIcon
{
    public ArrowUpLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowUpLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.5220000743865967, 2.5199999809265137, 10.936286926269531, 10.940288543701172);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1885050717403616, 0, 0, 1.1885050717403616, -1.5080405739228926, -1.5080405739228926);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M3.27 2.521a.75.75 0 0 0-.748.75v5.657a.751.751 0 0 0 1.5 0V5.083l8.175 8.176a.75.75 0 0 0 1.06-1.06L5.083 4.02H8.93a.75.75 0 0 0-.001-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
