// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class DatabaseOutlined : GravityIcon
{
    public DatabaseOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new DatabaseOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1, 12, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.615 4.888c.814-.375.885-.714.885-.888s-.071-.513-.885-.888S9.538 2.5 8 2.5s-2.799.237-3.615.612C3.57 3.487 3.5 3.826 3.5 4s.071.513.885.888S6.462 5.5 8 5.5s2.799-.237 3.615-.612m.885 1.235C11.4 6.708 9.792 7 8 7s-3.4-.292-4.5-.877V8c0 .174.071.513.885.888S6.462 9.5 8 9.5s2.799-.237 3.615-.612c.814-.375.885-.714.885-.888zm0 4C11.4 10.708 9.792 11 8 11s-3.4-.293-4.5-.877V12c0 .174.071.513.885.887.816.377 2.077.613 3.615.613s2.799-.236 3.615-.613c.814-.374.885-.713.885-.887zM14 4c0-2-2.686-3-6-3S2 2 2 4v8c0 2 2.686 3 6 3s6-1 6-3z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
