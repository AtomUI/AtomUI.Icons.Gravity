// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AlarmFilled : GravityIcon
{
    public AlarmFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 17, 17);
    }

    public override Icon CreateInstance()
    {
        return new AlarmFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 17, 17);
    internal override Rect GeneratedGeometryBounds => new Rect(0.28430318832397461, 0.24717921018600464, 16.429876327514648, 15.439455091953278);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.95819320044442602, 0, 0, 0.95819320044442602, 0.3553577962223784, 0.3553577962223784);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.5 1.063a6.905 6.905 0 0 1 5.153 11.499l1.376 1.833a.797.797 0 0 1-1.274.957l-1.297-1.729a6.87 6.87 0 0 1-3.958 1.25 6.87 6.87 0 0 1-3.915-1.218l-1.313 1.719a.796.796 0 1 1-1.265-.967l1.375-1.803A6.906 6.906 0 0 1 8.5 1.063m0 3.445a.797.797 0 0 0-.798.797v3.187c0 .25.119.487.319.637l1.417 1.062a.797.797 0 1 0 .956-1.274l-1.098-.823v-2.79a.797.797 0 0 0-.797-.796"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2.624.5a.797.797 0 1 1 1.127 1.126L1.626 3.75A.797.797 0 0 1 .499 2.624zm10.624 0a.797.797 0 0 1 1.127 0l2.124 2.124a.797.797 0 0 1-1.126 1.127l-2.125-2.125a.797.797 0 0 1 0-1.127"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
