// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoGitlabOutlined : GravityIcon
{
    public LogoGitlabOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoGitlabOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1.000213623046875, 0.99960297346115112, 14.00057315826416, 14.000396728515625);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0665547594292055, 0, 0, 1.0665547594292055, -0.53243807543364419, -0.53243807543364419);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M9.357 7H6.643l1.08 6.267a.28.28 0 0 0 .554 0zM4.511 3.465l-.153-.691a.35.35 0 0 0-.684.007L2.522 8.537a1.14 1.14 0 0 0 .39 1.103l3.11 2.593zm5.466 8.768 3.111-2.593a1.14 1.14 0 0 0 .39-1.103l-1.152-5.756a.35.35 0 0 0-.684-.007l-.153.692zm-8.026-1.44 4.493 3.743a2 2 0 0 0 1.28.464h.552a2 2 0 0 0 1.28-.464l4.493-3.743a2.64 2.64 0 0 0 .9-2.55l-1.152-5.756a1.85 1.85 0 0 0-3.619-.039L9.5 5.5h-3l-.678-3.052a1.85 1.85 0 0 0-3.62.039l-1.15 5.756a2.64 2.64 0 0 0 .9 2.55"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
