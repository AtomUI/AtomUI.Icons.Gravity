// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HouseFilled : GravityIcon
{
    public HouseFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HouseFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4999998807907104, 1.2842044830322266, 13, 13.215795516967773);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1034482667902563, 0, 0, 1.1034482667902563, -0.82758613432205053, -0.82758613432205053);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M6.17 1.907a3 3 0 0 1 3.66 0l3.5 2.693a3 3 0 0 1 1.17 2.378V11.5a3 3 0 0 1-3 3h-7a3 3 0 0 1-3-3V6.978A3 3 0 0 1 2.67 4.6zM7 8c-.69 0-1.25.56-1.25 1.25V13h4.5V9.25C10.25 8.56 9.69 8 9 8z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
