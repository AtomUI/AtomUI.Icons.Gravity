// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class DatabasesOutlined : GravityIcon
{
    public DatabasesOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new DatabasesOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.5, 1, 15, 14);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1, 0, 0, 1, 0, 0);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13.499 10.04c.492-.252.501-.446.501-.54V5.462c-.796.359-1.848.538-3 .538a9.5 9.5 0 0 1-1.606-.13q.106.293.106.63v3.864c.428.086.932.136 1.5.136 1.107 0 1.971-.19 2.499-.46M8 8.462V12.5c0 .094-.009.288-.501.54-.528.27-1.392.46-2.499.46s-1.971-.19-2.499-.46C2.01 12.788 2 12.594 2 12.5V8.462C2.796 8.821 3.847 9 5 9s2.204-.18 3-.538M8 6.5c0-.093-.009-.288-.501-.54C6.97 5.69 6.107 5.5 5 5.5s-1.971.19-2.499.46C2.01 6.212 2 6.407 2 6.5s.009.288.501.54c.528.27 1.392.46 2.499.46s1.971-.19 2.499-.46C7.99 6.788 8 6.593 8 6.5m-7.5 0C.5 4.833 2.515 4 5 4c.526 0 1.03.037 1.5.112V3.5C6.5 1.833 8.515 1 11 1s4.5.833 4.5 2.5v6c0 1.667-2.015 2.5-4.5 2.5a9.6 9.6 0 0 1-1.5-.112v.612C9.5 14.167 7.485 15 5 15S.5 14.167.5 12.5zm7.5-3c0 .094.009.288.501.54.528.27 1.392.46 2.499.46s1.971-.19 2.499-.46c.492-.252.501-.446.501-.54s-.009-.288-.501-.54C12.97 2.69 12.107 2.5 11 2.5s-1.971.19-2.499.46C8.01 3.212 8 3.406 8 3.5"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
