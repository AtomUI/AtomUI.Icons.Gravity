// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.Gravity;

public class VolumeSlashFilled : GravityIcon
{
    public VolumeSlashFilled()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 16, 16);
    }

    public override Icon CreateInstance()
    {
        return new VolumeSlashFilled();
    }

    internal override Rect GeneratedViewBox => new Rect(0, 0, 16, 16);
    internal override Rect GeneratedGeometryBounds => new Rect(0, 1.7687100172042847, 16, 12.490005493164062);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.90185127290815426, 0, 0, 0.90185127290815426, 0.78518981673476596, 0.78518981673476596);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            Data = StreamGeometry.Parse("F0 M3.03 1.97a.75.75 0 0 0-1.06 1.06L3.94 5H1.5A1.5 1.5 0 0 0 0 6.5v3A1.5 1.5 0 0 0 1.5 11h3l2.586 2.586a1.414 1.414 0 0 0 2.414-1V10.56l3.47 3.47a.75.75 0 1 0 1.06-1.061zm8.459 6.317 1.265 1.265C12.915 9.064 13 8.542 13 8a4.98 4.98 0 0 0-.975-2.967c-.247-.334-.727-.33-1.02-.038s-.284.765-.06 1.113a3.5 3.5 0 0 1 .544 2.179m2.422 2.422 1.117 1.117C15.648 10.689 16 9.386 16 8c0-1.94-.69-3.717-1.838-5.102-.264-.32-.743-.317-1.035-.024-.293.293-.29.765-.032 1.09A6.47 6.47 0 0 1 14.5 8c0 .967-.21 1.884-.59 2.709m-7.56-7.56L9.5 6.298V3.414a1.414 1.414 0 0 0-2.414-1z"),
        }
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}
