// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class NutHexOutlined : GravityIcon
{
    public NutHexOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new NutHexOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.56005072593688965, 1.2879999876022339, 14.880898475646973, 13.423999786376953);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.98949290696962988, 0, 0, 0.98949290696962988, 0.084056744242960946, 0.084056744242960946);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m13.874 8.25-2.72 4.712a.5.5 0 0 1-.434.25H5.28a.5.5 0 0 1-.433-.25L2.127 8.25a.5.5 0 0 1 0-.5l2.72-4.712a.5.5 0 0 1 .433-.25h5.44a.5.5 0 0 1 .433.25l2.72 4.712a.5.5 0 0 1 0 .5m1.3-1.25a2 2 0 0 1 0 2l-2.72 4.712a2 2 0 0 1-1.733 1H5.28a2 2 0 0 1-1.732-1L.828 9a2 2 0 0 1 0-2l2.72-4.712a2 2 0 0 1 1.732-1h5.44a2 2 0 0 1 1.732 1zM9.5 8a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0M11 8a3 3 0 1 1-6 0 3 3 0 0 1 6 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
