// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MathOperationsOutlined : GravityIcon
{
    public MathOperationsOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MathOperationsOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.499000072479248, 2.15077805519104, 13.000999450683594, 12.352222442626953);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1029917534726503, 0, 0, 1.1029917534726503, -0.82393402778120262, -0.82393402778120262);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.874 3.44a.75.75 0 1 0-1.061-1.06L11.75 3.44l-1.06-1.06a.75.75 0 1 0-1.061 1.06l1.062 1.06-1.062 1.063a.75.75 0 0 0 1.06 1.06l1.062-1.061 1.062 1.062a.75.75 0 0 0 1.06-1.061L12.813 4.5zm-11.625.31a.75.75 0 0 0 0 1.5H6.75a.75.75 0 1 0 0-1.5zm3.001 5.5a.75.75 0 0 0-1.5 0v1.501h-1.5a.75.75 0 0 0 0 1.5h1.5v1.502a.75.75 0 0 0 1.5 0V12.25h1.501a.75.75 0 0 0 0-1.5h-1.5zm4.5 0a.75.75 0 0 0 0 1.5h4a.75.75 0 0 0 0-1.5zm0 3a.75.75 0 0 0 0 1.5h4a.75.75 0 0 0 0-1.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
