// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ArrowsRotateLeftSlashOutlined : GravityIcon
{
    public ArrowsRotateLeftSlashOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ArrowsRotateLeftSlashOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5517358779907227, 1.4999955892562866, 12.899619102478027, 13.00001335144043);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0997574216241599, 0, 0, 1.0997574216241599, -0.79805937299327923, -0.79805937299327923);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M8 1.5a6.5 6.5 0 0 1 2.709.59L9.552 3.245A5 5 0 0 0 8 3a4.98 4.98 0 0 0-3.57 1.5h1.32a.75.75 0 0 1 0 1.5h-3A.75.75 0 0 1 2 5.25v-3a.75.75 0 1 1 1.5 0v1.06A6.48 6.48 0 0 1 8 1.5m4.026 3.534-6.991 6.992C5.865 12.638 6.89 13 8 13a4.98 4.98 0 0 0 3.57-1.5h-1.32a.75.75 0 0 1 0-1.5h3a.75.75 0 0 1 .75.75v3a.75.75 0 1 1-1.5 0v-1.06A6.48 6.48 0 0 1 8 14.5a6.47 6.47 0 0 1-4.035-1.404l-.935.934a.75.75 0 0 1-1.06-1.06l11-11a.75.75 0 0 1 1.06 1.06l-.934.935a6.47 6.47 0 0 1 1.349 3.184.75.75 0 1 1-1.488.194 5 5 0 0 0-.93-2.309M3.043 8.657q.061.463.203.895L2.09 10.708a6.5 6.5 0 0 1-.534-1.857.75.75 0 0 1 1.487-.194"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
