// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class HammerOutlined : GravityIcon
{
    public HammerOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new HammerOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 0.49999940395355225, 15.25, 14.999335289001465);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99995842003865365, 0, 0, 0.99995842003865365, 0.00033263969077079736, 0.00033263969077079736);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.245 8.884a1.3 1.3 0 0 0-.084-.347A1.25 1.25 0 0 0 10 7.75l-4.424 6.53A2.777 2.777 0 0 1 .5 12.724v-.075c0-.736.285-1.445.796-1.976L6.75 5v-.158A2.17 2.17 0 0 0 5.55 2.9l-.117-.058A1.236 1.236 0 0 1 5.986.5H7.68a5 5 0 0 1 3.535 1.464L12.75 3.5a2 2 0 0 0 2 2l1 1-1.06 1.06-1.38 1.38L12.25 10l-1-1q0-.06-.005-.116m-1.091-5.859 1.164 1.164a3.5 3.5 0 0 0 2.081 2.54l-.973.974A2.75 2.75 0 0 0 10 6.25h-.796l-.446.659-.65.96-1.098-.975.821-.854.419-.436v-.762A3.67 3.67 0 0 0 6.903 2h.776a3.5 3.5 0 0 1 2.475 1.025M5.969 7.976l1.29 1.146-2.925 4.317A1.277 1.277 0 0 1 2 12.723v-.075c0-.349.135-.684.377-.936z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
