// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class GraphNodeOutlined : GravityIcon
{
    public GraphNodeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new GraphNodeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.9987640380859375, 0.99999994039535522, 14.000699996948242, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666285634406991, 0, 0, 1.0666285634406991, -0.53302850752559294, -0.53302850752559294);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.75 2.5h4.5a1.5 1.5 0 0 1 1.269.7 2.5 2.5 0 0 0 .231 4.686V12a1.5 1.5 0 0 1-1.5 1.5h-4.5c-.534 0-1.003-.28-1.269-.7a2.5 2.5 0 0 0-.231-4.686v-.228A2.501 2.501 0 0 0 4.481 3.2c.266-.42.735-.7 1.269-.7m-3 5.614v-.228a2.501 2.501 0 0 1 .146-4.812A3 3 0 0 1 5.75 1h4.5a3 3 0 0 1 2.854 2.074 2.501 2.501 0 0 1 .146 4.812V12a3 3 0 0 1-3 3h-4.5a3 3 0 0 1-2.854-2.073 2.501 2.501 0 0 1-.146-4.813M3.5 11.5a1 1 0 1 0 0-2 1 1 0 0 0 0 2m-1-6a1 1 0 1 1 2 0 1 1 0 0 1-2 0m10-1a1 1 0 1 0 0 2 1 1 0 0 0 0-2"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
