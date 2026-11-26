// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FileArrowRightOutOutlined : GravityIcon
{
    public FileArrowRightOutOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FileArrowRightOutOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.5, 15.000339508056641, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.91425024053457749, 0, 0, 0.91425024053457749, 0.68599807572338012, 0.68599807572338012);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.5 7.14a3 3 0 0 0-.758-1.992L8.395 2.507A3 3 0 0 0 6.153 1.5H4a3 3 0 0 0-3 3v7a3 3 0 0 0 3 3h6.25a.75.75 0 0 0 0-1.5H4a1.5 1.5 0 0 1-1.5-1.5v-7A1.5 1.5 0 0 1 4 3h1.5v2a3 3 0 0 0 3 3h2.25a.75.75 0 0 0 .75-.75zM9.856 6.5H8.5A1.5 1.5 0 0 1 7 5V3.262q.15.103.274.241L9.62 6.144a1.5 1.5 0 0 1 .235.356M13.44 11l-.72.72a.75.75 0 1 0 1.061 1.06l2-2a.75.75 0 0 0 0-1.06l-2-2a.75.75 0 1 0-1.06 1.06l.72.72H6.75a.75.75 0 0 0 0 1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
