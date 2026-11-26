// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ForwardStepOutlined : GravityIcon
{
    public ForwardStepOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ForwardStepOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 2, 13, 12.000000953674316);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666667344835112, 0, 0, 1.0666667344835112, -0.53333387586808989, -0.53333387586808989);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M13.75 2a.75.75 0 0 1 .75.75v10.5a.75.75 0 0 1-1.5 0V2.75a.75.75 0 0 1 .75-.75M1.505 3.632C1.597 2.32 3.079 1.56 4.206 2.295l6.498 4.24a1.75 1.75 0 0 1 0 2.93l-6.498 4.24-.11.066c-1.111.62-2.502-.134-2.591-1.404l-.005-.129V3.761zM3 12.238c0 .199.22.319.387.21L9.884 8.21a.25.25 0 0 0 0-.419L3.387 3.552A.25.25 0 0 0 3 3.76z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
