// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MoleculeOutlined : GravityIcon
{
    public MoleculeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MoleculeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(-0.0011386205442249775, -6.2908164011332701E-08, 15.750798225402832, 15.499757766723633);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0000274066322439, 0, 0, 1.0000274066322439, -0.00021925305795100769, -0.00021925305795100769);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.706 3.39a1 1 0 1 1 .108-.064 1 1 0 0 0-.108.064m.108 1.546Q4.542 5 4.25 5a2.5 2.5 0 1 1 1.856-.825l.849 1.484a3.5 3.5 0 0 1 3.191.576l2.222-1.851a1.75 1.75 0 1 1 1.101 1.035l-2.362 1.968c.251.483.393 1.031.393 1.613 0 .557-.13 1.083-.361 1.55l.958.767a2.25 2.25 0 1 1-.959 1.154l-.937-.75a3.5 3.5 0 0 1-5.62-1.971H3.33a1.75 1.75 0 1 1 0-1.5h1.25a3.5 3.5 0 0 1 1.072-1.846zM10 9a2 2 0 1 1-4 0 2 2 0 0 1 4 0m3.25 5a.75.75 0 1 0 0-1.5.75.75 0 0 0 0 1.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
