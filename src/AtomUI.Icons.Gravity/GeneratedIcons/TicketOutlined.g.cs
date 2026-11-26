// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class TicketOutlined : GravityIcon
{
    public TicketOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new TicketOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0.75184410810470581, 0.75184398889541626, 14.496525764465332, 14.496312141418457);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0492777823930608, 0, 0, 1.0492777823930608, -0.39422225914448639, -0.39422225914448639);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M11.091 2.318a.986.986 0 0 1 .106 1.485L11 4a.707.707 0 0 0 1 1l.197-.197a1 1 0 0 1 .288-.2.986.986 0 0 1 1.197.306l1.243 1.658c.575.766.36 1.862-.461 2.355a16.16 16.16 0 0 0-5.542 5.542 1.616 1.616 0 0 1-2.355.461l-1.658-1.243a.986.986 0 0 1-.106-1.485L5 12a.707.707 0 0 0-1-1l-.197.197a1 1 0 0 1-.288.2.986.986 0 0 1-1.197-.306L1.075 9.433a1.616 1.616 0 0 1 .461-2.355 16.16 16.16 0 0 0 5.542-5.542 1.616 1.616 0 0 1 2.355-.461zm-2.558-.043 1.201.9a2.208 2.208 0 0 0 3.09 3.09l.901 1.202a.116.116 0 0 1-.033.169 17.66 17.66 0 0 0-6.056 6.056.116.116 0 0 1-.17.033l-1.2-.9a2.208 2.208 0 0 0-3.09-3.09l-.901-1.202a.116.116 0 0 1 .033-.168 17.66 17.66 0 0 0 6.057-6.057.116.116 0 0 1 .168-.033M7.53 6.47a.75.75 0 1 0-1.06 1.06l2 2a.75.75 0 0 0 1.06-1.06z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
