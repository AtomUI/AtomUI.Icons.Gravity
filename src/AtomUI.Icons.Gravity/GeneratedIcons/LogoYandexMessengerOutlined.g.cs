// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoYandexMessengerOutlined : GravityIcon
{
    public LogoYandexMessengerOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoYandexMessengerOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.62908780574798584, 1.4996830224990845, 14.871912956237793, 13.00063419342041);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96959799383586176, 0, 0, 0.96959799383586176, 0.24321604931310592, 0.24321604931310592);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m3.585 11.965-.716.148a1.863 1.863 0 0 1-1.792-3.036L2 8l-.923-1.077A1.863 1.863 0 0 1 2.87 3.887l.716.148-.07-.303a1.822 1.822 0 0 1 2.64-2.014l8.293 4.466a2 2 0 0 1 1.052 1.76v.111a2 2 0 0 1-1.052 1.761l-8.293 4.466a1.822 1.822 0 0 1-2.64-2.014zm1.617-.334-.225.974a.322.322 0 0 0 .466.356l1.625-.875 3.895-1.647zm5.761-6.07L7.068 3.914l-1.625-.875a.322.322 0 0 0-.466.356l.225.974zM3.14 8.976 3.976 8l-.837-.976-.923-1.077a.363.363 0 0 1 .349-.591l11.162 2.309a.342.342 0 0 1 0 .67l-11.162 2.31a.363.363 0 0 1-.349-.592z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
