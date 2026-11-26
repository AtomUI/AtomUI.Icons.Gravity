// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CodePullRequestArrowRightOutlined : GravityIcon
{
    public CodePullRequestArrowRightOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CodePullRequestArrowRightOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.5004333257675171, 1.5005874633789062, 11.998907089233398, 13.018125534057617);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0297278849285159, 0, 0, 1.0297278849285159, -0.23782307942812686, -0.23782307942812686);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M6.53 5.788A2.77 2.77 0 0 1 5 6.896V9.25a.75.75 0 0 1-1.5 0V6.896h-.003a2.7 2.7 0 0 1-.785-.366 2.75 2.75 0 1 1 4.134-3.188L8.22 1.97a.75.75 0 0 1 1.06 1.06l-.47.47h.69a3 3 0 0 1 1.139.224A3 3 0 0 1 12.5 6.5v.75a.75.75 0 0 1-1.5 0V6.5q0-.116-.017-.225A1.5 1.5 0 0 0 9.5 5h-.69l.47.47a.75.75 0 0 1-1.06 1.06L6.847 5.157v.001a2.7 2.7 0 0 1-.317.63M5.5 4.25a1.25 1.25 0 1 0-2.5 0 1.25 1.25 0 0 0 2.5 0m4.97 6.53a.75.75 0 1 1 1.06-1.06l1.75 1.75a.75.75 0 0 1 0 1.06l-1.75 1.75a.75.75 0 1 1-1.06-1.06l.47-.47H3.25a.75.75 0 0 1 0-1.5h7.69z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
