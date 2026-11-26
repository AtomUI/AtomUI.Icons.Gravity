// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class WalletDotOutlined : GravityIcon
{
    public WalletDotOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new WalletDotOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99699997901916504, 1.5, 14.010000228881836, 13.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0656720099168406, 0, 0, 1.0656720099168406, -0.52537607933472508, -0.52537607933472508);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M13.004 11a2 2 0 1 1 0 4 2 2 0 0 1 0-4m-.254-9.5a.75.75 0 0 1 0 1.5H3.195a.7.7 0 0 0-.698.7l.004.081a.8.8 0 0 0 .796.718h8.96a2.75 2.75 0 0 1 2.75 2.75v2.023a.75.75 0 0 1-1.5 0V7.25c0-.69-.56-1.25-1.25-1.25h-8.96c-.281 0-.55-.054-.8-.146v5.896c0 .69.56 1.25 1.25 1.25h5.345a.75.75 0 0 1 0 1.5H3.747a2.75 2.75 0 0 1-2.75-2.75V3.7c0-1.215.984-2.2 2.198-2.2zm-1.997 6.505a.75.75 0 0 1 0 1.5h-1a.75.75 0 0 1 0-1.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.004 15a2 2 0 1 0 0-4 2 2 0 0 0 0 4"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
