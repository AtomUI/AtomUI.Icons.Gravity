// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CodePullRequestOutlined : GravityIcon
{
    public CodePullRequestOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CodePullRequestOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4985729455947876, 1.4982963800430298, 12.997416496276855, 13.003390312194824);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1028866447114938, 0, 0, 1.1028866447114938, -0.82309315769195024, -0.82309315769195024);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.788 3.121a1.25 1.25 0 1 1-1.076 2.257 1.25 1.25 0 0 1 1.076-2.257M3.5 6.896l-.068-.02a2.751 2.751 0 1 1 3.415-3.533L8.219 1.97A.75.75 0 0 1 9.28 3.03l-.47.47h.69a3 3 0 0 1 1.139.224A3 3 0 0 1 12.5 6.5v2.604l.068.02a2.751 2.751 0 0 1-.818 5.376A2.75 2.75 0 0 1 11 9.104V6.5q0-.116-.017-.225A1.5 1.5 0 0 0 9.5 5h-.69l.47.47a.75.75 0 0 1-1.06 1.06L6.847 5.157a2.74 2.74 0 0 1-.88 1.242c-.282.225-.61.397-.967.497v2.208l.068.02a2.751 2.751 0 1 1-1.568-.02zm-.312 4.195a1.25 1.25 0 0 0-.182.787 1.25 1.25 0 1 0 .182-.787m7.5 0a1.25 1.25 0 0 0-.181.787 1.25 1.25 0 1 0 .18-.787"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
