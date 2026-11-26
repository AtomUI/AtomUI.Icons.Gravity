// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AlarmOutlined : GravityIcon
{
    public AlarmOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 17, 17);
    }

    public override Icon CreateInstance()
    {
        return new AlarmOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 17, 17);
    internal override Rect GeneratedGeometryBounds => new Rect(0.28430318832397461, 0.23520633578300476, 16.45771598815918, 15.452132731676102);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.95523331193464645, 0, 0, 0.95523331193464645, 0.38051684855550505, 0.38051684855550505);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8.499 4.508c.44 0 .797.357.797.797v2.789l1.098.823a.797.797 0 1 1-.956 1.274L8.021 9.13a.8.8 0 0 1-.319-.637V5.305c0-.44.357-.797.797-.797"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.5 1.063a6.906 6.906 0 0 1 5.153 11.499l1.376 1.833a.797.797 0 0 1-1.274.957l-1.297-1.729a6.87 6.87 0 0 1-3.958 1.25 6.87 6.87 0 0 1-3.915-1.218l-1.313 1.719a.796.796 0 1 1-1.266-.967l1.376-1.803A6.906 6.906 0 0 1 8.5 1.063m0 1.593a5.312 5.312 0 1 0 0 10.624 5.312 5.312 0 0 0 0-10.624"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2.624.5A.797.797 0 1 1 3.75 1.625L1.626 3.75A.797.797 0 0 1 .499 2.624zm10.624 0a.797.797 0 0 1 1.126 0L16.5 2.623a.797.797 0 1 1-1.127 1.127l-2.124-2.125a.797.797 0 0 1 0-1.127"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
