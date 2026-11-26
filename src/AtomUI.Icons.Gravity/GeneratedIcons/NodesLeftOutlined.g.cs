// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class NodesLeftOutlined : GravityIcon
{
    public NodesLeftOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new NodesLeftOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.999759316444397, 1.0032563209533691, 12.999996185302734, 13.996744155883789);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666492125930092, 0, 0, 1.0666492125930092, -0.53319370074407324, -0.53319370074407324);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5 2.5a1.5 1.5 0 1 1 0 3 1.5 1.5 0 0 1 0-3M2 4a3 3 0 1 1 5.895.79L9.85 5.908a3 3 0 1 1 0 4.185L7.895 11.21A3.003 3.003 0 0 1 5 15a3 3 0 1 1 2.15-5.092L9.105 8.79a3 3 0 0 1 0-1.58L7.15 6.092A3 3 0 0 1 2 4m3 6.5a1.5 1.5 0 1 1 0 3 1.5 1.5 0 0 1 0-3M13.5 8a1.5 1.5 0 1 0-3 0 1.5 1.5 0 0 0 3 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
