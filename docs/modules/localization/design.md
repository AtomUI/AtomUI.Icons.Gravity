# 模块设计：本地化（`GravityGallery.Localization`）

- **对应工程**：[GravityGallery.csproj](../../../gallery/GravityGallery/GravityGallery.csproj) 中的 `Localization/` 与各功能的 `Localization/`
- **直接依赖**：构建期 `AtomUI.Generator`（`AtomUILanguageContractVersion` 为 2）
- **文案基准**：官方演示站的源码仓库 `gravity-ui/landing`，路径 `public/locales/{en,zh,pt}/icons.json`
- **模块验收标准**：尚未单独编写，验收点见本文第 7 节

---

## 1. 模块职责与目录结构

本模块拥有 Gallery 的全部可见文案及其翻译。

| 资源枚举 | 位置 | 内容 |
| --- | --- | --- |
| `WorkspaceWindowLangResourceKind` | `Workspace/Localization/WorkspaceWindowLang/` | 标题栏菜单（Settings、Theme、Language）、导航、图标主题标签、分类名称 |
| `OverviewPageLangResourceKind` | `Features/Overview/Localization/` | 概览页 |
| `CommunityPageLangResourceKind` | `Features/Community/Localization/` | 社区页 |
| `IconCatalogPageLangResourceKind` | `Features/IconCatalog/Localization/` | 目录页：搜索占位、空状态、结果数、复制反馈 |

每个资源枚举对应四个 XLIFF 文件，源语言一份、三种目标语言各一份。`Localization/GalleryLanguageDefaults.cs` 负责按当前的 UI 文化选择默认语言。

## 2. 语言

| 语言 | 角色 |
| --- | --- |
| `en-US` | 源语言，只有 `<source>` |
| `zh-CN`、`zh-TW`、`pt-BR` | 目标语言，每个单元带 `<target>` |

## 3. 资源契约

以下约束由 AtomUI 的本地化生成器在编译期强制，均已实测：

1. 资源枚举的每个成员必须在每个 xlf 文件中有同名的翻译单元，否则报 `ATOMUILOC006`。
2. 目标语言的单元必须带可发布的 `<target>`（如 `state="translated"`），否则报 `ATOMUILOC007`。
3. 路由键、包名、URL 与分类键不随语言变化，只有显示文案本地化。
4. 语言切换后导航标签重建，不产生重复节点。

## 4. 分类名称

本设计用 28 个 Gravity 分类替换现有的 18 个 Material 分类，并删除不再使用的 `NavigationIconThemeRounded`、`NavigationIconThemeSharp` 与 `NavigationIconThemeTwoTone`。

下表是各分类在四种语言下的名称与图标成员数。英文、简体中文与葡语的名称取自官方演示站；标 ※ 的条目官方没有文案，是自拟的；繁体中文是自译，需要人工校对。行的顺序就是导航与目录中的分类顺序。

| 分类键 | en-US | zh-CN | zh-TW | pt-BR | 成员数 |
| --- | --- | --- | --- | --- | --- |
| `Arrows` | Arrows | 箭头 | 箭頭 | Setas | 147 |
| `Layout` | Layout | 布局 | 版面配置 | Layout | 109 |
| `Text` | Text | 文本 | 文字 | Texto | 94 |
| `Status` | Status | 状态 | 狀態 | Status | 85 |
| `Files` | Files | 文件 | 檔案 | Arquivos | 67 |
| `Shapes` | Shapes | 形状 | 圖形 | Formas | 56 |
| `Development` | Development | 开发 | 開發 | Desenvolvimento | 57 |
| `Editor` | Editor | 编辑器 | 編輯器 | Editor | 53 |
| `People` | People | 人物 | 人物 | Pessoas | 48 |
| `Media` | Media | 媒体 | 媒體 | Mídia | 34 |
| `Brands` | Brands | 品牌 | 品牌 | Marcas | 35 |
| `Charts` | Charts | 图表 | 圖表 | Gráficos | 28 |
| `Commerce` | Commerce | 商业 | 商業 | Comércio | 27 |
| `Communication` | Communication | 通信 | 通訊 | Comunicação | 26 |
| `Games` | Games | 游戏 | 遊戲 | Jogos | 23 |
| `Devices` | Devices | 设备 | 裝置 | Dispositivos | 24 |
| `Maps` | Maps | 地图 | 地圖 | Mapas | 22 |
| `Tools` | Tools | 工具 | 工具 | Ferramentas | 21 |
| `Math` | Math | 数学 | 數學 | Matemática | 18 |
| `Security` | Security | 安全 | 安全性 | Segurança | 17 |
| `Cloud` | Cloud | 云 | 雲端 | Nuvem | 19 |
| `Finance` | Finance | 金融 | 金融 | Finanças | 16 |
| `Health` | Health | 健康 | 健康 | Saúde | 13 |
| `Transport` | Transport | 交通 | 運輸 | Transporte | 12 |
| `Weather` | Weather | 天气 | 天氣 | Clima | 12 |
| `Time` | Time | 时间 | 時間 | Tempo | 12 |
| `Food` | Food | 食物 | 食物 | Comida | 3 |
| `Unassigned` | Unassigned ※ | 未分类 ※ | 未分類 ※ | Sem categoria ※ | 7 |

成员数按多分类归属统计：一个图标属于几个分类，就在每个分类里各计一次。

决策 D8 采用时增加 `All`：`All icons`、`所有图标`、`所有圖示` ※、`Todos os ícones`。

## 5. 标题栏菜单文案

标题栏 Theme 菜单对齐 AtomUI Gallery 之后，`WorkspaceWindowLangResourceKind` 增加了 25 个成员，四个语言的文案都原样取自 AtomUI Gallery 的 v6.3.0：

| 分组 | 资源键 |
| --- | --- |
| 外观 | `MenuItemAppearance`、`MenuItemLightMode`、`MenuItemFollowSystem`。`MenuItemDarkMode` 沿用原有键，现在位于 Appearance 子菜单下 |
| 主题入口 | `MenuItemDesignLanguage`、`MenuItemBrandColor`、`MenuItemNeutralColor`、`MenuItemOtherThemes` |
| 品牌色提示 | `MenuItemBrandColorReset`、`MenuItemBrandColorFixedHint`、`MenuItemBrandColorNoLanguageHint` |
| 中性色提示 | `MenuItemNeutralColorReset`、`MenuItemNeutralColorFixedHint`、`MenuItemNeutralColorNoLanguageHint` |
| 设计语言名称 | `DesignLanguageAntDesign` 等 12 个 |

- 色板本身的名称（如 `Polar Green`、`Emerald`）是设计语言的品牌色专名，不翻译，与 AtomUI Gallery 一致。
- Gravity 只启用 Ant Design，其余 11 个设计语言名称当前不会显示。保留它们是为了让移植的 `GalleryThemeMenu` 与上游一致。
- 葡萄牙语文案原样保留了 AtomUI Gallery 的写法：`Appearance`、`Follow System` 没有翻译，`Light Modo`、`Dark Modo` 是英葡混排。是否润色待确认。

## 6. 现状与差距

28 个分类与 25 个标题栏菜单文案的资源枚举、四个 xlf 与导航映射已落地，编译期没有 `ATOMUILOC006` 与 `ATOMUILOC007`。繁体中文以及标 ※ 的条目仍是自拟、自译，需要人工校对。

## 7. 验收要点

- Debug 与 Release 构建 0 错误，没有 `ATOMUILOC006` 与 `ATOMUILOC007`。
- 四种语言的 xlf 中，单元的顺序与 `WorkspaceWindowLangResourceKind` 的成员一致，各 75 个。
- 任意一种语言下，28 个分类都有分类名称；切换语言后导航与目录页的标题随之变化，路由键不变。
- 图标主题标签只剩 `Outlined` 与 `Filled` 两项。

## 8. 明确不支持范围

- 不增加四种语言之外的语言。官方演示站另有 de、es、fr、ja、ko、ru，本仓不跟随。
- 不翻译上游的关键词。关键词是上游的英文原词，搜索按原词匹配。
- 不翻译图标类名。
