// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CpusOutlined : GravityIcon
{
    public CpusOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CpusOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 0, 16, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7.75 0a.75.75 0 0 1 .75.75V2h2V.75a.75.75 0 0 1 1.5 0V2a2 2 0 0 1 2 2h1.25a.75.75 0 0 1 0 1.5H14v2h1.25a.75.75 0 0 1 0 1.5H14a2 2 0 0 1-2 2h-1v1a2 2 0 0 1-2 2v1.25a.75.75 0 0 1-1.5 0V14h-2v1.25a.75.75 0 0 1-1.5 0V14a2 2 0 0 1-2-2H.75a.75.75 0 0 1 0-1.5H2v-2H.75a.75.75 0 0 1 0-1.5H2a2 2 0 0 1 2-2h1V4a2 2 0 0 1 2-2V.75A.75.75 0 0 1 7.75 0M6.5 5H9a2 2 0 0 1 2 2v2.5h1a.5.5 0 0 0 .5-.5V4a.5.5 0 0 0-.5-.5H7a.5.5 0 0 0-.5.5zm3 2a.5.5 0 0 0-.5-.5H4a.5.5 0 0 0-.5.5v5a.5.5 0 0 0 .5.5h5a.5.5 0 0 0 .5-.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
