// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SkullOutlined : GravityIcon
{
    public SkullOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SkullOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m12.5 12 .614-.246A3 3 0 0 0 15 8.97V8A7 7 0 1 0 1 8v.969a3 3 0 0 0 1.886 2.785L3.5 12l1 3h7zm-2.081 1.5.658-1.974.22-.66.646-.259.614-.245a1.5 1.5 0 0 0 .943-1.393V8a5.5 5.5 0 1 0-11 0v.969a1.5 1.5 0 0 0 .943 1.393l.614.245.646.259.22.66.658 1.974h.544L6.5 12h1v1.5h1V12h1l.375 1.5zM9 8.4A1.4 1.4 0 0 1 10.4 7h.246a1.353 1.353 0 0 1 .223 2.688l-.515.086A1.163 1.163 0 0 1 9 8.628zM5.353 7a1.353 1.353 0 0 0-.222 2.688l.515.086A1.163 1.163 0 0 0 7 8.628V8.4A1.4 1.4 0 0 0 5.6 7z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
