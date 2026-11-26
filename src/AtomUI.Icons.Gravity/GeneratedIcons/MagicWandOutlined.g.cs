// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MagicWandOutlined : GravityIcon
{
    public MagicWandOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MagicWandOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.73129457235336304, 1.0105806589126587, 14.259501457214355, 14.258124351501465);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0291630067482438, 0, 0, 1.0291630067482438, -0.23330405398595033, -0.23330405398595033);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m11.1 5.894-.412.903.671.732 1.356 1.48-1.994-.227-.986-.113-.49.864-.987 1.747-.4-1.967-.198-.972-.973-.198-1.966-.4 1.746-.989.864-.489-.112-.986-.227-1.994L8.47 4.641l.732.67.903-.411 1.826-.832zM7.02 1.276l2.465 2.26 3.043-1.387c.842-.384 1.708.483 1.325 1.324l-1.387 3.043 2.259 2.465c.625.682.069 1.774-.85 1.67l-3.323-.38-1.646 2.911c-.456.805-1.666.613-1.85-.293l-.667-3.277-3.277-.666c-.906-.185-1.098-1.395-.293-1.85l2.91-1.647-.378-3.322c-.105-.92.987-1.476 1.669-.85M5.53 11.53a.75.75 0 1 0-1.06-1.06l-3.5 3.5a.75.75 0 1 0 1.06 1.06z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
