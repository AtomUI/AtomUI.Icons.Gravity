// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CodeTrunkOutlined : GravityIcon
{
    public CodeTrunkOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CodeTrunkOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4978971481323242, 1.497209906578064, 13.003103256225586, 13.004895210266113);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1032040622926473, 0, 0, 1.1032040622926473, -0.82563249834117869, -0.82563249834117869);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.312 4.909A1.25 1.25 0 1 1 3.19 3.593a1.25 1.25 0 0 1 2.123 1.316m-2.124 6.182a1.25 1.25 0 1 0 2.125 1.318 1.25 1.25 0 0 0-2.125-1.318M5 9.104V6.896a2.751 2.751 0 1 0-1.5 0v2.208A2.751 2.751 0 1 0 6.896 12.5H9.5a3 3 0 0 0 3-2.98V6.895a2.751 2.751 0 1 0-1.5 0V9.5A1.5 1.5 0 0 1 9.5 11H6.896A2.76 2.76 0 0 0 5 9.104m7.812-4.195a1.25 1.25 0 1 0-2.125-1.318 1.25 1.25 0 0 0 2.125 1.318"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
