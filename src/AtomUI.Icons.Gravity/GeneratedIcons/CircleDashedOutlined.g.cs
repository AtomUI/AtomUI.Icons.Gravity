// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleDashedOutlined : GravityIcon
{
    public CircleDashedOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleDashedOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99898266792297363, 0.99898314476013184, 14.002034187316895, 14.002033233642578);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0665943279584662, 0, 0, 1.0665943279584662, -0.53275462366772963, -0.53275462366772963);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.906 1.085a7 7 0 0 1 2.188 0 .75.75 0 0 1-.232 1.482 5.6 5.6 0 0 0-1.724 0 .75.75 0 0 1-.232-1.482M4.933 2.502a.75.75 0 0 1-.166 1.048c-.466.34-.878.75-1.217 1.217a.75.75 0 0 1-1.213-.882 7 7 0 0 1 1.548-1.548.75.75 0 0 1 1.048.165m6.135 0a.75.75 0 0 1 1.047-.165 7 7 0 0 1 1.548 1.548.75.75 0 0 1-1.213.882 5.5 5.5 0 0 0-1.217-1.217.75.75 0 0 1-.165-1.048M1.943 6.28a.75.75 0 0 1 .624.857 5.6 5.6 0 0 0 0 1.724.75.75 0 0 1-1.482.232 7 7 0 0 1 0-2.188.75.75 0 0 1 .858-.625m12.115 0a.75.75 0 0 1 .857.625 7 7 0 0 1 0 2.188.75.75 0 1 1-1.482-.232 5.5 5.5 0 0 0 0-1.724.75.75 0 0 1 .624-.857M2.502 11.068a.75.75 0 0 1 1.048.165c.34.466.75.878 1.217 1.217a.75.75 0 0 1-.882 1.213 7 7 0 0 1-1.548-1.548.75.75 0 0 1 .165-1.047m10.996 0a.75.75 0 0 1 .165 1.047 7 7 0 0 1-1.548 1.548.75.75 0 0 1-.883-1.213 5.5 5.5 0 0 0 1.218-1.217.75.75 0 0 1 1.048-.165m-7.217 2.99a.75.75 0 0 1 .857-.625 5.5 5.5 0 0 0 1.724 0 .75.75 0 0 1 .232 1.482 7 7 0 0 1-2.188 0 .75.75 0 0 1-.625-.857"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
