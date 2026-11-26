// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class RectanglePulseOutlined : GravityIcon
{
    public RectanglePulseOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new RectanglePulseOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 2, 15, 12);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94117647058823528, 0, 0, 0.94117647058823528, 0.47058823529411775, 0.47058823529411775);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.5 12.5h-9A1.5 1.5 0 0 1 2 11V9h3a.75.75 0 0 0 .648-.372l1.02-1.748 1.9 4.18a.75.75 0 0 0 1.33.068L11.43 8.5H14V11a1.5 1.5 0 0 1-1.5 1.5M14 7h-3a.75.75 0 0 0-.648.372L9.332 9.12l-1.9-4.18a.75.75 0 0 0-1.33-.068L4.57 7.5H2V5a1.5 1.5 0 0 1 1.5-1.5h9A1.5 1.5 0 0 1 14 5zM3.5 14h9a3 3 0 0 0 3-3V5a3 3 0 0 0-3-3h-9a3 3 0 0 0-3 3v6a3 3 0 0 0 3 3"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
