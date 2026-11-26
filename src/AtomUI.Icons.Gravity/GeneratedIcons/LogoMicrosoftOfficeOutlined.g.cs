// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoMicrosoftOfficeOutlined : GravityIcon
{
    public LogoMicrosoftOfficeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoMicrosoftOfficeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 1.0059221982955933, 12, 13.977349281311035);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0020954467646634, 0, 0, 1.0020954467646634, -0.016763574117307556, -0.016763574117307556);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8.719 1.059c.203-.061.42-.07.627-.024l.103.028 3.673 1.144c.522.163.878.646.878 1.193v9.165a1.25 1.25 0 0 1-.85 1.184l-3.463 1.168a1.25 1.25 0 0 1-.863-.022l-6.037-2.409A1.25 1.25 0 0 1 2 11.326v-6.77c0-.513.314-.975.791-1.163l5.827-2.3zM3.5 4.726v6.43l.75.3V5.487a.75.75 0 0 1 .564-.726l4.5-1.153a.75.75 0 0 1 .936.727V11.5a.75.75 0 0 1-.826.746l-4.295-.44 4.165 1.66 3.206-1.082V3.583L9.087 2.52zM5.75 6.07v4.291l3 .308V5.302z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
