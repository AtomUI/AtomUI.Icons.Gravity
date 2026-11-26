// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class Heading4Outlined : GravityIcon
{
    public Heading4Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new Heading4Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 3.4999730587005615, 14.25, 8.996027946472168);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.88869145152679474, 0, 0, 0.88869145152679474, 0.89046838778564208, 0.89046838778564208);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M14.25 4.25a.75.75 0 0 0-1.347-.454l-4 5.25A.75.75 0 0 0 9.5 10.25h3.25v1.496a.75.75 0 0 0 1.5 0V10.25h.25a.75.75 0 1 0 0-1.5h-.25zm-1.5 2.222V8.75h-1.736zM2.5 4.25a.75.75 0 1 0-1.5 0v7.496a.75.75 0 0 0 1.5 0V8.75h4v2.996a.75.75 0 0 0 1.5 0V4.25a.75.75 0 1 0-1.5 0v3h-4z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
