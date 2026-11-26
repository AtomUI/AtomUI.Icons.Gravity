// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CurlyBracketsLockOutlined : GravityIcon
{
    public CurlyBracketsLockOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CurlyBracketsLockOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.24810928106307983, 0.99999940395355225, 15.503781318664551, 14.000001907348633);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96947487838742297, 0, 0, 0.96947487838742297, 0.24420097290061626, 0.24420097290061626);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.413 3.421A.84.84 0 0 1 4.25 2.5a.75.75 0 0 0 0-1.5 2.34 2.34 0 0 0-2.33 2.563l.199 2.096a.9.9 0 0 1-.677.957l-.139.035a1.39 1.39 0 0 0 0 2.698l.14.035a.9.9 0 0 1 .676.957l-.2 2.096A2.34 2.34 0 0 0 4.25 15a.75.75 0 0 0 0-1.5.84.84 0 0 1-.837-.921l.2-2.096A2.4 2.4 0 0 0 2.04 8a2.4 2.4 0 0 0 1.571-2.483zm9.175 9.158a.84.84 0 0 1-.838.921.75.75 0 0 0 0 1.5 2.34 2.34 0 0 0 2.33-2.563l-.199-2.096a.9.9 0 0 1 .677-.957l.139-.035a1.39 1.39 0 0 0 0-2.698l-.14-.035a.9.9 0 0 1-.676-.957l.2-2.096A2.34 2.34 0 0 0 11.75 1a.75.75 0 0 0 0 1.5c.496 0 .884.427.838.921l-.2 2.096A2.4 2.4 0 0 0 13.959 8a2.4 2.4 0 0 0-1.571 2.483zM6 8v1.5h4V8zm-.1-1.5a1.4 1.4 0 0 0-1.4 1.4v1.7A1.4 1.4 0 0 0 5.9 11h4.2a1.4 1.4 0 0 0 1.4-1.4V7.9a1.4 1.4 0 0 0-1.4-1.4H10V6a2 2 0 1 0-4 0v.5zm1.6 0h1V6a.5.5 0 0 0-1 0z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
