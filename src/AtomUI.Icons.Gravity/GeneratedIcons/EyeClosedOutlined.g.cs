// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class EyeClosedOutlined : GravityIcon
{
    public EyeClosedOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new EyeClosedOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.14338678121566772, 5.318234920501709, 15.721376419067383, 8.3968009948730469);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.88817388497069405, 0, 0, 0.88817388497069405, 0.8946089202344476, 0.8946089202344476);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M14.505 5.631a.75.75 0 0 1 1.219.875A9.6 9.6 0 0 1 13.8 8.501l1.355 1.712c.263.332.195.774-.15.986-.344.213-.836.116-1.099-.216l-1.329-1.68a9.5 9.5 0 0 1-1.972.806l.62 2.704c.092.403-.16.8-.564.886a.765.765 0 0 1-.9-.576l-.624-2.72a9.6 9.6 0 0 1-2.275.003l-.62 2.717a.765.765 0 0 1-.901.576.736.736 0 0 1-.565-.886l.618-2.698a9.4 9.4 0 0 1-1.977-.805l-1.323 1.673c-.263.332-.755.429-1.1.216-.344-.212-.41-.654-.148-.986l1.348-1.704a9.5 9.5 0 0 1-1.91-1.982.75.75 0 0 1 1.219-.875c3.19 4.44 9.811 4.424 13.002-.021"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
