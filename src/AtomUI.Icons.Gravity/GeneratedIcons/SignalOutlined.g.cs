// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class SignalOutlined : GravityIcon
{
    public SignalOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new SignalOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.49999785423278809, 2.0367331504821777, 15.000003814697266, 11.926235198974609);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.93913054770919913, 0, 0, 0.93913054770919913, 0.48695561832640699, 0.48695561832640699);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.261 2.186c.337-.274.829-.154 1.044.223.197.344.09.777-.21 1.035A5.99 5.99 0 0 0 2 8a5.99 5.99 0 0 0 2.095 4.556c.3.258.407.69.21 1.034-.215.378-.707.498-1.044.223A7.49 7.49 0 0 1 .5 8a7.49 7.49 0 0 1 2.761-5.814m8.434.223c-.197.344-.09.777.21 1.035A5.99 5.99 0 0 1 14 8a5.99 5.99 0 0 1-2.095 4.556c-.3.258-.407.69-.21 1.034.215.378.707.498 1.044.223A7.49 7.49 0 0 0 15.5 8a7.49 7.49 0 0 0-2.761-5.814c-.337-.274-.829-.154-1.044.223M4.759 4.878c.315-.327.837-.21 1.062.184.19.33.097.744-.144 1.04A3 3 0 0 0 5 8c0 .72.254 1.381.677 1.898.241.296.333.71.144 1.04-.225.394-.747.511-1.062.184A4.5 4.5 0 0 1 3.5 8c0-1.213.48-2.313 1.26-3.122m5.42.184c-.19.33-.098.744.144 1.04C10.746 6.618 11 7.28 11 8s-.254 1.381-.677 1.898c-.242.296-.333.71-.144 1.04.225.394.747.511 1.062.184A4.5 4.5 0 0 0 12.5 8c0-1.213-.48-2.313-1.26-3.122-.314-.327-.836-.21-1.061.184M8 9.5a1.5 1.5 0 1 0 0-3 1.5 1.5 0 0 0 0 3"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
