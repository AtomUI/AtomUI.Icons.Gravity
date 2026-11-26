# 模块设计：Gallery 应用与页面（`GravityGallery` / `GravityGallery.Desktop`）

- **对应工程**：[GravityGallery.csproj](../../../gallery/GravityGallery/GravityGallery.csproj)、[GravityGallery.Desktop.csproj](../../../gallery/GravityGallery.Desktop/GravityGallery.Desktop.csproj)
- **直接依赖**：`AtomUI.Toolkits.GalleryBase`、`AtomUI.Desktop.Controls`、`AtomUI.Icons.AntDesign`（外壳与导航图标）。桌面宿主另引用 `AtomUI.DesignLanguages.AntDesign` 与 `AtomUI.Desktop.Controls.Themes.AntDesign`
- **外壳基线**：AtomUI 6.3.0 的 `AtomUI.Toolkits.GalleryBase`
- **模块验收标准**：尚未单独编写，验收点见本文第 9 节

---

## 1. 模块职责与目录结构

本模块是应用的组合根、产品配置与各个页面。外壳（标题栏、可折叠侧边栏、页脚）来自 GalleryBase；标题栏的菜单由本模块在 `WorkspaceWindow` 中声明，其中 Theme 菜单的子菜单由 `GalleryThemeMenu` 填充（见第 5.1 节）。

```text
gallery/
├── GravityGallery/                         # 共享库
│   ├── BaseGalleryApplication.cs           # 包级 AtomUI 配置 ConfigureCore
│   ├── GravityGalleryModule.cs             # 品牌、导航与路由
│   ├── GalleryProjectLinks.cs
│   ├── GalleryVersionInfo.cs
│   ├── ThemeManagerBuilderExtensions.cs    # 见“Gallery 图标控件与主题”模块
│   ├── Features/
│   │   ├── Overview/                       # 概览页
│   │   ├── Community/                      # 社区页
│   │   └── IconCatalog/                    # 目录页的视图
│   └── Workspace/                          # GalleryBase 外壳适配与标题栏 Theme 菜单
│       ├── GalleryThemeMenu.cs             # 运行时填充 Theme 菜单的子菜单，移植自 AtomUI Gallery
│       ├── GalleryBrandSwatches.cs         # 品牌色色板
│       ├── GalleryNeutralSwatches.cs       # 中性色色板
│       ├── ViewModels/                     # WorkspaceWindowViewModel、CaseNavigationViewModel
│       └── Views/                          # WorkspaceWindow、CaseNavigation
└── GravityGallery.Desktop/                 # 桌面宿主
    ├── GalleryApplication.cs               # 应用组合根
    └── Program.cs
```

## 2. 应用组合

AtomUI 6.3.0 起必须显式启用设计语言，并为每个已启用的控件包登记它在该语言下的取值包。共享库声明了控件 Token，生成器禁止它引用语言包，所以语言只能由宿主启用。

```csharp
// GravityGallery：包级配置，不含任何设计语言
protected internal static void ConfigureCore(IAtomUIBuilder builder)
{
    builder.WithApplicationId("GravityGallery");
    builder.UseUserThemeDirectory();
    builder.UseLanguages(GalleryLanguageDefaults.Resolve(CultureInfo.CurrentUICulture),
        [LanguageTags.EnUS, LanguageTags.ZhCN, LanguageTags.ZhTW, LanguageTags.PtBR]);
    builder.UseAlibabaSansFont();
    builder.UseDesktopControls();
    builder.UseGalleryBase(GravityGalleryModule.Configure);
    builder.UseGalleryControls();
}

// 宿主：GravityGallery.Desktop 与测试工程
BaseGalleryApplication.ConfigureCore(builder);
builder.UseAntDesign(ant =>
{
    ant.WithDefaultTheme(AntDesignThemes.DaybreakBlue);
    ant.AddDesktopControls();
});
builder.WithInitialDesignLanguage<AntDesignLanguage>();
```

- `AddDesktopControls()` 同时登记通用控件与桌面控件的 Ant Design 取值。缺少它时启动抛出 `ThemeSchemaException`，并列出所有没有取值规则的控件。
- `IThemeManager.DEFAULT_THEME_ID` 在 6.3.0 中已移除，`WithInitialTheme` 改为接收 `ThemeSelection`。
- 测试工程的无头宿主必须与桌面宿主使用同一组合，见[测试](../testing/design.md)第 2 节。

## 3. 模块配置

`GravityGalleryModule` 拥有不可变的产品配置：品牌与项目链接、页脚版本、有序的导航节点、默认路由 `Overview`，以及各个分类的路由工厂。创建配置时不实例化图标控件。

| 导航项 | 内容 |
| --- | --- |
| `Overview` | 概览页，默认路由 |
| `Community` | 社区页 |
| `Categories` | 分组节点，默认展开，不可路由。决策 D8 采用时首项为 `All`，其后是 28 个分类 |

- 页脚的版本文字来自编译进程序集的 `GravityVersion` 元数据，不在代码里写死。
- 分类的路由键就是分类键。每个分类路由到同一个目录页，只传入分类。
- 每个分类必须同时有本地化表头与导航图标，缺任意一项时配置构建抛出异常。这是有意的约束，与 Material 相同。

导航图标沿用 Ant Design（决策 D10）。每个分类一个，互不重复，全部为 `Outlined`：

行的顺序就是导航中的顺序。

| 分类 | 导航图标 |
| --- | --- |
| `Arrows` | `ArrowsAltOutlined` |
| `Layout` | `LayoutOutlined` |
| `Text` | `FontSizeOutlined` |
| `Status` | `InfoCircleOutlined` |
| `Files` | `FolderOutlined` |
| `Shapes` | `BorderOutlined` |
| `Development` | `CodeOutlined` |
| `Editor` | `FormOutlined` |
| `People` | `UserOutlined` |
| `Media` | `PlayCircleOutlined` |
| `Brands` | `GoogleOutlined` |
| `Charts` | `BarChartOutlined` |
| `Commerce` | `ShoppingOutlined` |
| `Communication` | `MessageOutlined` |
| `Games` | `TrophyOutlined` |
| `Devices` | `LaptopOutlined` |
| `Maps` | `EnvironmentOutlined` |
| `Tools` | `ToolOutlined` |
| `Math` | `NumberOutlined` |
| `Security` | `SafetyOutlined` |
| `Cloud` | `CloudServerOutlined` |
| `Finance` | `DollarOutlined` |
| `Health` | `HeartOutlined` |
| `Transport` | `CarOutlined` |
| `Weather` | `CloudOutlined` |
| `Time` | `ClockCircleOutlined` |
| `Food` | `CoffeeOutlined` |
| `Unassigned` | `QuestionCircleOutlined` |
| `All`（决策 D8 采用时，排在 `Arrows` 之前） | `ProfileOutlined` |

## 4. 页面

### 4.1 概览页

纵向滚动、居中的落地页，内容依次是横幅、安装卡片（带 `.NET 8` 与 `.NET 10` 标签）、三种安装命令及各自的复制按钮、快速链接。

- 横幅是 `Assets/atomui-gravity-icons-banner.webp`，规格与 Material 相同，为 1536×512 的 WebP。目前使用一张过渡素材，正式素材待提供（决策 D11）。
- 安装命令里的包名与版本来自 `GalleryVersionInfo.Version`。
- “浏览图标”快速链接指向版本分支上的图标包目录，即 `/tree/release/6.0/src/AtomUI.Icons.Gravity`。开发不在 `main` 上，指向 `main` 的链接会失效。

### 4.2 社区页

项目说明与 GitHub、NuGet 链接。链接统一取自 `GalleryProjectLinks`。结构与 Material 相同。

### 4.3 目录页

1. 表头：左侧是本地化的分类标题与结果数，右侧是图标主题选择器。
2. 搜索框。
3. 占满剩余高度的图标网格。

- 图标主题选择器只有 `Outlined` 与 `Filled` 两项，默认 `Outlined`（决策 D7）。Material 的五项选择器里，`Rounded`、`Sharp`、`TwoTone` 对 Gravity 恒为空。它选的是图标风格，与标题栏的 Theme 菜单无关。
- 内容宽度较窄时，选择器换行到标题下方，不压缩标签，也不挤占网格。

## 5. 外壳适配与共享状态

- `WorkspaceWindow`、`WorkspaceWindowViewModel` 与 `CaseNavigation` 沿用 Material 对 GalleryBase 的适配，不重复实现导航渲染、页脚布局与响应式侧边栏。
- 工作区里唯一的 Gravity 专属状态是图标主题 `IconTheme`，默认值改为 `IconThemeType.Outlined`（决策 D7）。
- 侧边栏头部的动作位留给 GalleryBase 的折叠按钮，图标主题选择器不占用它。

### 5.1 标题栏 Theme 菜单

Theme 菜单与 AtomUI 6.3.0 的 Gallery 对齐。Material 沿用的是 6.2 时代的四项开关：`Dark Mode` 是一个复选框，也没有主题色的入口。

| 顺序 | 菜单项 | 行为 |
| --- | --- | --- |
| 1 | Design Language | 子菜单，列出已启用的设计语言，单选。Gravity 只启用了 `AntDesign`，所以只有一项 |
| 2 | Brand Color | 子菜单，单选。依次是语言默认主题的基础色、Ant 命名色、Tailwind 色阶，共 22 个色板；末尾是 `Reset Brand Color`。选中后写入主题种子 `ColorPrimary`，界面主色随之变化 |
| 3 | Neutral Color | 子菜单。Ant Design 不支持更换中性色，所以禁用，并用工具提示说明原因 |
| 4 | Appearance | 子菜单，`Light Mode`、`Dark Mode`、`Follow System` 三个单选项 |
| 5 | Compact Mode | 复选框 |
| 6 | Other Themes | 子菜单，列出带名字的主题文件，例如 `Daybreak Blue`。没有这类主题时隐藏 |
| 7 | Enable Motion | 复选框。关闭时一并关闭 `Enable WaveSpirit` |
| 8 | Enable WaveSpirit | 复选框。开启时一并开启 `Enable Motion` |

- 第 1、2、3、6 项的子菜单由 `GalleryThemeMenu` 在运行时填充，并跟随视图模型重建；其余项的选中状态由 XAML 直接绑定视图模型。
- 选择 `Follow System` 时，视图模型读出当前的系统外观，把具体的浅色或深色写入主题选择；菜单上记住的是“跟随系统”。
- `GalleryThemeMenu`、`GalleryBrandSwatches`、`GalleryNeutralSwatches` 三个文件从 AtomUI Gallery 的 v6.3.0 源码原样移植，只改了命名空间。Gravity Gallery 声明了控件 Token，属于生成器的检查范围，所以有三处与原版不同：
  - 两个色板文件里的颜色是供用户挑选的种子色参考数据，不是主题外观，按框架 `BadgeColorUtils` 的先例用带理由的 `#pragma` 豁免 `ATOMUIGEN044`。
  - 菜单项色块的圆角是主题外观，改为经 `TokenResourceBinder` 读取 `BorderRadiusXS`；绑定随菜单重建和释放时回收。
  - 折叠分组的父菜单项用 `SetCurrentValue` 写 `FontWeight`，不占用本地值。

## 6. 路由与内容映射

| 侧边栏路由 | 右侧内容 |
| --- | --- |
| `Overview` | `OverviewPage` |
| `Community` | `CommunityPage` |
| 任一分类 | 共享的 `IconCatalogPage`，传入该分类 |

`IconCatalogPage` 是同一个页面实现的多次路由，不是额外的一级导航。

## 7. 响应式与交互要求

在 1300×900 与 1040×720 两个尺寸下：

- 标题栏、侧边栏、内容区、分隔线与页脚都可见且互不重叠；
- 概览页与社区页整体滚动，目录页只滚动网格，表头与搜索框保持可见；
- 图标卡片在左、中、右三个采样点上的悬停与点击都生效；
- 滚动接近底部时触发增量加载；
- 手动折叠侧边栏与 GalleryBase 的响应式折叠都保持预期的内容宽度；
- 明暗、紧凑、动效与语言的切换不破坏布局与交互。

## 8. 现状与差距

- 6.3.0 迁移、分类的本地化表头与导航图标、两项图标主题选择器与默认主题、标题栏 Theme 菜单均已实施，应用可启动，测试通过。
- 横幅是过渡素材，正式素材待提供（决策 D11）。
- “浏览图标”链接仍指向 `main` 分支，应改为 `release/6.0`。
- 葡萄牙语的部分菜单文案原样取自 AtomUI Gallery（如 `Light Modo`、`Dark Modo`），是否润色待确认。
- Gallery 尚未做过真机视觉验收。

## 9. 验收要点

- 桌面应用能启动，默认进入概览页，横幅正常显示。
- 导航顺序为 `Overview`、`Community`、`Categories`，分组下是 28 个分类（采用决策 D8 时再加 `All`）。
- 每个分类都能路由到目录页，页头显示本地化的分类名与结果数。
- 图标主题选择器有两项，切换后目录更新，并在切换分类时保持。
- 标题栏 Theme 菜单的八项与第 5.1 节一致：`Brand Color` 列出 22 个色板，选择后界面主色变化；`Appearance` 的三项切换生效；关闭 `Enable Motion` 时 `Enable WaveSpirit` 一同关闭。
- 第 7 节列出的两个尺寸下各项布局与交互要求都成立。
- **真机视觉验收**：实现完成后先给出书面步骤，写明入口路径与分类（例如“左侧导航 `Categories` 分组 → `Arrows`”）。由你回传截图或录屏之后再作判定，在此之前一律标为“待视觉验收”。无头测试不能替代这一步。

## 10. 明确不支持范围

- 不提供 Browser 与移动端宿主。
- 不为每个分类建立单独的页面或视图模型类。
- 不重新引入自定义导航控件，不复制 GalleryBase 的外壳行为。
