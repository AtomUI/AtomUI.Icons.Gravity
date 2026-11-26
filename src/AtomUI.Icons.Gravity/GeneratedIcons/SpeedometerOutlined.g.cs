// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SpeedometerOutlined : GravityIcon
{
    public SpeedometerOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SpeedometerOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.2495264858007431, 1.3830000162124634, 15.499946594238281, 13.234661102294922);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94779514477716165, 0, 0, 0.94779514477716165, 0.41763884178270683, 0.41763884178270683);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M8 1.383a7.75 7.75 0 0 1 5.773 12.92.95.95 0 0 1-.907.293l-2.457-.537a.75.75 0 0 1 .32-1.466l2.132.466a6.2 6.2 0 0 0 1.177-2.307l-1.865-.363a.75.75 0 1 1 .286-1.472l1.788.347.003-.131a6.2 6.2 0 0 0-1.051-3.469l-1.115.937a.75.75 0 0 1-.964-1.15l1.102-.926A6.23 6.23 0 0 0 8.75 2.93v1.376a.75.75 0 0 1-1.5 0V2.929a6.23 6.23 0 0 0-3.473 1.595l1.103.927a.75.75 0 0 1-.964 1.15L2.8 5.664a6.2 6.2 0 0 0-1.05 3.469q0 .066.002.13l1.789-.346a.75.75 0 0 1 .287 1.472l-1.866.363a6.2 6.2 0 0 0 1.175 2.307l2.133-.466a.751.751 0 0 1 .32 1.466l-2.456.537a.95.95 0 0 1-.908-.293A7.75 7.75 0 0 1 8 1.383"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M6.326 6.978a.519.519 0 0 1 .821-.393q.142.103.242.246l1.517 2.165a1 1 0 0 1-1.805.863l-.736-2.537a1 1 0 0 1-.04-.344"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
