// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BackwardStepOutlined : GravityIcon
{
    public BackwardStepOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BackwardStepOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 2, 13, 12.000000953674316);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666667344835112, 0, 0, 1.0666667344835112, -0.53333387586808989, -0.53333387586808989);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2.25 2a.75.75 0 0 1 .75.75v10.5a.75.75 0 0 1-1.5 0V2.75A.75.75 0 0 1 2.25 2M13 3.896a.25.25 0 0 0-.384-.212l-6.48 4.105a.25.25 0 0 0 0 .422l6.48 4.106a.25.25 0 0 0 .384-.21zm1.5 8.21-.005.127c-.09 1.303-1.553 2.066-2.681 1.351L5.333 9.479a1.75 1.75 0 0 1 0-2.958l6.48-4.104.11-.064c1.112-.601 2.485.154 2.572 1.415l.005.128z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
