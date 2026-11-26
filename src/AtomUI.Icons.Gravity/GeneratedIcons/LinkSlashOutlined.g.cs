// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LinkSlashOutlined : GravityIcon
{
    public LinkSlashOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LinkSlashOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5390454530715942, 1.5400317907333374, 12.921921730041504, 12.92092227935791);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1064256829308032, 0, 0, 1.1064256829308032, -0.85140546344642587, -0.85140546344642587);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m8 9.06 4.97 4.97a.75.75 0 1 0 1.06-1.06l-11-11a.75.75 0 0 0-1.06 1.06L6.94 8 5.47 9.47a.75.75 0 1 0 1.06 1.06zm3.54-.722L12.601 9.4l.656-.656a4.243 4.243 0 0 0-6-6l-.656.656 1.06 1.06.657-.656a2.743 2.743 0 0 1 3.879 3.879zM9.47 5.47l-.4.399 1.061 1.06.4-.399A.75.75 0 1 0 9.47 5.47M3.22 6.78a.75.75 0 0 1 1.06 1.061l-.477.477a2.743 2.743 0 0 0 3.879 3.879l.477-.477a.75.75 0 0 1 1.06 1.06l-.476.477a4.243 4.243 0 0 1-6-6z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
