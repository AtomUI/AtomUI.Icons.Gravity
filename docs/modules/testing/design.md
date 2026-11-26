# 模块设计：测试（`GravityGallery.Tests`）

- **对应工程**：[GravityGallery.Tests.csproj](../../../tests/GravityGallery.Tests/GravityGallery.Tests.csproj)
- **直接依赖**：`GravityGallery`、`Avalonia.Headless`、xunit.v3、Shouldly；构建期 `AtomUI.Generator`。宿主组合另需 `AtomUI.DesignLanguages.AntDesign` 与 `AtomUI.Desktop.Controls.Themes.AntDesign`
- **模块验收标准**：尚未单独编写，验收点见本文第 5 节

---

## 1. 模块职责与目录结构

本模块用一个无头的 Gallery 宿主验证模块配置、页面状态与几何布局，并新增对图标包本身的契约测试。像素与视觉不在自动化范围内。

| 文件 | 职责 |
| --- | --- |
| `AvaloniaTestApp.cs` | 无头宿主与应用初始化 |
| `HeadlessWait.cs` | 等待动效与异步主题切换的公共辅助 |
| `GravityIconPackageTests.cs` | 图标包契约（本设计新增） |
| `GravityGalleryModuleTests.cs` | 模块配置 |
| `IconGalleryInteractionTests.cs` | 目录域的查询、批量加载与复制反馈 |
| `IconGalleryThemeTests.cs` | 主题落到控件上的取值 |
| `ThemeMenuTests.cs` | 标题栏 Theme 菜单的结构与交互 |
| `OverviewPageTests.cs`、`CommunityPageTests.cs` | 概览页与社区页 |
| `GalleryShellMigrationTests.cs`、`IconGalleryGeometryTests.cs` | 外壳与几何布局 |
| `scripts/release/tests/test_*.py` | 发布工具：版本解析与包校验 |

## 2. 无头宿主

`TestAppBuilder.BuildAvaloniaApp()` 的 AtomUI 组合必须与桌面宿主一致：先调用 `BaseGalleryApplication.ConfigureCore(builder)`，再启用 Ant Design 并登记取值包，见 [Gallery 应用与页面](../gallery-app/design.md)第 2 节。

- 测试不并行（`DisableTestParallelization = true`），因为它们共享同一个应用实例。
- 宿主使用默认的无绘图后端，只验证布局与契约。`CaptureRenderedFrame()` 只用来触发一次渲染；像素断言与截图基线不属于自动化范围。
- AtomUI 6.3.0 起侧边栏折叠与滚动是动效：每次渲染推进一次动画时钟，再由一个 16 毫秒的定时器排下一次渲染。`Dispatcher.UIThread.RunJobs()` 只处理排队的作业，不推进定时器，所以忙等加 `ForceRenderTimerTick()` 会让动画随机停在半途（实测 16 次里卡死 7 到 14 次）。等待动效和异步的主题切换都必须用嵌套消息循环：`HeadlessWait.Until` 在 `DispatcherFrame` 里用 10 毫秒的轮询定时器检查条件，3 秒超时。按这种方式动画约 215 毫秒自然结束，连续多轮全量运行没有失败。
- 无头测试不替代真机视觉验收，见 Gallery 应用与页面第 9 节。

## 3. 分层

| 层 | 文件 | 覆盖 |
| --- | --- | --- |
| 图标包契约 | `GravityIconPackageTests.cs` | 目录完整性、上游一致性、几何、画刷、许可通知 |
| 模块配置 | `GravityGalleryModuleTests.cs` | 品牌、导航顺序、分类路由、本地化表头、导航图标 |
| 页面与状态 | `IconGalleryInteractionTests.cs`、`OverviewPageTests.cs`、`CommunityPageTests.cs` | 查询、批量加载、复制反馈、安装命令、项目链接 |
| 主题取值 | `IconGalleryThemeTests.cs` | 图标卡片与空状态的内边距、间距、字号、圆角与尺寸 |
| 标题栏菜单 | `ThemeMenuTests.cs` | Theme 菜单的结构、品牌色切换、外观三态、动效与波浪动画的联动 |
| 外壳与几何 | `GalleryShellMigrationTests.cs`、`IconGalleryGeometryTests.cs` | 侧边栏折叠、滚动、命中测试，1300×900 与 1040×720 |
| 发布工具 | `scripts/release/tests/test_*.py` | 版本解析与包校验脚本 |

### 3.1 图标包契约测试

Material 没有这一层。新增的 `GravityIconPackageTests.cs` 放在现有测试工程里，不新建工程：

- 目录完整性：`GravityIconCatalog.GetIcons()` 共 816 项，类名唯一；每个 `GravityIconKind` 都能经 `GravityIconProvider` 创建出 `IconType` 所指类型的实例。
- 上游一致性：每一项都能由 `Assets/metadata.json` 推出，`UpstreamName` 对应的 SVG 文件存在。
- 几何：`ViewBox` 是 16×16 或 17×17；需要裁剪的图标恰好是 `BucketOutlined` 与 `FunnelXmarkOutlined`。
- 画刷：使用次级填充画刷的图标恰好是 5 个带红点的图标。
- 许可通知：`THIRD-PARTY-NOTICES.md` 中的版本与 commit 与 `upstream.json` 一致。

为读取 `ClipsToCanvas` 与生成的包围盒，图标包向本测试工程开放 `InternalsVisibleTo`，见[图标包](../icon-package/design.md)第 4.3 节。

### 3.2 现有测试的适配

35 个既有测试来自 Material。下表是已经完成的适配；适配后它们在 Debug 与 Release 下全部通过。

| 文件 | 适配 |
| --- | --- |
| `GravityGalleryModuleTests.cs` | 无需改动。它按生成的分类列表动态断言，28 个分类与各不相同的 `Outlined` 导航图标自然满足 |
| `IconGalleryInteractionTests.cs` | 主题从五种改为两种；分类夹具改用 `Arrows`、`Layout`、`Status`；批量加载按实际成员数断言；表头用例改为 760 宽时同行不重叠、360 宽时换行 |
| `GalleryShellMigrationTests.cs`、`IconGalleryGeometryTests.cs` | 导航目标从 `Action`、`Alert` 改为真实分类；等待动效改用 `HeadlessWait.Until`；默认主题断言改为 `Outlined`；两个尺寸下的几何断言保留 |
| `OverviewPageTests.cs`、`CommunityPageTests.cs` | 没有 Material 专属的夹具，横幅到位后直接通过 |
| `AvaloniaTestApp.cs` | 宿主组合与桌面宿主对齐 |

批量加载用例改写的事实依据：Gravity 最大的“分类加主题”是 `Arrows` 的 `Outlined`，现有 134 个图标，达不到 Material 用例假设的连续两批（192 个）。用例按 `Min(96, 成员数)` 与 `Min(192, 成员数)` 断言；采用决策 D8 时，`All` 有足够的图标验证连续两批。

### 3.3 标题栏菜单测试

`ThemeMenuTests` 覆盖标题栏 Theme 菜单（设计见 [Gallery 应用与页面](../gallery-app/design.md)第 5.1 节），共 5 个用例：

- 菜单结构：直接解析 `WorkspaceWindow.axaml`，断言 Theme 下的八项及其顺序，外观子菜单的三个单选项及其绑定。
- 子菜单内容：设计语言只有 `AntDesign` 并处于选中；`Brand Color` 是 22 个色板加分隔线与重置，首个色板是语言默认主题的基础色并被选中；`Neutral Color` 禁用并带工具提示；`Other Themes` 与不带语言默认条目的主题列表一致。选择色板后视图模型记住该颜色，单选项跟随，重置变为可用。
- 外观：在真实窗口里点击菜单项，视图模型、单选项与主题管理器的当前选择一起变化。
- 动效联动：关闭 `Enable Motion` 时 `Enable WaveSpirit` 的选中状态与两个生效 Token 一起关闭，反过来开启时一起恢复。
- 菜单命令不向菜单项转发 `CanExecuteChanged`。

写这类在真实窗口上点击菜单的测试时，有三处容易出错，均已实测：

1. 子菜单弹出之前，其中的菜单项不在可视树里，`RaiseEvent` 没有路由路径，窗口上的处理器收不到。点击前要先打开对应的子菜单（`IsSubMenuOpen = true`）。
2. 读取生效的 Token 必须通过登记在主题 schema 里的控件类型。`WorkspaceWindow` 不在其中，`ControlTokenAccessor.Capture` 会抛异常；用菜单项本身读取。
3. 选择 `Follow System` 后，主题管理器收到的是具体的浅色或深色，`FollowSystem` 标志不会变为 `true`。“跟随系统”这一状态记在视图模型的 `AppearanceMode` 上。

会改变全局主题状态的用例（品牌色、外观、动效）都在 `finally` 里恢复原状，避免影响后续用例。

## 4. 现状

2026-11-26 实测：41 个测试（35 个既有测试、1 个主题取值测试、5 个标题栏菜单测试）在 Debug 与 Release 下全部通过，Debug 连续 5 轮、Release 连续 3 轮没有失败。修复之前的 34 个失败来自三处：Gallery 在 6.3.0 下编译不过；分类资源仍是 Material 的，应用无法启动；测试夹具写死了 Material 的分类与五种主题。图标包契约测试尚未新增。

## 5. 验收要点

- `dotnet test Gravity.slnx` 在 Debug 与 Release 下全部通过，并且发现的测试数量大于 0。
- Debug 与 Release 全量构建均为 0 警告 0 错误。
- 两种配置的目标框架和包引用不同，`obj` 目录又是共用的，所以切换配置前要按目标配置重新还原（Release 用 `dotnet restore Gravity.slnx -p:Configuration=Release`），否则会报 `NETSDK1005`，或者找不到只在 Debug 引用的包。发布流水线已经是这样做的。
- 新增的图标包契约测试全部通过。
- `python -m unittest discover -s scripts/release/tests -p "test_*.py"` 通过，其中包含对包内许可通知的校验。
- 生成器连续运行两次，第二次没有差异。

## 6. 明确不支持范围

- 不在自动化测试里做像素比对，不提交截图或视觉基线。
- 不做 UI 自动化与录屏。
- 不为生成器工程单独建立测试工程。生成器由“连续两次生成没有差异”与包契约测试间接验证。
