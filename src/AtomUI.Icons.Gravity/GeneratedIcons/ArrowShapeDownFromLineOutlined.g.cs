// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowShapeDownFromLineOutlined : GravityIcon
{
    public ArrowShapeDownFromLineOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowShapeDownFromLineOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 1, 14, 13.99980640411377);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666528830719957, 0, 0, 1.0666528830719957, -0.53322306457596547, -0.53322306457596547);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.5 9H4.029l3.499 4.276a.61.61 0 0 0 .944 0L11.971 9H9.5V5.75a.25.25 0 0 0-.25-.25h-2.5a.25.25 0 0 0-.25.25zm2.75-5H6.749A1.75 1.75 0 0 0 5 5.75V7.5H3.974a1.474 1.474 0 0 0-1.14 2.407l3.533 4.319a2.11 2.11 0 0 0 3.266 0l3.534-4.319a1.474 1.474 0 0 0-1.14-2.407H11V5.75A1.75 1.75 0 0 0 9.25 4m-7.5-1.5a.75.75 0 0 1 0-1.5h12.5a.75.75 0 0 1 0 1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
