// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ChartMixedOutlined : GravityIcon
{
    public ChartMixedOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ChartMixedOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 0.51153218746185303, 15, 14.488468170166016);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0000000223517422, 0, 0, 1.0000000223517422, -1.7881393787888555E-07, -1.7881393787888555E-07);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14.98 1.826a.75.75 0 0 0-.96-1.152L10.376 3.71a1.25 1.25 0 0 1-1.196.225l-2.155-.718a2.75 2.75 0 0 0-2.973.837L.926 7.767a.75.75 0 1 0 1.148.966l3.125-3.712a1.25 1.25 0 0 1 1.352-.38l2.155.718a2.75 2.75 0 0 0 2.63-.496zM13.5 8h-2a.5.5 0 0 0-.5.5V13a.5.5 0 0 0 .5.5h2a.5.5 0 0 0 .5-.5V8.5a.5.5 0 0 0-.5-.5m-4 5a.5.5 0 0 1-.5.5H7a.5.5 0 0 1-.5-.5v-2.5A.5.5 0 0 1 7 10h2a.5.5 0 0 1 .5.5zM5 13a.5.5 0 0 1-.5.5h-2A.5.5 0 0 1 2 13v-.5a.5.5 0 0 1 .5-.5h2a.5.5 0 0 1 .5.5zm-2.5 2h11a2 2 0 0 0 2-2V8.5a2 2 0 0 0-2-2h-2a2 2 0 0 0-2 2v.063A2 2 0 0 0 9 8.5H7a2 2 0 0 0-2 2v.063a2 2 0 0 0-.5-.063h-2a2 2 0 0 0-2 2v.5a2 2 0 0 0 2 2"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
