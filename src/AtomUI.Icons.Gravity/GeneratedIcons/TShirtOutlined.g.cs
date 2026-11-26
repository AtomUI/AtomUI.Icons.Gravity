// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TShirtOutlined : GravityIcon
{
    public TShirtOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TShirtOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.2703719437122345, 1, 15.459255218505859, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.97209750117571503, 0, 0, 0.97209750117571503, 0.22321999059427977, 0.22321999059427977);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m15.177 3.089-3.544-1.772A3 3 0 0 0 10.292 1h-.877a1.5 1.5 0 0 1-2.83 0h-.877a3 3 0 0 0-1.341.317L.823 3.088a1 1 0 0 0-.481 1.266l1.295 3.237a1 1 0 0 0 1.28.565l.351-.132-.188 4.9A2 2 0 0 0 5.078 15h5.844a2 2 0 0 0 1.998-2.077l-.188-4.899.352.132a1 1 0 0 0 1.28-.565l1.294-3.237a1 1 0 0 0-.481-1.266M5.764 2.5h-.056a1.5 1.5 0 0 0-.67.158L1.904 4.224l.943 2.356 2.006-.752-.275 7.153a.5.5 0 0 0 .5.519h5.843a.5.5 0 0 0 .5-.52l-.276-7.152 2.006.752.943-2.356-3.132-1.566a1.5 1.5 0 0 0-.671-.158h-.056A3 3 0 0 1 8 3.5a3 3 0 0 1-2.236-1"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
