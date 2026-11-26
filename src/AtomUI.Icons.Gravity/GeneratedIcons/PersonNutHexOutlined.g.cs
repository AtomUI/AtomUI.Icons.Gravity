// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class PersonNutHexOutlined : GravityIcon
{
    public PersonNutHexOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new PersonNutHexOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 1, 15.778416633605957, 15);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.98634021344346123, 0, 0, 0.98634021344346123, 0.10927829245231013, 0.10927829245231013);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M7 6.5a2 2 0 1 0 0-4 2 2 0 0 0 0 4M7 8a3.5 3.5 0 1 0 0-7 3.5 3.5 0 0 0 0 7m-.5 1.299c0-.43-.36-.774-.785-.724C2.473 8.955 0 10.728 0 12.5A2.5 2.5 0 0 0 2.5 15h3.25a.75.75 0 0 0 0-1.5H2.5a1 1 0 0 1-1-1c0-.205.22-.809 1.32-1.459.765-.452 1.792-.813 2.969-.964.397-.051.711-.378.711-.778m6.373 5.201 1.406-2.5-1.406-2.5h-2.746L8.721 12l1.406 2.5zm2.713-1.765a1.5 1.5 0 0 0 0-1.47l-1.406-2.5A1.5 1.5 0 0 0 12.873 8h-2.746a1.5 1.5 0 0 0-1.307.765l-1.406 2.5a1.5 1.5 0 0 0 0 1.47l1.406 2.5a1.5 1.5 0 0 0 1.307.765h2.746a1.5 1.5 0 0 0 1.307-.765zM12.5 12a1 1 0 1 1-2 0 1 1 0 0 1 2 0"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
