// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class CodePullRequestCheckOutlined : GravityIcon
{
    public CodePullRequestCheckOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new CodePullRequestCheckOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4989999532699585, 1.4999998807907104, 13.750690460205078, 13.001791954040527);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.000150710702866, 0, 0, 1.000150710702866, -0.0012056856229278878, -0.0012056856229278878);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.967 6.399a2.77 2.77 0 0 0 .88-1.24v-.002L8.22 6.53a.75.75 0 0 0 1.06-1.06L8.81 5h.69q.118 0 .232.018A1.5 1.5 0 0 1 11 6.5v1.75a.75.75 0 0 0 1.5 0V6.5a3 3 0 0 0-3-3h-.69l.47-.47a.75.75 0 0 0-1.06-1.06L6.847 3.343A2.755 2.755 0 0 0 4.25 1.5a2.75 2.75 0 0 0-.75 5.396v2.208a2.751 2.751 0 1 0 1.5 0V6.896c.357-.1.685-.272.967-.497m4.063 4.07a.75.75 0 1 0-1.06 1.061l2 2a.75.75 0 0 0 1.13-.08l3-4a.75.75 0 0 0-1.2-.9l-2.481 3.308zm-6.842.622A1.25 1.25 0 0 0 3 11.75a1.25 1.25 0 1 0 .188-.659m1.6-7.97a1.25 1.25 0 1 1-1.076 2.257 1.25 1.25 0 0 1 1.076-2.257"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
