# 逻辑模块索引

本仓库采用集中文档制：解决方案下的子项目目录不放 `README.md`，每个逻辑模块的设计文档与验收标准在 `docs/modules/<module>/` 下独立维护。NuGet 包说明由根目录的 [README.nuget.md](../../README.nuget.md) 提供。

- 跨模块的架构、依赖、版本基线与决策记录：[架构概览](../architecture/overview.md)

## 模块与工程映射

“当前状态”为 2026-11-26 的实测结果，依据见架构概览的“现状”一节。

| 逻辑模块 | 对应解决方案工程 | 当前状态 | 设计文档 | 验收标准 |
| --- | --- | --- | --- | --- |
| 上游资产与代码生成器 | `src/AtomUI.Icons.Gravity.Generator` | 已落地并验证；目录数据输出、越界与红点的处理待调整 | [design.md](icon-generator/design.md) | 待编写 |
| 图标包 | `src/AtomUI.Icons.Gravity` | 已落地并验证；画布裁剪、次级画刷与包内许可通知待补 | [design.md](icon-package/design.md) | 待编写 |
| Gallery 目录域 | `gallery/GravityGallery` 的 `Models/` 与 `Features/IconCatalog/IconCatalogPageViewModel.cs` | 可运行；默认主题已改为 `Outlined`，分类归属与检索口径待按设计调整 | [design.md](gallery-catalog/design.md) | 待编写 |
| Gallery 图标控件与主题 | `gallery/GravityGallery` 的 `Controls/`、`TokenRules/` 与 `ThemeManagerBuilderExtensions.cs` | 6.3.0 迁移已完成，主题全部经 Token 取值，构建 0 警告；旧的 `GalleryControlThemesProvider` 待删除 | [design.md](gallery-controls/design.md) | 待编写 |
| Gallery 应用与页面 | `gallery/GravityGallery`、`gallery/GravityGallery.Desktop` | 可启动并通过测试；标题栏 Theme 菜单已对齐 AtomUI Gallery；使用过渡横幅，正式素材待提供 | [design.md](gallery-app/design.md) | 待编写 |
| 本地化 | `gallery/GravityGallery` 的 `Localization/` 与各功能的 `Localization/*.xlf` | 28 个分类与 25 个标题栏菜单文案的四种语言资源已落地并通过测试 | [design.md](localization/design.md) | 待编写 |
| 测试 | `tests/GravityGallery.Tests`、`scripts/release/tests/` | 41 个测试在 Debug 与 Release 下全部通过；图标包契约测试待新增 | [design.md](testing/design.md) | 待编写 |

## 统一工程边界（适用于全部模块）

1. **目录清洁**：解决方案下所有子项目目录不放 `README.md`。
2. **生成文件不手改**：`GeneratedIcons/`、各个 `*.g.cs` 与 `GeneratedFiles/` 只由生成器或构建产出，修改它们的唯一途径是改生成器或输入后重新生成。
3. **只使用公开 API 接入 AtomUI**：不声明对 `AtomUI.Core` 或上游控件包的 `InternalsVisibleTo`；注册一律走 AtomUI 6.3.0 生成器产出的静态入口，以兼容 NativeAOT 与裁剪。本仓自己的测试工程可以通过 `InternalsVisibleTo` 访问本仓的程序集。
4. **控件包不引用语言包**：`GravityGallery` 声明了控件 Token，引用任何设计语言包都会触发 `ATOMUIGEN053`。设计语言由宿主启用。
