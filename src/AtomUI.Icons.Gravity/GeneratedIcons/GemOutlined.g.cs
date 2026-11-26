// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class GemOutlined : GravityIcon
{
    public GemOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new GemOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.58039909601211548, 2, 14.839104652404785, 11.990375518798828);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94963199509958385, 0, 0, 0.94963199509958385, 0.40294403920332922, 0.40294403920332922);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.235 2.014A2 2 0 0 1 13.6 2.8l1.42 1.892c.57.761.526 1.819-.106 2.53l-5.419 6.096-.156.158a2 2 0 0 1-2.678 0l-.156-.158-5.419-6.096a2 2 0 0 1-.105-2.53L2.4 2.8A2 2 0 0 1 4 2h8zm-4.236 9.082L9.862 6.75H6.138zm-1.788-.366L4.506 6.75H2.674zm3.576 0 3.54-3.98h-1.833zM4 3.5a.5.5 0 0 0-.4.2L2.438 5.25h2.021l.584-1.75zm7.541 1.75h2.022L12.4 3.7a.5.5 0 0 0-.4-.2h-1.043zm-5.5 0h3.918L9.376 3.5H6.623z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
