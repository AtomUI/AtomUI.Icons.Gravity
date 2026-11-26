// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CodeMergeOutlined : GravityIcon
{
    public CodeMergeOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CodeMergeOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4978969097137451, 1.4978970289230347, 13.00310230255127, 13.003894805908203);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1032516340105669, 0, 0, 1.1032516340105669, -0.82601307208453534, -0.82601307208453534);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.312 11.091a1.25 1.25 0 1 0-2.123 1.316 1.25 1.25 0 0 0 2.123-1.316M3.188 4.909a1.25 1.25 0 1 1 2.125-1.318 1.25 1.25 0 0 1-2.125 1.318M5 6.896v2.208a2.751 2.751 0 1 1-1.5 0V6.896A2.751 2.751 0 1 1 6.896 3.5H9.5a3 3 0 0 1 3 3v2.604a2.751 2.751 0 1 1-1.5 0V6.5A1.5 1.5 0 0 0 9.5 5H6.896A2.76 2.76 0 0 1 5 6.896m7.812 4.195a1.25 1.25 0 1 1-2.125 1.318 1.25 1.25 0 0 1 2.125-1.318"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
