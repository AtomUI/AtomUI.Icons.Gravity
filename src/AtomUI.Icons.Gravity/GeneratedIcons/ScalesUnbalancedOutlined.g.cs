// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ScalesUnbalancedOutlined : GravityIcon
{
    public ScalesUnbalancedOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ScalesUnbalancedOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.094366602599620819, 0.25044497847557068, 15.809267044067383, 14.249554634094238);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.92446712532116593, 0, 0, 0.92446712532116593, 0.60426299743067258, 0.60426299743067258);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.983.843a.75.75 0 0 1-.576.89l-4.657.998V13h2.5a.75.75 0 0 1 0 1.5h-6.5a.75.75 0 0 1 0-1.5h2.5V3.053l-4.343.93a.75.75 0 1 1-.314-1.466l10.5-2.25a.75.75 0 0 1 .89.576m-2.34 6.725.007.018a1.454 1.454 0 0 0 2.7 0l.007-.018L13 4.854zM13 3c-.46 0-.88.26-1.085.67L10.2 7.099a1 1 0 0 0-.034.819l.09.226a2.954 2.954 0 0 0 5.486 0l.09-.226a1 1 0 0 0-.034-.819l-1.714-3.427A1.21 1.21 0 0 0 13 3M1.643 9.568l.007.018a1.454 1.454 0 0 0 2.7 0l.007-.018L3 6.854zM3 5c-.46 0-.88.26-1.085.67L.2 9.099a1 1 0 0 0-.034.819l.09.226a2.954 2.954 0 0 0 5.486 0l.09-.226a1 1 0 0 0-.034-.819L4.085 5.671A1.21 1.21 0 0 0 3 5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
