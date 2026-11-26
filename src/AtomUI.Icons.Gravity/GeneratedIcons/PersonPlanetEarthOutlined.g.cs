// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PersonPlanetEarthOutlined : GravityIcon
{
    public PersonPlanetEarthOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PersonPlanetEarthOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 1, 16, 15);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7 6.5a2 2 0 1 0 0-4 2 2 0 0 0 0 4M7 8a3.5 3.5 0 1 0 0-7 3.5 3.5 0 0 0 0 7m3.229 3.909-.702-.28a2.5 2.5 0 0 1 3.339-1.975c-.121.185-.303.33-.523.403l-.035.012a.951.951 0 0 0 0 1.805l.46.154a.66.66 0 0 1 .383.331.66.66 0 0 0 .957.254l.365-.242a2.5 2.5 0 0 1-2.4 2.128.8.8 0 0 0 .041-.247v-.08a.686.686 0 0 0-.685-.686.686.686 0 0 1-.686-.686v-.132a.82.82 0 0 0-.514-.76M12 16a4 4 0 1 0 0-8 4 4 0 0 0 0 8M6.25 8.525c.414-.028.75.31.75.725 0 .414-.336.747-.75.78-1.369.107-2.567.5-3.43 1.011-1.1.65-1.32 1.255-1.32 1.459a1 1 0 0 0 1 1h3.75a.75.75 0 0 1 0 1.5H2.5A2.5 2.5 0 0 1 0 12.5c0-1.868 2.75-3.737 6.25-3.975"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
