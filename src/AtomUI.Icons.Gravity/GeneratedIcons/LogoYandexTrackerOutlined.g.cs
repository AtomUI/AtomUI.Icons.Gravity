// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoYandexTrackerOutlined : GravityIcon
{
    public LogoYandexTrackerOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoYandexTrackerOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.75 2.5a.25.25 0 0 0-.25.25v2.167c0 .138.112.25.25.25h2.417V2.5zm3.917 0v2.667h2.666V2.5zm4.166 0v2.667h2.417a.25.25 0 0 0 .25-.25V2.75a.25.25 0 0 0-.25-.25zm0 4.167h2.417A1.75 1.75 0 0 0 15 4.917V2.75A1.75 1.75 0 0 0 13.25 1H2.75A1.75 1.75 0 0 0 1 2.75v2.167c0 .966.784 1.75 1.75 1.75h2.417v6.583c0 .966.783 1.75 1.75 1.75h2.166a1.75 1.75 0 0 0 1.75-1.75zm-1.5 0H6.667v2.666h2.666zm0 4.166H6.667v2.417c0 .138.112.25.25.25h2.166a.25.25 0 0 0 .25-.25z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
