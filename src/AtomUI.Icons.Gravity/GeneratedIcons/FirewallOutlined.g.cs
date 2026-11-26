// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FirewallOutlined : GravityIcon
{
    public FirewallOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FirewallOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 1.034000039100647, 14.003999710083008, 13.965999960899353);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0660981222121484, 0, 0, 1.0660981222121484, -0.52878497769718713, -0.52878497769718713);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M6.5 12a1 1 0 0 1 1 1v1a1 1 0 0 1-1 1H2a1 1 0 0 1-1-1v-1a1 1 0 0 1 1-1zm7.5 0a1 1 0 0 1 1 1v1a1 1 0 0 1-1 1H9.5a1 1 0 0 1-1-1v-1a1 1 0 0 1 1-1zM3 8a1 1 0 0 1 1 1v1a1 1 0 0 1-1 1H1.5a.5.5 0 0 1-.5-.5v-2a.5.5 0 0 1 .5-.5z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1.034c.341 0 .68.076.987.223l2.91 1.388c.575.274.943.855.943 1.493v.329l-.014.438a6.87 6.87 0 0 1-1.868 4.283l.042-.04V10a1 1 0 0 1-1 1H6a1 1 0 0 1-1-1v-.853l.041.041a6.87 6.87 0 0 1-1.866-4.283l-.014-.438v-.33c0-.597.322-1.145.837-1.438l.106-.054 2.91-1.388A2.3 2.3 0 0 1 8 1.034m0 1.5a.8.8 0 0 0-.34.077L4.748 3.998a.16.16 0 0 0-.088.14v.329c0 1.838.94 3.549 2.491 4.535l.697.442a.28.28 0 0 0 .303 0l.697-.442a5.38 5.38 0 0 0 2.49-4.535v-.33a.16.16 0 0 0-.087-.139l-2.91-1.387A.8.8 0 0 0 8 2.534"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M14.504 8a.5.5 0 0 1 .5.5v2a.5.5 0 0 1-.5.5h-1.5a1 1 0 0 1-1-1V9a1 1 0 0 1 1-1z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
