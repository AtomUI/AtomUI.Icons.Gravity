# 模块设计：Gallery 图标控件与主题（`GravityGallery.Controls`）

- **对应工程**：[GravityGallery.csproj](../../../gallery/GravityGallery/GravityGallery.csproj) 中的 `Controls/`、`TokenRules/` 与 `ThemeManagerBuilderExtensions.cs`
- **直接依赖**：`AtomUI.Controls`、`AtomUI.Desktop.Controls`；构建期 `AtomUI.Generator`
- **模块验收标准**：尚未单独编写，验收点见本文第 7 节

---

## 1. 模块职责与目录结构

本模块提供目录页使用的两个控件、它们的 Token 与 ControlTheme，以及把这些注册进应用的包入口。它不包含目录数据与查询逻辑。

```text
gallery/GravityGallery/
├── Controls/IconGallery/
│   ├── IconGallery.cs                   # 搜索框、可滚动的图标网格与空状态
│   ├── IconInfoItem.cs                  # 单个图标卡片
│   ├── IconGalleryToken.cs              # 控件 Token 声明
│   └── Themes/                          # IconGalleryTheme、IconInfoItemTheme 及聚合字典
├── TokenRules/
│   └── GenericIconGalleryTokenRule.cs   # Token 取值规则（本设计新增）
└── ThemeManagerBuilderExtensions.cs     # 包入口 UseGalleryControls()
```

## 2. 控件

| 控件 | 职责 |
| --- | --- |
| `IconGallery` | 承载搜索框与图标网格。把 `Category` 与 `IconTheme` 中继到查询会话，把会话的 `ActivatedIconInfos` 与 `HasMatches` 中继回界面。滚动剩余距离不超过 240 时请求加载下一批。结果集变化时滚动位置归零 |
| `IconInfoItem` | 显示一个图标的图形与类名，点击时冒泡 `Clicked` 事件 |

- `IconGallery` 的模板部件是 `PART_SearchInput` 与 `PART_ScrollViewer`。没有匹配结果时显示可本地化的空状态，搜索框保持可用。
- 决策 D12 采用时，`IconInfoItem` 增加 `Tooltip` 属性，主题把它的值设为工具提示。
- 控件所在的 XAML 命名空间是 `https://atomui.net/icons/gravity/icons-gallery`。

不使用 `AtomUI.Toolkits.GalleryBase` 中同名的 `IconGallery`：它写死了 `AntDesignIconCatalog`，无法接入其他图标集。这一点沿用 Material 的设计。

## 3. Token 与取值规则

AtomUI 6.3.0 起，控件 Token 类只做 `partial` 声明，取值由取值规则给出。`IconGalleryToken` 的三个取值与设计语言无关，因此采用通用规则的形态，绑定到 `LanguageDesignToken`，不需要引用任何语言包。

```csharp
[ControlDesignToken]
internal sealed partial class IconGalleryToken : AbstractControlDesignToken
{
    public const string ID = "IconGallery";

    public partial Thickness SearchInputMargin { get; set; }
    public partial double GalleryIconSize { get; set; }
    public partial double InfoItemSize { get; set; }
}

[ControlTokenRule]
internal sealed class GenericIconGalleryTokenRule
    : IControlTokenRule<LanguageDesignToken, IconGalleryToken>
{
    public void Apply(in TokenEvaluationContext<LanguageDesignToken> context,
                      ControlTokenTarget<IconGalleryToken> target)
    {
        var token  = target.Own;
        var global = target.Global;
        token.SearchInputMargin = new Thickness(0,
            global.UniformlyMarginXS, global.UniformlyMarginXS, global.UniformlyMarginXS);
        token.GalleryIconSize = 48;
        token.InfoItemSize    = 150;
    }
}
```

| Token | 取值 | 使用处 |
| --- | --- | --- |
| `SearchInputMargin` | 左 0，其余三边为 `UniformlyMarginXS` | 搜索框与网格的间距 |
| `GalleryIconSize` | 48 | 卡片中图标预览的宽高 |
| `InfoItemSize` | 150 | 卡片的宽高 |
| `EmptyTitleFontSize` | 18 | 空状态标题的字号。全局字号阶里没有 18，所以声明为控件 Token |

约束：

- Token 类或它的属性不是 `partial` 时，生成器报 `ATOMUIGEN049`。
- 取值规则必须写全 `target.Own` 的每个属性，否则报 `ATOMUIGEN050`。

## 4. 主题

| 文件 | 内容 |
| --- | --- |
| `Themes/IconGalleryTheme.axaml` | `IconGallery` 的 ControlTheme |
| `Themes/IconInfoItemTheme.axaml` | `IconInfoItem` 的 ControlTheme |
| `Themes/IconGalleryThemes.axaml` | 聚合以上两个字典 |

主题通过生成的 `{gallery:IconGalleryTokenResource …}` 读取 Token。

主题里的全局 Token 一律经控件自己的 `TokenResource` 读取，例如 `{gallery:IconInfoItemTokenResource PaddingXS}`，而不是 `{atom:SharedTokenResource …}`。经控件读取，取值才会跟随主题切换、动效开关与局部作用域；直接读全局 Token 会被生成器报为 `ATOMUIGEN041`。

属性不写数值字面量，改读等值的 Token，否则报 `ATOMUIGEN045`；只有确实是布局常量时才用 `<!-- layout: 原因 -->` 标注。空状态面板的内边距读 `PaddingLG`，行距读 `SpacingXS`，标题字号没有等值的全局 Token，读控件自己的 `EmptyTitleFontSize`。

按这两条规则修改后，全解决方案在 Debug 与 Release 下全量构建均为 0 警告。修改前后在运行时逐项比对过控件上的取值，12 项全部一致，界面没有变化。

## 5. 包入口与注册

```csharp
public static class ThemeManagerBuilderExtensions
{
    public static IAtomUIBuilder UseGalleryControls(this IAtomUIBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        GeneratedControlTokenRuleRegistration.Register(builder.Theme);
        return PackageMetadata.Definition.Register(builder);
    }
}
```

- 先把取值规则登记到主题构建器，再由生成器产出的 `PackageMetadata.Definition` 声明包入口。
- 两个 ControlTheme 由生成器自动登记，`ThemeBuildOwnerAttribute` 分别指向 `IconGallery` 与 `IconInfoItem`。
- 删除旧的 `GalleryControlThemesProvider`（决策 D6）。在隔离副本中删除它之后，编译与运行时取值都正常；6.3.0 的框架 Gallery 也不再保留这类 Provider。

`CalculateTokenValues` 写法与 `GeneratedControlPackageRegistration` 入口已替换，构建与测试通过。`GalleryControlThemesProvider` 尚未删除（决策 D6）。

## 6. 与应用组合的关系

`UseGalleryControls()` 只登记本包。启用哪一种设计语言由宿主决定，见 [Gallery 应用与页面](../gallery-app/design.md)第 2 节。`GravityGallery` 程序集不得引用语言包，否则生成器报 `ATOMUIGEN053`。

## 7. 验收要点

- 全解决方案 Debug 与 Release 构建 0 错误。
- 应用启动通过主题校验，不出现 `ThemeSchemaException`。
- 无头环境下进入任意一个分类后，主题落到控件上的取值与设计一致：卡片 150、图标预览 48、搜索框边距 `0, 8, 8, 8`、空状态内边距 24 与标题字号 18 等。`IconGalleryThemeTests` 逐项断言这些值。
- 1300×900 与 1040×720 下网格有非零的可视区域；内容超出时垂直滚动条可见；表头与搜索框不遮挡网格的指针输入。

## 8. 明确不支持范围

- 不为具体的设计语言提供专属取值。
- 不改动 `AtomUI.Controls.Icon` 的主题。
