// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BellDotOutlined : GravityIcon
{
    public BellDotOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BellDotOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5009709596633911, 0.99906975030899048, 12.99985408782959, 14.004070281982422);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0318949029464197, 0, 0, 1.0318949029464197, -0.25515922357135778, -0.25515922357135778);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 2.5a2.77 2.77 0 0 0-2.716 2.226l-.619 3.096a4.77 4.77 0 0 1-1.305 2.44l-.194.193a.566.566 0 0 0 .273.953l.821.19a16.6 16.6 0 0 0 7.48 0l.82-.19a.567.567 0 0 0 .274-.953l-.194-.193a4.77 4.77 0 0 1-1.305-2.44l-.068-.337a.75.75 0 0 1 1.471-.295l.068.338c.126.634.438 1.216.895 1.673l.194.194a2.066 2.066 0 0 1-.997 3.475l-.821.19q-1.053.24-2.12.358a2 2 0 0 1-3.913 0 18 18 0 0 1-2.12-.359l-.822-.19a2.067 2.067 0 0 1-.997-3.474L2.3 9.2c.457-.457.769-1.04.895-1.673l.62-3.096a4.27 4.27 0 0 1 5.4-3.256.75.75 0 1 1-.427 1.438A2.8 2.8 0 0 0 8 2.5"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.5 5.5a2 2 0 1 0 0-4 2 2 0 0 0 0 4"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
