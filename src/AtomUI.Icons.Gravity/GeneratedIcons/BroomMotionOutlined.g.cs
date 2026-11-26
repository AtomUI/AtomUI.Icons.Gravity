// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class BroomMotionOutlined : GravityIcon
{
    public BroomMotionOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new BroomMotionOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0000001192092896, 1.0005338191986084, 13.508197426795959, 14.394028663635254);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.98274499895361001, 0, 0, 0.98274499895361001, 0.13804000837111996, 0.13804000837111996);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M10.037 1.027a.75.75 0 0 1 .921.526l1.303 4.767c1.425.499 2.444 1.895 2.215 3.51-.238 1.674-.608 2.954-.922 3.825-.158.434-.3.767-.408.995a7 7 0 0 1-.128.263l-.04.072-.011.021-.004.008-.002.003h-.001a.75.75 0 0 1-.764.369L3.49 14.053c-.866-.133-1.088-1.236-.43-1.73l.31-.24c.794-.642 2.066-1.844 2.911-3.49.774-1.506 2.406-2.872 4.34-2.585l-1.11-4.06a.75.75 0 0 1 .527-.921m.372 6.466c-1.06-.162-2.183.596-2.795 1.786-.782 1.523-1.867 2.695-2.724 3.471l4.152.636 1.312-1.61a.434.434 0 0 1 .766.34l-.238 1.551.991.152c.077-.174.171-.399.27-.673.283-.78.625-1.962.847-3.528.132-.929-.553-1.814-1.58-1.971z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F1 M2.875 8.281a.75.75 0 1 1 0 1.5.75.75 0 0 1 0-1.5m-1.125-3a.75.75 0 1 1 0 1.5.75.75 0 0 1 0-1.5m3.64-2a.75.75 0 1 1 0 1.5.75.75 0 0 1 0-1.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
