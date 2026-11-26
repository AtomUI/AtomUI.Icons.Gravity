// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PauseOutlined : GravityIcon
{
    public PauseOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PauseOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5, 1.5, 13, 13);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.103448275862069, 0, 0, 1.103448275862069, -0.8275862068965516, -0.8275862068965516);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M5.25 1.5C6.216 1.5 7 2.284 7 3.25v9.5a1.75 1.75 0 0 1-1.75 1.75h-2l-.179-.009A1.75 1.75 0 0 1 1.51 12.93l-.01-.18v-9.5a1.75 1.75 0 0 1 1.571-1.741L3.25 1.5zm7.5 0c.966 0 1.75.784 1.75 1.75v9.5a1.75 1.75 0 0 1-1.75 1.75h-2l-.179-.009A1.75 1.75 0 0 1 9.01 12.93L9 12.75v-9.5a1.75 1.75 0 0 1 1.571-1.741l.179-.009zM3.25 3a.25.25 0 0 0-.25.25v9.5c0 .138.112.25.25.25h2a.25.25 0 0 0 .25-.25v-9.5A.25.25 0 0 0 5.25 3zm7.5 0a.25.25 0 0 0-.25.25v9.5c0 .138.112.25.25.25h2a.25.25 0 0 0 .25-.25v-9.5a.25.25 0 0 0-.25-.25z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
