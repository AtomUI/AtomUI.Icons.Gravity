// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CircleQuestionDotOutlined : GravityIcon
{
    public CircleQuestionDotOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CircleQuestionDotOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0018769502639771, 1.0001229047775269, 14, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0664085250118309, 0, 0, 1.0664085250118309, -0.53126820009464737, -0.53126820009464737);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M2.5 8a5.5 5.5 0 0 1 6.38-5.43.75.75 0 0 0 .24-1.48 7 7 0 1 0 5.792 5.792.75.75 0 1 0-1.482.237q.07.43.07.881a5.5 5.5 0 1 1-11 0m3.94-3.46c.43-.354.994-.565 1.56-.565 1.217 0 2.34.82 2.34 2.14 0 .377-.079.745-.298 1.1-.208.339-.513.614-.875.867-.217.153-.326.257-.379.328-.038.052-.038.07-.038.089a.75.75 0 0 1-1.5 0c0-.794.544-1.286 1.056-1.645.28-.196.402-.332.46-.425a.54.54 0 0 0 .073-.313c0-.3-.243-.641-.839-.641a1 1 0 0 0-.608.224c-.167.137-.231.286-.231.417a.75.75 0 1 1-1.5 0c0-.673.345-1.22.78-1.577M9 11a1 1 0 1 1-2 0 1 1 0 0 1 2 0"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M12.5 5.5a2 2 0 1 0 0-4 2 2 0 0 0 0 4"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
