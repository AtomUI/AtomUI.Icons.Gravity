// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class LogoDockerOutlined : GravityIcon
{
    public LogoDockerOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new LogoDockerOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 0, 16.000297546386719, 15);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.94114352542877944, 0, 0, 0.94114352542877944, 0.4708517965697645, 0.4708517965697645);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M5.5 0c-.69 0-1.25.56-1.25 1.25v2h-2C1.56 3.25 1 3.81 1 4.5v2.382l-.06.057L1 7v.002l-.062-.06-.002.001-.003.004-.006.006-.014.014a2 2 0 0 0-.092.105q-.068.082-.147.198a3.3 3.3 0 0 0-.317.611C.154 8.39 0 9.08 0 10v.009a4.9 4.9 0 0 0 1.455 3.46C2.434 14.437 3.825 15 5.5 15c2.071 0 3.785-.59 5.107-1.637.997-.79 1.713-1.796 2.195-2.886a5.3 5.3 0 0 0 .99-.153c.819-.218 1.579-.711 2.05-1.653a1.5 1.5 0 0 0 .081-1.146c-.321-.962-1.12-1.636-2.071-1.877-.24-.95-.915-1.75-1.877-2.071a1.5 1.5 0 0 0-1.146.081c-1.092.546-1.502 1.583-1.668 2.329q-.056.256-.089.513H9V1.25C9 .56 8.44 0 7.75 0zm2 6.5V4.75H5.75V6.5zm-3.25 0V4.75H2.5V6.5zM2 8s-.5.5-.5 2c.01 1.738 1.344 3.5 4 3.5 3.55 0 5.5-2 6.25-4.5C13 9 14 9 14.5 8a1.37 1.37 0 0 0-.655-.756c-.434-.237-1.014-.284-1.595.006.29-.58.243-1.161.006-1.595A1.37 1.37 0 0 0 11.5 5c-1 .5-1 2-1 3zm3.75-4.75H7.5V1.5H5.75zM4.25 9a.75.75 0 0 1 .75.75v1a.75.75 0 0 1-1.5 0v-1A.75.75 0 0 1 4.25 9"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
