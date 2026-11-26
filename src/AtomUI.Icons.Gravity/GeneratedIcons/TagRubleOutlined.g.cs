// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TagRubleOutlined : GravityIcon
{
    public TagRubleOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TagRubleOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.51946288347244263, 1, 14.480537414550781, 14.466111183166504);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0042541417888613, 0, 0, 1.0042541417888613, -0.034033134310890389, -0.034033134310890389);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m7.182 2.94-4.87 4.869a1 1 0 0 0-.006 1.408l4.37 4.45a1 1 0 0 0 1.414.012l4.96-4.868a1.5 1.5 0 0 0 .45-1.07V3.5a1 1 0 0 0-1-1H8.243a1.5 1.5 0 0 0-1.061.44m6.92 6.942A3 3 0 0 0 15 7.741V3.5A2.5 2.5 0 0 0 12.5 1H8.243a3 3 0 0 0-2.122.879l-4.87 4.87a2.5 2.5 0 0 0-.015 3.519l4.37 4.45a2.5 2.5 0 0 0 3.535.032zm-3.908-5.844a.75.75 0 0 0-1.06 0L7.366 5.805l-.088-.088a.75.75 0 0 0-1.06 1.06l.087.09-.353.353-.088-.089a.75.75 0 0 0-1.061 1.061l.088.088-.353.354a.75.75 0 0 0 1.06 1.06l.354-.353 1.06 1.06a.75.75 0 1 0 1.061-1.06l-1.06-1.06.353-.354.796.795a2.375 2.375 0 0 0 3.358-3.358zm-.972 3.624-.795-.796L9.664 5.63l.796.795a.875.875 0 0 1-1.238 1.238"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
