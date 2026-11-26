// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class GearDotOutlined : GravityIcon
{
    public GearDotOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new GearDotOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.87815213203430176, 0.5, 14.243695259094238, 14.99899959564209);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0078008954186963, 0, 0, 1.0078008954186963, -0.062407163349570638, -0.062407163349570638);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.199 2A.2.2 0 0 0 7 2.199c0 1.808-1.958 2.939-3.524 2.034a.2.2 0 0 0-.272.073l-.8 1.388a.2.2 0 0 0 .072.271c1.566.905 1.566 3.165 0 4.07a.2.2 0 0 0-.073.271l.801 1.388a.2.2 0 0 0 .272.073C5.042 10.862 7 11.993 7 13.8c0 .11.089.199.199.199H8.8c.11 0 .199-.089.199-.199 0-1.808 1.958-2.939 3.524-2.034a.2.2 0 0 0 .271-.073l.802-1.388a.2.2 0 0 0-.073-.271c-1.303-.753-1.516-2.434-.665-3.5a.75.75 0 0 1 1.172.936.852.852 0 0 0 .243 1.265 1.7 1.7 0 0 1 .622 2.32l-.802 1.388a1.7 1.7 0 0 1-2.32.622.85.85 0 0 0-1.274.735c0 .938-.76 1.699-1.699 1.699H7.2c-.938 0-1.699-.76-1.699-1.699a.85.85 0 0 0-1.274-.735 1.7 1.7 0 0 1-2.32-.622l-.802-1.388a1.7 1.7 0 0 1 .622-2.32.85.85 0 0 0 0-1.472 1.7 1.7 0 0 1-.622-2.32l.801-1.388a1.7 1.7 0 0 1 2.32-.622A.85.85 0 0 0 5.5 2.2c0-.94.76-1.7 1.699-1.7H9.3a.75.75 0 1 1 0 1.5zm.8 7.5a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3M8 11a3 3 0 1 0 0-6 3 3 0 0 0 0 6"),
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
