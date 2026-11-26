// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BooksOutlined : GravityIcon
{
    public BooksOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BooksOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0019999742507935, 0.9530453085899353, 14.002920150756836, 14.046955108642578);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0659674039328961, 0, 0, 1.0659674039328961, -0.52773923146316903, -0.52773923146316903);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10.803.987a2 2 0 0 1 2.333 1.599l1.835 9.83a2 2 0 0 1-1.4 2.285l-.2.048-.982.184-.203.027a2 2 0 0 1-2.082-1.428l-.048-.198-.554-2.967V13a2 2 0 0 1-1.796 1.99l-.204.01h-4.5l-.204-.01a2 2 0 0 1-1.785-1.786L1.002 13V3a2 2 0 0 1 2-2h4.5c.554 0 1.055.225 1.417.589.252-.207.558-.355.9-.42zM6.002 13.5h1.5a.5.5 0 0 0 .5-.5V3a.5.5 0 0 0-.5-.5h-1.5zm-3-11a.5.5 0 0 0-.5.5v10a.5.5 0 0 0 .5.5h1.5v-11zM10.2 5.938l1.33 7.12a.5.5 0 0 0 .583.4l.983-.184a.5.5 0 0 0 .4-.583l-1.329-7.12zm.878-3.477-.983.183a.5.5 0 0 0-.4.584l.23 1.236 1.967-.367-.23-1.236a.5.5 0 0 0-.584-.4"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
