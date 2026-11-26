// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LocationArrowFilled : GravityIcon
{
    public LocationArrowFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LocationArrowFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99908161163330078, 1.0014760494232178, 13.999441146850586, 13.999442100524902);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0664310890948576, 0, 0, 1.0664310890948576, -0.53144871275886096, -0.53144871275886096);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 m10.924 13.894 3.95-10.316a1.9 1.9 0 0 0-2.452-2.452L2.106 5.076a1.722 1.722 0 0 0 .163 3.27L6.5 9.5l1.154 4.231a1.722 1.722 0 0 0 3.27.163"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
