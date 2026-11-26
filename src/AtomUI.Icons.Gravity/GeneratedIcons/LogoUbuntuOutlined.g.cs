// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoUbuntuOutlined : GravityIcon
{
    public LogoUbuntuOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoUbuntuOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.0017381906509399, 1.0002515316009521, 13.613882064819336, 13.999478340148926);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0400524532545967, 0, 0, 1.0400524532545967, -0.32041962603677376, -0.32041962603677376);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.034 3.902a1.5 1.5 0 1 0-2.03-1.293A5.7 5.7 0 0 0 9 2.25a5.8 5.8 0 0 0-1.681.25c-.427.13-.58.63-.356 1.017.195.333.607.46.982.365a4.26 4.26 0 0 1 5.144 2.954c.105.372.423.664.81.664.446 0 .801-.384.699-.82a5.74 5.74 0 0 0-1.564-2.778m-5.09 8.216c-.373-.096-.786.032-.98.365-.226.386-.072.887.355 1.017A5.8 5.8 0 0 0 9 13.75c.705 0 1.38-.127 2.004-.359L11 13.5a1.5 1.5 0 1 0 2.034-1.402 5.74 5.74 0 0 0 1.564-2.779c.102-.435-.253-.819-.7-.819-.386 0-.704.292-.81.664a4.25 4.25 0 0 1-5.143 2.954M5.937 5.055c.268-.278.359-.7.165-1.033-.226-.386-.737-.499-1.061-.19A5.74 5.74 0 0 0 3.38 6.784a1.5 1.5 0 1 0 0 2.432 5.74 5.74 0 0 0 1.66 2.953c.325.308.836.195 1.062-.191.194-.333.103-.755-.165-1.033A4.24 4.24 0 0 1 4.75 8c0-1.143.452-2.181 1.186-2.945"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
