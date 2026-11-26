// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoMcpOutlined : GravityIcon
{
    public LogoMcpOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoMcpOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.2649790346622467, 0.30398112535476685, 14.659934043884277, 15.415136337280273);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96891468285495774, 0, 0, 0.96891468285495774, 0.24868253716033806, 0.24868253716033806);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M5.85 1.24a3.263 3.263 0 0 1 5.534 2.654 3.262 3.262 0 0 1 2.568 5.574L9.117 14.23l.208.212a.75.75 0 0 1-1.07 1.053l-.734-.746a.75.75 0 0 1 .01-1.061l5.37-5.288a1.762 1.762 0 0 0-2.473-2.51L7.445 8.825a.751.751 0 0 1-1.22-.823.8.8 0 0 1 .167-.246L9.376 4.82a1.763 1.763 0 0 0-2.473-2.512l-5.37 5.287A.75.75 0 0 1 .48 6.527z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M7.22 3.467a.751.751 0 0 1 1.052 1.07L5.6 7.167A1.743 1.743 0 0 0 8.045 9.65l2.673-2.63a.75.75 0 0 1 1.052 1.07l-2.672 2.63a3.243 3.243 0 0 1-4.55-4.622z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
