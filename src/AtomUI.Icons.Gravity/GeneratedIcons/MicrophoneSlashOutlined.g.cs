// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MicrophoneSlashOutlined : GravityIcon
{
    public MicrophoneSlashOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MicrophoneSlashOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.7687101364135742, 0.49883008003234863, 12.50001335144043, 15.001171112060547);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.95629270775636199, 0, 0, 0.95629270775636199, 0.34965833794910406, 0.34965833794910406);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8.773 9.9A3.004 3.004 0 0 1 5 7v-.94L1.97 3.03a.75.75 0 0 1 1.06-1.06l11 11a.75.75 0 1 1-1.06 1.06l-1.884-1.883a6 6 0 0 1-2.336.807v1.796a.75.75 0 0 1-1.5 0v-1.796A6 6 0 0 1 2 7v-.25a.75.75 0 0 1 1.5 0V7a4.5 4.5 0 0 0 6.481 4.042L8.825 9.885zM9.5 3.5v2.798l1.415 1.415Q11 7.369 11 7V3.5a3 3 0 0 0-5.669-1.371l1.18 1.18A1.5 1.5 0 0 1 9.5 3.5m2.587 5.385L13.2 9.997c.51-.882.8-1.905.8-2.997v-.25a.75.75 0 0 0-1.5 0V7a4.5 4.5 0 0 1-.413 1.885"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
