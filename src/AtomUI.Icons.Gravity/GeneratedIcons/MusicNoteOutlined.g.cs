// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class MusicNoteOutlined : GravityIcon
{
    public MusicNoteOutlined()
    {
        IconTheme = IconThemeType.Outlined;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new MusicNoteOutlined();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(1, 0.49958214163780212, 13.5, 14.692036628723145);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0073513009535209, 0, 0, 1.0073513009535209, -0.058810407628167027, -0.058810407628167027);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M13 5.46v3.08a3 3 0 0 0-.976 0q-.135.022-.274.055C10.231 8.96 9 10.263 9 11.505s1.231 1.955 2.75 1.59c1.519-.364 2.75-1.667 2.75-2.91q0-.057-.004-.113L14.5 10V1.25a.75.75 0 0 0-.932-.728L6.136 2.38l-.568.142A.75.75 0 0 0 5 3.25v7.291a3 3 0 0 0-.976 0q-.135.021-.274.054C2.231 10.96 1 12.263 1 13.506s1.231 1.955 2.75 1.59c1.519-.364 2.75-1.667 2.75-2.91q0-.057-.003-.113L6.5 12V7.086zm0-1.546V2.211L6.5 3.836v1.703l6.136-1.534zm-8.003 8.127a2 2 0 0 0 .003.144c0 .133-.079.419-.396.754a2.5 2.5 0 0 1-1.204.698c-.47.113-.748.023-.844-.032a.2.2 0 0 1-.047-.036l-.001-.002-.003-.007a.2.2 0 0 1-.005-.054c0-.133.079-.419.396-.754a2.5 2.5 0 0 1 1.204-.698 1.6 1.6 0 0 1 .637-.037q.13.024.26.024m8-2a2 2 0 0 0 .003.144c0 .133-.079.419-.396.754a2.5 2.5 0 0 1-1.204.698c-.47.113-.748.023-.844-.032a.2.2 0 0 1-.047-.036l-.001-.002-.003-.007a.2.2 0 0 1-.005-.054c0-.133.079-.419.396-.754a2.5 2.5 0 0 1 1.204-.698 1.6 1.6 0 0 1 .637-.037q.13.024.26.024"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
