# 模块设计：图标包（`AtomUI.Icons.Gravity`）

- **对应工程**：[AtomUI.Icons.Gravity.csproj](../../../src/AtomUI.Icons.Gravity/AtomUI.Icons.Gravity.csproj)
- **直接依赖**：`AtomUI.Core`
- **生成来源**：[上游资产与代码生成器](../icon-generator/design.md)
- **模块验收标准**：尚未单独编写，验收点见本文第 7 节

---

## 1. 模块职责与目录结构

本模块是发布到 NuGet 的图标包：816 个矢量图标类、按名称创建图标的提供器，以及图标目录。它是仓库里唯一的发布物，不依赖 Gallery。

```text
src/AtomUI.Icons.Gravity/
├── AtomUI.Icons.Gravity.csproj
├── GravityIcon.cs                    # 所有图标的基类
├── GravityIconProvider.cs            # IconProvider<GravityIconKind>
├── GravityIconCatalog.g.cs           # 图标目录（生成）
├── GravityIconProvider.Factory.g.cs  # 按 Kind 创建实例的工厂（生成）
├── GeneratedIcons/                   # GravityIconKind.g.cs 与 816 个图标类（生成）
└── Properties/AssemblyInfo.cs        # XAML 命名空间
```

## 2. 公开 API

| 类型 | 说明 |
| --- | --- |
| `GravityIcon` | 所有图标的抽象基类，继承 `AtomUI.Controls.Icon` |
| `GravityIconKind` | 枚举，816 个成员，成员名与图标类名相同 |
| `GravityIconProvider` | `IconProvider<GravityIconKind>`，可在 XAML 中用作标记扩展 |
| `GravityIconCatalog` | `GetIcons()` 返回 `IReadOnlyList<GravityIconInfo>`，每项含 `Name`、`ThemeType`、`Kind`、`IconType`、`Creator` |
| 816 个图标类 | 每个图标一个公开类，如 `AlarmOutlined`，有无参构造函数 |

XAML 命名空间为 `https://atomui.net/icons/gravity`，前缀为 `gravity-icons`。

```xml
xmlns:gravity-icons="https://atomui.net/icons/gravity"

<atom:Button Icon="{gravity-icons:GravityIconProvider Kind=AlarmOutlined}" />
<gravity-icons:AlarmOutlined Width="16" Height="16" />
```

## 3. 渲染模型

- 每个图标类在构造时设置 `IconTheme` 与 `ViewBox`，并持有一份静态的绘制指令列表。
- 每条指令都是 `PathDrawingInstruction`：`Opacity` 为 1，`FillBrush` 为 `IconBrushType.Fill`，`Data` 是带显式填充规则的 `StreamGeometry`。
- 画刷来自 `Icon` 基类的 `FillBrush`、`SecondaryFillBrush` 等属性，由 AtomUI 的 Icon 主题按设计语言提供。图标随主题的明暗与前景色变化，自身不含颜色。
- `CalculateGlobalGeometryMatrix()` 返回单位矩阵，图形按 `viewBox` 的原比例绘制。Material 用 zoom-to-fit 让图形充满视图框；Gravity 图标在 16px 网格上自带留白，官方渲染器也按 `viewBox` 原样绘制，缩放会改变图标之间的视觉比例。
- 每个图标类重写 `CreateInstance()`，克隆不依赖反射。工厂按 64 个一组分块创建实例，并带有 `DynamicallyAccessedMembers` 与 `UnconditionalSuppressMessage` 注解，兼容 NativeAOT 与裁剪。
- 图标全部由填充路径构成，`StrokeWidth` 对它没有影响。

生成的每个图标类还带有三项几何元数据：`GeneratedViewBox`、`GeneratedGeometryBounds` 与 `GeneratedZoomMatrix`。运行时当前不读取它们，本设计保留现状，不做清理。

## 4. 本设计的变更

### 4.1 画布裁剪

上游有 2 个图标的路径略越出 `viewBox`：`BucketOutlined` 与 `FunnelXmarkOutlined`。SVG 渲染器按 `viewBox` 裁掉越界的部分，而 `Icon` 的渲染没有裁剪，越界的部分会画到控件之外。

`GravityIcon` 增加一个内部开关并重写 `Render`。生成器只对越界的图标类打开这个开关，其余 814 个图标不产生额外的裁剪。

```csharp
internal virtual bool ClipsToCanvas => false;

public override void Render(DrawingContext context)
{
    if (!ClipsToCanvas)
    {
        base.Render(context);
        return;
    }

    using var clip = context.PushClip(new Rect(Bounds.Size));
    base.Render(context);
}
```

### 4.2 次级填充画刷的回退

上游有 5 个图标用固定的红色 `#f33` 画通知圆点：`BellDot`、`CircleQuestionDot`、`CommentsDot`、`GearDot`、`WalletDot`。生成器为这些路径生成使用 `IconBrushType.SecondaryFill` 的指令（见上游资产与代码生成器第 7.3 节）。

`SecondaryFillBrush` 默认为空，直接使用会画不出圆点。`GravityIcon` 重写 `FindIconBrush`，在该画刷未设置时回退为红色：

```csharp
private static readonly IBrush AccentBrush = new ImmutableSolidColorBrush(Color.FromRgb(0xFF, 0x33, 0x33));

public override IBrush? FindIconBrush(IconBrushType brushType)
{
    var brush = base.FindIconBrush(brushType);
    return brush is null && brushType == IconBrushType.SecondaryFill ? AccentBrush : brush;
}
```

这样默认效果与上游一致，用户在实例上或样式里设置 `SecondaryFillBrush` 即可改色。

### 4.3 测试可见性

`Properties/AssemblyInfo.cs` 增加 `[assembly: InternalsVisibleTo("GravityGallery.Tests")]`，供包契约测试读取 `ClipsToCanvas` 与生成的包围盒。这不改变公开 API。

### 4.4 包内许可通知

上游 MIT 许可要求随副本附带版权声明与许可声明，而现在编译后的程序集里只有生成源码的注释带有这些信息。

在仓库根目录新增 `THIRD-PARTY-NOTICES.md`，写明上游地址、版本、commit、MIT 全文与 `Copyright (c) 2022 YANDEX LLC`，并由 `build/PackageMetaInfo.props` 打进包。

## 5. NuGet 包内容

| 条目 | 说明 |
| --- | --- |
| `AtomUI.Icons.Gravity.nuspec` | 依赖只有 `AtomUI.Core`，版本等于 `AtomUIVersion` |
| `lib/net10.0/AtomUI.Icons.Gravity.dll` 与 `lib/net8.0/AtomUI.Icons.Gravity.dll` | Release 构建的两个目标框架；Debug 只构建 `net10.0` |
| `LICENSE` | 本仓的 Apache 2.0 许可 |
| `THIRD-PARTY-NOTICES.md` | 上游许可通知（本设计新增） |
| `README.nuget.md`、`logo.png` | 包说明与包图标 |

包内容按白名单校验，由 `scripts/release/validate_nupkg.py` 执行。新增条目必须同步加入白名单及其测试，否则发布被拦截。

## 6. 版本

`GravityVersion` 等于 `AtomUIVersion`，跟 AtomUI 最新稳定版锁步。图标的新增是次版本变更；图标的删除或改名是破坏性变更。

## 7. 验收要点

- 图标包工程 Debug 与 Release 构建 0 警告 0 错误。
- 816 个 `GravityIconKind` 都能经 `GravityIconProvider` 创建出对应类型的实例。
- `BucketOutlined` 与 `FunnelXmarkOutlined` 的 `ClipsToCanvas` 为 `true`，其余图标为 `false`。
- 5 个红点图标在未设置 `SecondaryFillBrush` 时画出红色圆点；设置后使用所设的画刷。
- `dotnet pack` 产出的包只包含第 5 节列出的条目，`validate_nupkg.py` 通过，`THIRD-PARTY-NOTICES.md` 中的版本与 commit 与 `upstream.json` 一致。
- 一个临时的本地包源消费者工程能还原、编译，并用 XAML 与代码两种方式引用代表性图标。

## 8. 明确不支持范围

- 不提供 16px 以外的专用尺寸。上游只有一套 16px 网格的源图，其他显示尺寸靠缩放。
- 不产生 `Rounded`、`Sharp`、`TwoTone`、`MultiColor` 这些 `IconThemeType` 取值。
- 不支持逐图标的描边粗细与线帽定制，图标没有描边。
- 不提供 zoom-to-fit 开关。
