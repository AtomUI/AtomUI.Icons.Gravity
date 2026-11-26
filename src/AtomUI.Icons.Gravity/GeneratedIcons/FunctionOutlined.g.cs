// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class FunctionOutlined : GravityIcon
{
    public FunctionOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new FunctionOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.033164869993925095, 2.0912659168243408, 15.646034240722656, 11.817468643188477);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.91692311728475184, 0, 0, 0.91692311728475184, 0.66461506172198526, 0.66461506172198526);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M4.312 4.29a.764.764 0 0 1 1.103-.62.75.75 0 1 0 .67-1.34 2.264 2.264 0 0 0-3.268 1.836L2.706 5.5H1.75a.75.75 0 0 0 0 1.5h.83l-.392 4.71a.764.764 0 0 1-1.103.62.75.75 0 0 0-.67 1.34 2.264 2.264 0 0 0 3.268-1.836L4.086 7H5.25a.75.75 0 1 0 0-1.5H4.21zm6.014 2.23a.75.75 0 0 0-1.152.96l.85 1.02-.85 1.02a.75.75 0 0 0 1.152.96L11 9.672l.674.808a.75.75 0 0 0 1.152-.96l-.85-1.02.85-1.02a.75.75 0 0 0-1.152-.96L11 7.328zM8.02 4.55a.75.75 0 0 1 .43.969l-.145.378a7.25 7.25 0 0 0 0 5.205l.145.378a.75.75 0 0 1-1.4.539l-.145-.378a8.75 8.75 0 0 1 0-6.282l.145-.378a.75.75 0 0 1 .97-.431m5.961 0a.75.75 0 0 1 .97.43l.145.379a8.75 8.75 0 0 1 0 6.282l-.146.378a.75.75 0 1 1-1.4-.538l.146-.379a7.25 7.25 0 0 0 0-5.205l-.146-.378a.75.75 0 0 1 .431-.97"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
