// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class AbbrZipOutlined : GravityIcon
{
    public AbbrZipOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new AbbrZipOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.99887800216674805, 3.9999995231628418, 13.751121520996094, 8.0000019073486328);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.91428583884727466, 0, 0, 0.91428583884727466, 0.68571328922180275, 0.68571328922180275);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M1 4.75A.75.75 0 0 1 1.75 4h3.113a1.137 1.137 0 0 1 .96 1.748L2.797 10.5H5.25a.75.75 0 0 1 0 1.5H2.137a1.137 1.137 0 0 1-.96-1.748L4.203 5.5H1.75A.75.75 0 0 1 1 4.75M7.75 4a.75.75 0 0 1 .75.75v6.5a.75.75 0 0 1-1.5 0v-6.5A.75.75 0 0 1 7.75 4m3 0a.75.75 0 0 0-.75.75v6.5a.75.75 0 0 0 1.5 0V9.5h.5A2.75 2.75 0 1 0 12 4zM12 8h-.5V5.5h.5A1.25 1.25 0 1 1 12 8"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
