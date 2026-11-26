// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoGooglePlayOutlined : GravityIcon
{
    public LogoGooglePlayOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoGooglePlayOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4989999532699585, 0.58034342527389526, 13.500625610351562, 14.839255332946777);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.010128306980645, 0, 0, 1.010128306980645, -0.081026455845160328, -0.081026455845160328);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M1.507 2.906C1.63 1.086 3.637-.014 5.252.92l8.5 4.916c1.663.963 1.664 3.366 0 4.328l-2.328 1.346a.7.7 0 0 1-.228.132L5.252 15.08l-.157.084c-1.585.778-3.468-.308-3.588-2.069l-.008-.179.001-9.832zM3.37 13.693a.995.995 0 0 0 1.13.089l5.207-3.013-1.706-1.707zM3 11.943l3.941-3.94L3 4.06zm6.062-3.94 1.99 1.99L13 8.866a1 1 0 0 0 0-1.73l-1.946-1.127zM4.5 2.218a.995.995 0 0 0-1.13.089l4.631 4.634 1.709-1.71z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
