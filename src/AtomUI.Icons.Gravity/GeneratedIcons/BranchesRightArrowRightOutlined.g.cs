// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BranchesRightArrowRightOutlined : GravityIcon
{
    public BranchesRightArrowRightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BranchesRightArrowRightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 0.49999988079071045, 14.001734733581543, 15.000998497009277);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9999836313423659, 0, 0, 0.9999836313423659, 0.00013094926107282134, 0.00013094926107282134);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12 2.75a.75.75 0 1 0 1.5 0 .75.75 0 0 0-1.5 0M12.75.5A2.25 2.25 0 0 0 10.628 2h-.378a3 3 0 0 0-3 3v2.19L5.03 4.97a.75.75 0 0 0-1.06 1.06l1.22 1.22H1.75a.75.75 0 0 0 0 1.5h3.44L3.97 9.97a.75.75 0 1 0 1.06 1.06l2.22-2.22V11a3 3 0 0 0 3 3h.378a2.251 2.251 0 1 0 0-1.5h-.378a1.5 1.5 0 0 1-1.5-1.5V8.75h1.878a2.251 2.251 0 1 0 0-1.5H8.75V5a1.5 1.5 0 0 1 1.5-1.5h.378a2.251 2.251 0 1 0 2.122-3M12 13.25a.75.75 0 1 0 1.5 0 .75.75 0 0 0-1.5 0m.75-4.5a.75.75 0 1 1 0-1.5.75.75 0 0 1 0 1.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
