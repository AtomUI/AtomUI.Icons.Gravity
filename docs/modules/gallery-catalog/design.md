# 模块设计：Gallery 目录域（`GravityGallery.Models`）

- **对应工程**：[GravityGallery.csproj](../../../gallery/GravityGallery/GravityGallery.csproj) 中的 `Models/` 与 `Features/IconCatalog/IconCatalogPageViewModel.cs`
- **直接依赖**：`AtomUI.Icons.Gravity`、`AtomUI.Controls`
- **数据来源**：[上游资产与代码生成器](../icon-generator/design.md) 生成的 `IconInfoRepository.g.cs`
- **模块验收标准**：尚未单独编写，验收点见本文第 7 节

---

## 1. 模块职责与目录结构

目录域回答一个问题：在当前的分类、主题与搜索词下，应该显示哪些图标。它拥有图标元数据模型、分类目录和查询会话。渲染由 [Gallery 图标控件与主题](../gallery-controls/design.md) 负责，应用组合与导航由 [Gallery 应用与页面](../gallery-app/design.md) 负责。

```text
gallery/GravityGallery/
├── Models/
│   ├── IconInfo.cs                      # 单个图标的目录条目（手写）
│   ├── IconCategory.cs                  # 分类键与本地化表头（手写）
│   ├── IconCategoryLocalization.cs      # 分类键到本地化资源的映射（手写）
│   ├── IconInfoRepository.cs            # 查询会话：条件、匹配、分批加载（手写）
│   └── IconInfoRepository.g.cs          # 分类列表与各分类、各主题的图标清单（生成）
└── Features/IconCatalog/
    └── IconCatalogPageViewModel.cs      # 路由分类、共享主题与页面级查询状态
```

## 2. 数据模型

`IconInfo` 是目录中的一个条目：

| 属性 | 说明 | 示例 |
| --- | --- | --- |
| `Name` | 图标类名，也是复制到剪贴板的名称 | `ArrowRotateLeftOutlined` |
| `UpstreamName` | 上游的 `svgName`（本设计新增） | `arrow-rotate-left` |
| `Category` | 所在的分类。图标属于多个分类时，每个分类各有一条条目 | `Arrows` |
| `ThemeType` | `Outlined` 或 `Filled` | |
| `Keywords` | 上游关键词，可能为空（本设计新增） | `refresh` |
| `IconType`、`Creator` | 图标的类型与无参工厂 | |
| `Icon` | 已经物化的图标控件，生命周期由查询会话管理 | |

## 3. 分类目录

- 共 28 个分类。分类键是上游分类名首字母大写（`arrows` 对应 `Arrows`），与语言无关，同时用作路由键。
- 顺序、多分类归属与 `All` 聚合条目由生成器产出，规则见上游资产与代码生成器第 7.1 节。各分类的名称与成员数见[本地化](../localization/design.md)第 4 节。
- 现状是每个图标只归入 `metadata.json` 中的第一个分类，249 个多分类图标在其余分类下找不到。

## 4. 查询会话

`IconInfoRepository` 表示一次路由内的查询会话。每个目录页各持有一个，它不是应用级的单例。

| 成员 | 行为 |
| --- | --- |
| `Category`、`IconTheme`、`Filter` | 查询条件。任一变化都会重建结果集 |
| `ActivatedIconInfos` | 已经物化并交给界面渲染的图标 |
| `MatchedIconCount`、`HasMatches` | 匹配总数与空状态 |
| `RefreshIconInfos()`、`LoadMoreIconInfos()` | 重建结果集；加载下一批 |
| `Dispose()` | 释放已物化的图标 |

- 首批加载 96 个，之后每批 96 个。
- 重建结果集之前先释放上一批已物化的图标，页面不会拿到已释放的实例。
- 默认分类为 `Arrows`；决策 D8 采用时为 `All`。
- 默认主题改为 `Outlined`（决策 D7）。上游 816 个图标中 737 个是 `regular`。按现有的目录数据，28 个分类里有 9 个在 `Filled` 下一个图标都没有，以 `Filled` 为默认会让这些分类一打开就是空状态。

## 5. 检索规则

`IconInfo` 提供唯一的匹配方法，规则与官方演示站一致：

- 搜索词去除首尾空白后整体匹配，不区分大小写。
- 类名、上游名、任意一个关键词中有一项包含搜索词即命中。
- 搜索范围是当前分类在当前主题下的图标。需要跨分类搜索时使用 `All` 条目。

例如 `bell-dot` 命中 `BellDotOutlined`，`refresh` 命中 `ArrowRotateLeftOutlined` 与 `ArrowRotateRightOutlined`。

现状是只匹配类名。用户按上游的叫法（如 `bell-dot`）或按用途（如 `refresh`）搜索时得不到结果。

## 6. 页面状态与交互

| 状态 | 归属 | 规则 |
| --- | --- | --- |
| 主题 | 工作区级，即 `WorkspaceWindowViewModel.IconTheme` | 切换分类时保留 |
| 分类 | 路由状态 | 切换分类会新建查询会话 |
| 搜索词与滚动位置 | 页面状态 | 分类、主题或搜索词变化时回到顶部 |

- 点击图标时，类名以 `<ArrowRotateLeftOutlined />` 的形式写入剪贴板。只有在本次剪贴板请求成功之后才显示反馈，并且只有最新的一个在途请求可以显示反馈。
- 决策 D12 采用时，图标卡片增加工具提示：第一行是上游名，第二行是关键词，没有关键词时只有第一行。

## 7. 验收要点

- 每个分类返回的条目数与上游元数据的分类归属一致，例如 `Arrows` 共 147 个，跨两种主题。
- 搜索 `bell-dot`、`refresh` 与类名片段都有预期的结果；大小写不敏感；空白搜索词等同不过滤。
- 分类、主题或搜索词变化后，上一批 `IconInfo.Icon` 全部被释放。
- 切换分类后主题保持不变；切换主题后分类与搜索词保持不变。
- 没有匹配时 `HasMatches` 为 `false`，界面显示空状态。

## 8. 明确不支持范围

- 不在分类路由上做跨分类的全局搜索。官方演示站在搜索时回到全部分类，本仓通过 `All` 条目提供等价能力，不改变“分类内搜索”的交互。
- 不做以图搜图。官方演示站的图片搜索依赖向量模型，不在桌面 Gallery 的范围内。
- 不做模糊匹配与拼写纠错。
- 不做图标详情对话框。
