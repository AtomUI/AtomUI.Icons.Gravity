// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AntennaSignalOutlined : GravityIcon
{
    public AntennaSignalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new AntennaSignalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.49999645352363586, 1.8669610023498535, 15.000012397766113, 13.134040832519531);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0000615120516176, 0, 0, 1.0000615120516176, -0.00049209641294112316, -0.00049209641294112316);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.56 4.403c.27.314.223.784-.015 1.123A3 3 0 0 0 5 7.25c0 .642.202 1.237.545 1.724.238.339.284.809.015 1.123-.27.315-.75.354-1.015.036A4.48 4.48 0 0 1 3.5 7.25c0-1.097.393-2.102 1.045-2.883.266-.318.745-.279 1.015.036m4.88 0c-.27.314-.223.784.015 1.123.344.487.545 1.082.545 1.724s-.201 1.237-.545 1.724c-.238.339-.284.809-.015 1.123.27.315.75.354 1.015.036A4.48 4.48 0 0 0 12.5 7.25a4.48 4.48 0 0 0-1.045-2.883c-.265-.318-.745-.279-1.015.036m1.953-2.278c-.27.315-.23.785.05 1.092A5.98 5.98 0 0 1 14 7.25c0 1.553-.59 2.968-1.558 4.033-.278.307-.319.777-.05 1.092.27.314.747.353 1.033.053A7.47 7.47 0 0 0 15.5 7.25c0-2.008-.79-3.832-2.075-5.178-.286-.3-.763-.261-1.032.053m-8.786 0c-.27-.314-.746-.353-1.032-.053A7.48 7.48 0 0 0 .5 7.25c0 2.008.79 3.832 2.075 5.178.286.3.763.261 1.032-.053.27-.315.23-.785-.05-1.092A5.98 5.98 0 0 1 2 7.25c0-1.553.59-2.968 1.558-4.033.278-.307.319-.777.05-1.092M8.75 8.55a1.5 1.5 0 1 0-1.5 0v5.701a.75.75 0 0 0 1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
