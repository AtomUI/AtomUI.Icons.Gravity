// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class XmarkShapeOutlined : GravityIcon
{
    public XmarkShapeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new XmarkShapeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.6533734798431396, 1.6533733606338501, 12.693254470825195, 12.693251609802246);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.115244413623153, 0, 0, 1.115244413623153, -0.92195530898522371, -0.92195530898522371);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m8 10.121 2.652 2.652a.25.25 0 0 0 .353 0l1.768-1.768a.25.25 0 0 0 0-.353L10.121 8l2.652-2.652a.25.25 0 0 0 0-.353l-1.768-1.768a.25.25 0 0 0-.353 0L8 5.879 5.348 3.227a.25.25 0 0 0-.353 0L3.227 4.995a.25.25 0 0 0 0 .353L5.879 8l-2.652 2.652a.25.25 0 0 0 0 .353l1.768 1.768a.25.25 0 0 0 .353 0zm0 2.122 1.591 1.59a1.75 1.75 0 0 0 2.475 0l1.768-1.767a1.75 1.75 0 0 0 0-2.475L12.243 8l1.59-1.591a1.75 1.75 0 0 0 0-2.475l-1.767-1.768a1.75 1.75 0 0 0-2.475 0L8 3.757l-1.591-1.59a1.75 1.75 0 0 0-2.475 0L2.166 3.933a1.75 1.75 0 0 0 0 2.475L3.757 8l-1.59 1.591a1.75 1.75 0 0 0 0 2.475l1.767 1.768a1.75 1.75 0 0 0 2.475 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
