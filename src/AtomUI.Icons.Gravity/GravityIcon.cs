using AtomUI.Controls;
using Avalonia;
using Avalonia.Media;

namespace AtomUI.Icons.Gravity;

public class GravityIcon : Icon
{
    internal virtual Rect GeneratedViewBox => default;
    internal virtual Rect GeneratedGeometryBounds => default;
    internal virtual Matrix GeneratedZoomMatrix => Matrix.Identity;

    protected override Matrix CalculateGlobalGeometryMatrix()
    {
        // Gravity 图标在 16px 网格上的留白是图标设计的一部分，按上游比例渲染，不做 zoom-to-fit。
        // 生成的包围盒与缩放矩阵随图标保留，需要改回缩放时，把这里换成 MaterialIcon 的实现即可。
        return Matrix.Identity;
    }
}
