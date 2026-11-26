// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleNumber2Filled : GravityIcon
{
    public CircleNumber2Filled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleNumber2Filled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1a7 7 0 1 1 0 14A7 7 0 0 1 8 1m-.06 3.85c-.917 0-1.732.537-2.05 1.433a.65.65 0 0 0 1.226.434c.125-.353.432-.567.824-.567.347 0 .562.11.689.239.13.13.22.332.22.611 0 .16-.068.364-.253.612a4 4 0 0 1-.767.735c-.627.474-1.346.831-1.672.982a.96.96 0 0 0-.547.73l-.01.14.004.098c.05.48.455.853.947.853H9.75a.65.65 0 0 0 0-1.3H7.926c.226-.14.46-.296.687-.467.368-.278.74-.612 1.025-.993.283-.38.512-.852.512-1.39 0-.573-.195-1.12-.598-1.527-.406-.41-.972-.623-1.612-.623"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
