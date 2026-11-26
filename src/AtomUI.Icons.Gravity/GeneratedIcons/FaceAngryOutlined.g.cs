// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FaceAngryOutlined : GravityIcon
{
    public FaceAngryOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FaceAngryOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666666666666667, 0, 0, 1.0666666666666667, -0.53333333333333321, -0.53333333333333321);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.5 8a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0M15 8A7 7 0 1 1 1 8a7 7 0 0 1 14 0m-6 3.5A.75.75 0 0 0 9 10H7a.75.75 0 0 0 0 1.5zm1.5-2a.75.75 0 0 1-.75-.75V7.71l-.068.018a.75.75 0 0 1-.364-1.456l2-.5a.75.75 0 0 1 .364 1.456l-.432.108V8.75a.75.75 0 0 1-.75.75m-5 0a.75.75 0 0 1-.75-.75V7.336l-.432-.108a.75.75 0 0 1 .364-1.456l2 .5a.75.75 0 0 1-.364 1.456L6.25 7.71v1.04a.75.75 0 0 1-.75.75"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
