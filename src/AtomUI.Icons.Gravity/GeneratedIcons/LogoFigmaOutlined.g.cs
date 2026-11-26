// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoFigmaOutlined : GravityIcon
{
    public LogoFigmaOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoFigmaOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(3.2489025592803955, 1, 9.5010976791381836, 14.003000259399414);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9272137076974728, 0, 0, 0.9272137076974728, 0.5822903384202176, 0.5822903384202176);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.913 1a2.837 2.837 0 0 1 2.837 2.837c0 .811-.343 1.54-.889 2.058a2.74 2.74 0 0 1 .889 2.02v.174a2.75 2.75 0 0 1-2.75 2.75c-.45 0-.875-.112-1.25-.304v1.718a2.75 2.75 0 1 1-5.5 0v-.087c0-.824.353-1.565.914-2.083a2.826 2.826 0 0 1 0-4.164 2.83 2.83 0 0 1-.914-2.082A2.837 2.837 0 0 1 6.087 1zm-3.92 9.833a1.337 1.337 0 0 0-1.243 1.333v.087a1.25 1.25 0 1 0 2.5 0v-1.414H6.087c-.032 0-.063-.005-.095-.006m3.92-4.16h-.06A1.25 1.25 0 0 0 8.75 7.916v.174a1.25 1.25 0 0 0 2.5 0v-.174a1.25 1.25 0 0 0-1.205-1.248c-.044.002-.088.007-.132.007M6 6.67a1.335 1.335 0 0 0-.003 2.664l.09-.004H7.25V6.674H6.087l-.088-.005M8.75 5.174h1.07q.09-.007.18-.009l.045.002A1.337 1.337 0 0 0 9.913 2.5H8.75zM6.087 2.5a1.337 1.337 0 0 0-.088 2.669l.088-.004H7.25V2.5z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
