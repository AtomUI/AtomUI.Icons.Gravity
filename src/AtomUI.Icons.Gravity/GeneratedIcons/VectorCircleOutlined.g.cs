// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class VectorCircleOutlined : GravityIcon
{
    public VectorCircleOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new VectorCircleOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(-0.010839387774467468, -0.010839387774467468, 16.010839462280273, 16.014657974243164);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99884654694584518, 0, 0, 0.99884654694584518, 0.009227624433238546, 0.009227624433238546);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 5.5a2.74 2.74 0 0 1-1.444-.409 2.76 2.76 0 0 1-.914-.925c-.6.37-1.106.877-1.476 1.476a2.75 2.75 0 0 1 0 4.716c.37.6.877 1.106 1.476 1.476a2.75 2.75 0 0 1 4.716 0c.6-.37 1.106-.876 1.476-1.476l-.028-.017a2.748 2.748 0 0 1 .028-4.699 4.5 4.5 0 0 0-1.476-1.476l-.017.028A2.75 2.75 0 0 1 8 5.5m2.749-2.835a2.75 2.75 0 0 0-5.498 0 6.03 6.03 0 0 0-2.586 2.586 2.75 2.75 0 0 0 0 5.498 6.03 6.03 0 0 0 2.586 2.586 2.749 2.749 0 0 0 5.09 1.359c.245-.398.393-.862.408-1.36a6.03 6.03 0 0 0 2.586-2.585A2.75 2.75 0 0 0 16 8a2.75 2.75 0 0 0-2.665-2.749 6.03 6.03 0 0 0-2.586-2.586M9.25 2.75a1.25 1.25 0 1 1-2.5 0 1.25 1.25 0 0 1 2.5 0M4 8a1.25 1.25 0 1 1-2.5 0A1.25 1.25 0 0 1 4 8m5.25 5.25a1.25 1.25 0 1 1-2.5 0 1.25 1.25 0 0 1 2.5 0m4-4a1.25 1.25 0 1 0 0-2.5 1.25 1.25 0 0 0 0 2.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
