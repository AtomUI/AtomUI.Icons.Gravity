// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CloudSlashOutlined : GravityIcon
{
    public CloudSlashOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CloudSlashOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(-0.0057245157659053802, 1.4993165731430054, 16.006071090698242, 12.769407272338867);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.9023250449709096, 0, 0, 0.9023250449709096, 0.78139964023272324, 0.78139964023272324);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.364 4.424 1.97 3.03a.75.75 0 0 1 1.06-1.06l11 11a.75.75 0 1 1-1.06 1.06l-.612-.612a4.5 4.5 0 0 1-.858.082H3.75a3.75 3.75 0 0 1-.747-7.426 4.7 4.7 0 0 1 .36-1.65M10.939 12H3.751a2.25 2.25 0 0 1-.003-4.5h.03a.75.75 0 0 0 .747-.843 3.3 3.3 0 0 1 .036-1.036zm-.388-7.4a4.5 4.5 0 0 0-1.863.886l1.07 1.07a3 3 0 0 1 1.842-.554 3 3 0 0 1 2.343 4.74l1.07 1.07a4.5 4.5 0 0 0-2.826-7.26A4.75 4.75 0 0 0 5.351 2.15l1.115 1.115A3.25 3.25 0 0 1 10.55 4.6"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
