// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MicroscopeOutlined : GravityIcon
{
    public MicroscopeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MicroscopeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 0.99165982007980347, 11.804847717285156, 14.008339881896973);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.98794999327922062, 0, 0, 0.98794999327922062, 0.096400053766235061, 0.096400053766235061);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10.103 1.211a.75.75 0 0 1 1.06 0l.612.611a.75.75 0 0 1 0 1.062l-.05.049a.75.75 0 0 1-.008 1.05l-.207.206a5.735 5.735 0 0 1-.186 9.311H13a.75.75 0 0 1 0 1.5H3a.75.75 0 0 1 0-1.5h1.793a5.8 5.8 0 0 1-1.31-1.25H2.75a.75.75 0 0 1 0-1.5h4.472a.75.75 0 0 1 0 1.5H5.62a4.247 4.247 0 0 0 6.684-3.474 4.24 4.24 0 0 0-1.87-3.512L6.799 8.9a.75.75 0 0 1-1.056.004l-.314.316a.75.75 0 0 1-1.06 0l-.615-.614a.75.75 0 0 1 0-1.061l.314-.315a.75.75 0 0 1 .018-1.042l4.918-4.92a.75.75 0 0 1 1.05-.01zM5.676 6.72l.592.592 3.847-3.85-.592-.592z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
