// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CommentPlusOutlined : GravityIcon
{
    public CommentPlusOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CommentPlusOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1, 14, 14.000225067138672);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0666346580785997, 0, 0, 1.0666346580785997, -0.53307726462879756, -0.53307726462879756);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m4.772 11.795.071-.851-.695-.496C3.156 9.743 2.5 8.648 2.5 7c0-1.563.59-2.62 1.48-3.323C4.913 2.94 6.305 2.5 8 2.5s3.087.44 4.02 1.177c.89.702 1.48 1.76 1.48 3.323s-.59 2.62-1.48 3.323C11.087 11.06 9.695 11.5 8 11.5q-.108 0-.213-.002l-.59-.013-.44.391-1.77 1.572a.204.204 0 0 1-.338-.17zm2.981 1.202L5.984 14.57a1.704 1.704 0 0 1-2.83-1.415l.123-1.484C1.877 10.674 1 9.117 1 7c0-4 3.134-6 7-6s7 2 7 6-3.134 6-7 6q-.124 0-.247-.003M8.75 5a.75.75 0 0 0-1.5 0v1.25H6a.75.75 0 0 0 0 1.5h1.25V9a.75.75 0 0 0 1.5 0V7.75H10a.75.75 0 0 0 0-1.5H8.75z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
