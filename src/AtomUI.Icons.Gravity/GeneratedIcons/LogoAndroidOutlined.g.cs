// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoAndroidOutlined : GravityIcon
{
    public LogoAndroidOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoAndroidOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.41707697510719299, 0.99970459938049316, 15.16584587097168, 13.500295639038086);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96004730419543305, 0, 0, 0.96004730419543305, 0.31962156643653561, 0.31962156643653561);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M15.48 9.83c-.39-2.392-1.768-4.268-3.653-5.338l1.106-2.432a.75.75 0 1 0-1.366-.62l-1.112 2.446A7.9 7.9 0 0 0 8 3.5a7.9 7.9 0 0 0-2.455.386L4.433 1.44a.75.75 0 1 0-1.366.62l1.106 2.432C2.288 5.562.909 7.438.52 9.83c-.13.798-.178 1.655.107 2.433.325.89.989 1.441 1.768 1.75.701.28 1.54.383 2.404.433.887.052 1.963.054 3.201.054s2.314-.002 3.2-.054c.864-.05 1.704-.154 2.405-.432.78-.31 1.443-.86 1.768-1.75.285-.78.237-1.636.107-2.434M2 10.071C1.53 12.961 3 13 8 13s6.47-.038 6-2.929C13.5 7 11 5 8 5s-5.5 2-6 5.071m8.5 1.179a.75.75 0 0 1-.75-.75V9a.75.75 0 0 1 1.5 0v1.5a.75.75 0 0 1-.75.75m-5.75-.75a.75.75 0 0 0 1.5 0V9a.75.75 0 0 0-1.5 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
