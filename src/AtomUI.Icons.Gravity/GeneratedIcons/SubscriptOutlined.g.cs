// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SubscriptOutlined : GravityIcon
{
    public SubscriptOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SubscriptOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.7500001192092896, 2, 12.720999717712402, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0708071442411213, 0, 0, 1.0708071442411213, -0.56645715392897067, -0.56645715392897067);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M12.445 8a1.92 1.92 0 0 1 1.155 3.452L12.207 12.5h1.514a.75.75 0 0 1 0 1.5h-2.2a1.27 1.27 0 0 1-1.264-1.141l-.007-.13.009-.149c.04-.342.219-.656.498-.867l1.94-1.46a.42.42 0 0 0-.252-.754h-.135a.58.58 0 0 0-.529.342l-.097.216a.75.75 0 0 1-1.368-.615l.098-.217A2.08 2.08 0 0 1 12.31 8zM9.611 2a.75.75 0 0 1 0 1.5H6.806v7.024h.587a.75.75 0 0 1 0 1.5H4.726a.75.75 0 0 1 0-1.5h.58V3.5H2.5a.75.75 0 0 1 0-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
