// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class UmbrellaOutlined : GravityIcon
{
    public UmbrellaOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new UmbrellaOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.8353997468948364, 1.0219317674636841, 12.179238319396973, 14.142168045043945);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.98077908630836186, 0, 0, 0.98077908630836186, 0.15376730953310513, 0.15376730953310513);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.184 11.595c-.05.02-.34.112-1.114-.187-.953-.368-2.258-1.218-3.76-2.719-1.5-1.5-2.35-2.806-2.718-3.759-.298-.774-.206-1.063-.186-1.113 1.57-1.535 5.177-2.013 7.483.294 2.32 2.32 1.915 5.83.295 7.484M5.79 10.27c2.947 2.747 5.427 3.411 6.428 2.41 2.062-2.061 2.616-6.141.235-9.073l.577-.578a.75.75 0 1 0-1.06-1.06l-.579.578C8.448.178 4.286.814 2.318 2.782c-1 1-.336 3.48 2.411 6.428l-2.26 2.26a2.164 2.164 0 1 0 3.061 3.06l.25-.25a.75.75 0 1 0-1.06-1.06l-.25.25a.664.664 0 1 1-.94-.94z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
