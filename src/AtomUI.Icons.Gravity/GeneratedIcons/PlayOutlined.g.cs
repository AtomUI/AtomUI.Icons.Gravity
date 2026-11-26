// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PlayOutlined : GravityIcon
{
    public PlayOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PlayOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2.5, 0.52966570854187012, 13.112500190734863, 14.941522598266602);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0156271970347239, 0, 0, 1.0156271970347239, -0.12501757627779142, -0.12501757627779142);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M14.642 6.285c1.294.777 1.294 2.653 0 3.43L5.53 15.183c-1.292.775-2.924-.102-3.025-1.571l-.005-.144V2.532l.005-.143C2.605.919 4.238.043 5.53.818zm-.771 2.144a.5.5 0 0 0 0-.857L4.756 2.104A.5.5 0 0 0 4 2.532v10.936a.5.5 0 0 0 .757.429z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
