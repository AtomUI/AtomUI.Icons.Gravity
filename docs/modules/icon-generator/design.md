# 模块设计：上游资产与代码生成器（`AtomUI.Icons.Gravity.Generator`）

- **对应工程**：[AtomUI.Icons.Gravity.Generator.csproj](../../../src/AtomUI.Icons.Gravity.Generator/AtomUI.Icons.Gravity.Generator.csproj)
- **直接依赖**：`AtomUI.Icons.Shared`（`DefaultIconPackageGenerator`）、`Avalonia.Headless`、`Avalonia.Skia`
- **上游基准**：`@gravity-ui/icons` `2.24.0`，commit `a479b875c217a1c17881b66a2ff3132fd5161f78`
- **模块验收标准**：尚未单独编写，验收点见本文第 8 节

---

## 1. 模块职责与目录结构

本模块保存上游图标集的快照，校验并解析其中的 SVG，产出图标包的全部源码，以及 Gallery 目录页使用的图标清单。它是构建期工具，不进入 NuGet 包。

```text
src/AtomUI.Icons.Gravity.Generator/
├── AtomUI.Icons.Gravity.Generator.csproj
├── GravityIconsPackageGenerator.cs   # 扫描、校验、SVG 解析与各类产出的生成
└── Assets/
    ├── upstream.json                 # 上游来源：仓库、版本、commit、许可、版权
    ├── metadata.json                 # 上游元数据：名称、风格、关键词、分类
    ├── LICENSE                       # 上游 MIT 许可全文
    └── svgs/                         # 816 个 SVG 源文件
```

## 2. 上游资产契约

`Assets/` 是上游发布内容的原样快照，不允许手工修改。任何修正都先发生在上游，再按第 10 节的流程同步。

| 文件 | 内容 |
| --- | --- |
| `svgs/*.svg` | 每个图标一个文件，文件名即上游的 `svgName` |
| `metadata.json` | 每个图标一条记录：`name`、`style`（`regular` 或 `fill`）、`svgName`、`componentName`、`keywords`、`categories` |
| `upstream.json` | 来源仓库、版本、commit、许可与版权方 |
| `LICENSE` | 上游 MIT 许可全文，是随包分发许可通知的依据 |

上游 2.24.0 的实测事实，生成器的规则以它为依据：

| 项 | 取值 |
| --- | --- |
| 图标数 | 816，其中 `regular` 737、`fill` 79。79 个名称同时有两种风格，没有只含 `fill` 的名称 |
| `viewBox` | 814 个为 `0 0 16 16`；`alarm` 与 `alarm-fill` 为 `0 0 17 17` |
| 元素 | 只有 `path`、`g`、`defs/clipPath` |
| 属性 | 只有 `d`、`fill`、`fill-rule`、`clip-rule`、`clip-path` 和 `id` |
| `fill` 取值 | `currentColor`、根元素上的 `none`，以及 5 个图标里的 `#f33` |
| 分类 | 28 个，即 27 个官方分类加 `unassigned`；249 个图标属于 2 至 3 个分类 |
| 关键词 | 365 个图标带关键词，共 762 个 |

## 3. 命名与主题映射

| 上游 | 产物 | 示例 |
| --- | --- | --- |
| `svgName` 等于 `name`（`regular`） | 类名为 `name` 转 PascalCase 后加 `Outlined` | `alarm` → `AlarmOutlined` |
| `svgName` 等于 `name-fill` | 类名为 `name` 转 PascalCase 后加 `Filled` | `alarm-fill` → `AlarmFilled` |
| `style` 为 `regular` | `IconThemeType.Outlined` | |
| `style` 为 `fill` | `IconThemeType.Filled` | |

- PascalCase 按上游的规则逐段首字母大写，不合并缩写：`abbr-ml` 得到 `AbbrMl`，与上游的 `componentName` 一致。
- 生成器校验“类名去掉主题后缀等于上游 `componentName` 去掉 `Fill`”，不符即失败。这条校验用来发现命名规则与上游的漂移。
- 文件名为 `GeneratedIcons/<类名>.g.cs`，类名重复即失败。
- 顺序为类名按 Ordinal 升序，同名图标的 `Outlined` 排在 `Filled` 之前。枚举、工厂与目录共用这一顺序。

## 4. SVG 解析契约

生成器不使用 `AtomUI.Icons.Shared` 的 `SvgParser`，而是自己解析上游用到的那一小部分 SVG。原因有两个：共享解析器忽略 `fill-rule` 与 `clip-path`，而上游有 750 条路径使用 `evenodd`；无头绘图桩只按控制点估算包围盒，圆弧的真实边界需要 Skia 后端。

| 元素 | 读取的属性 | 处理 |
| --- | --- | --- |
| `svg` | `viewBox`、`fill` | `viewBox` 决定画布。根元素上的 `fill` 是后代的默认填充，上游写的是 `none` |
| `defs` 与 `clipPath` | `id`，以及内部 `path` 的 `d` | 先于引用处收集裁剪区域 |
| `g` | `fill`、`fill-rule`、`clip-path`、`clip-rule` | `fill` 与 `fill-rule` 向下继承 |
| `path` | `d`、`fill`、`fill-rule`、`clip-rule` | 每条路径生成一条绘制指令 |

解析遵循“不认识就失败”，上游引入新特性时生成会中止，由人来评估：

1. 每个 SVG 文件必须在 `metadata.json` 中有对应项；文件名的 `-fill` 后缀必须与 `style` 一致；`categories` 不得为空。
2. 裁剪区域必须等于整幅画布。上游 76 个带 `clipPath` 的图标都满足这一点；出现真正的局部裁剪时生成失败。
3. 可绘制的路径必须带有填充色。
4. `g` 与 `path` 上出现未列出的属性，或出现上表之外的元素，生成失败。
5. 路径数据含 `"` 或 `\` 时生成失败，因为它无法安全地写入 C# 字符串字面量。
6. `fill-rule` 显式写入路径数据：`F0` 表示 `evenodd`，`F1` 表示 `nonzero`。`StreamGeometry.Parse` 不设默认的填充规则，规则由平台实现决定。

## 5. 生成物

| 产物 | 路径 | 内容 |
| --- | --- | --- |
| `GravityIconKind.g.cs` | `src/AtomUI.Icons.Gravity/GeneratedIcons/` | 816 个枚举成员，值从 1 起，顺序即目录顺序 |
| `<类名>.g.cs` 共 816 个 | 同上 | 每个图标一个类，继承 `GravityIcon` |
| `GravityIconProvider.Factory.g.cs` | `src/AtomUI.Icons.Gravity/` | 按 `Kind` 创建实例与取类型，64 个一组 |
| `GravityIconCatalog.g.cs` | 同上 | `GravityIconInfo` 记录与 `GetIcons()` |
| `IconInfoRepository.g.cs` | `gallery/GravityGallery/Models/` | Gallery 的分类列表，以及各分类在各主题下的 `IconInfo` 清单 |

枚举、工厂与目录由共享基类 `DefaultIconPackageGenerator` 产出；单个图标的类与 Gallery 清单由本模块的生成器产出。

## 6. 可复现性与运行

```sh
dotnet build src/AtomUI.Icons.Gravity.Generator/AtomUI.Icons.Gravity.Generator.csproj -c Release -f net10.0
dotnet .artifacts/bin/Release/net10.0/AtomUI.Icons.Gravity.Generator.dll
```

生成器从自身的输出目录向上查找 `Gravity.slnx` 来定位仓库根，与当前工作目录无关。同样的输入连续生成两次，第二次不得产生受版本控制的差异。

`.agents/skills/version-release/SKILL.md` 中“必须从输出目录运行，因为生成器按当前工作目录解析路径”的说法对 Gravity 不成立，随本设计订正。

## 7. 本设计的变更

### 7.1 目录数据输出

`IconInfoRepository.g.cs` 按以下规则调整，使其与官方演示站一致：

- `Categories` 采用官方演示站的固定顺序，`Unassigned` 排在最后。顺序与各分类的本地化名称见[本地化](../localization/design.md)第 4 节。
- 图标出现在它的每一个分类下，不再只归入第一个分类。
- 每个 `IconInfo` 增加 `UpstreamName`（上游的 `svgName`，如 `arrow-rotate-left`）与 `Keywords`。
- 决策 D8 采用时，`Categories` 的首项是聚合条目 `All`，它返回当前主题下的全部图标。

### 7.2 越界图标

现状是路径越出画布时只打印警告。已知两例：`BucketOutlined` 的下沿越出 0.22 个单位，`FunnelXmarkOutlined` 越出 0.58 个单位。

变更为：越界的图标类改写 `ClipsToCanvas` 并返回 `true`。渲染时的裁剪见[图标包](../icon-package/design.md)第 4.1 节。

### 7.3 红点

现状是 `fill` 不是 `currentColor` 时只打印警告，路径仍用主画刷绘制。

变更为：`fill` 为 `#f33` 的路径生成使用次级填充画刷的指令，共涉及 5 个图标；出现其他固定颜色时生成失败。

### 7.4 生成器报告

`Report()` 输出图标数与分类数，并列出越界的图标与带红点的图标，作为信息而非警告。

## 8. 验收要点

- `svgs/`、`metadata.json`、`LICENSE` 与 `upstream.json` 所记 commit 的上游内容逐字节一致。
- 连续生成两次，第二次没有受版本控制的差异。
- 816 个图标全部生成，其中 `regular` 737 个、`fill` 79 个。
- 分类的顺序与成员归属与上游元数据一致：249 个图标出现在多个分类下，365 个图标带有 `Keywords`。
- 在 `Assets/` 中人为加入一个未知元素或属性后，生成失败并指出文件名。

## 9. 明确不支持范围

- 不在运行时解析 SVG，也不把 SVG 文件打进 NuGet 包。
- 不支持 `transform`、`opacity`、渐变、描边、`mask` 等特性。上游一旦引入，生成失败而不是降级渲染。
- 不从 Figma 拉取源文件。上游的 `scripts/download.mjs` 需要 Figma 令牌，本仓只消费它的发布产物。
- `GravityIconKind` 的枚举数值由排序位置决定，上游新增图标时后面的数值会整体后移。调用方应按名称使用枚举，不要持久化数值。

## 10. 上游同步流程

1. 确定目标版本或 commit，用上游的 `svgs/`、`metadata.json`、`LICENSE` 覆盖 `Assets/` 下的对应内容，并更新 `upstream.json` 的 `version` 与 `commit`。
2. 运行生成器，审阅生成物的差异：新增、删除、改名的图标，以及类名冲突。
3. 再运行一次生成器，确认没有新的差异。
4. 运行全部测试，更新 `THIRD-PARTY-NOTICES.md` 中的版本与 commit。
5. 按发布流程评估 SemVer 级别：图标的删除或改名是破坏性变更。
