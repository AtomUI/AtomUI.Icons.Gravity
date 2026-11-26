// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class ThumbsUp2Outlined : GravityIcon
{
    public ThumbsUp2Outlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new ThumbsUp2Outlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.0018943252507597208, 0.99809545278549194, 16.036785125732422, 14.478323936462402);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.96380087330249764, 0, 0, 0.96380087330249764, 0.28959301358001888, 0.28959301358001888);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 m13.345 2.978-.135.609-.33 1.5h1.158q.19 0 .37.033a2 2 0 0 1 1.593 2.352l-.26 1.321a4 4 0 0 1-4.322 3.21 4 4 0 0 1-4.286 2.767l-3.984-.473-.48-6.352 2.813-4.564a1.854 1.854 0 0 1 3.427.826l1.452-2.418a1.627 1.627 0 0 1 2.984 1.189m-4.38 4.06.215-.37 2.467-4.106a.127.127 0 0 1 .233.092l-.465 2.11-.403 1.823h3.027a.5.5 0 0 1 .49.596l-.26 1.321a2.5 2.5 0 0 1-2.528 2.018l.219-1.09A2 2 0 0 0 10 7.037H8.964M4.55 12.952l2.759.328a2.5 2.5 0 0 0 2.745-1.99l.434-2.155a.5.5 0 0 0-.49-.599H6.476l.414-1.83.515-2.275a.354.354 0 0 0-.646-.264L4.2 8.318zM.695 7.651a.75.75 0 0 1 .804.691l.478 6.353a.75.75 0 0 1-1.495.112L.004 8.455a.75.75 0 0 1 .691-.804"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
