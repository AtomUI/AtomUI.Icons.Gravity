// This code is auto generated. Do not modify.
// Upstream: Gravity UI Icons v2.24.0 (a479b875c217), MIT License, Copyright (c) 2022 YANDEX LLC, https://github.com/gravity-ui/icons
#nullable enable

using Avalonia;
using System;
using System.Collections.Generic;
using Avalonia.Media;
using AtomUI.Controls;
namespace GravityGallery.Models;

public partial class IconInfoRepository
{
    public IconInfoRepository()
    {
        Categories = [
            "Arrows",
            "Brands",
            "Charts",
            "Cloud",
            "Commerce",
            "Communication",
            "Development",
            "Devices",
            "Editor",
            "Files",
            "Finance",
            "Food",
            "Games",
            "Health",
            "Layout",
            "Maps",
            "Math",
            "Media",
            "People",
            "Security",
            "Shapes",
            "Status",
            "Text",
            "Time",
            "Tools",
            "Transport",
            "Unassigned",
            "Weather",
        ];
    }

    protected partial List<IconInfo> CreateIconInfos(string? category, IconThemeType iconTheme)
    {
        return category switch
        {
            "Arrows" => CreateArrowsIconInfos(iconTheme),
            "Brands" => CreateBrandsIconInfos(iconTheme),
            "Charts" => CreateChartsIconInfos(iconTheme),
            "Cloud" => CreateCloudIconInfos(iconTheme),
            "Commerce" => CreateCommerceIconInfos(iconTheme),
            "Communication" => CreateCommunicationIconInfos(iconTheme),
            "Development" => CreateDevelopmentIconInfos(iconTheme),
            "Devices" => CreateDevicesIconInfos(iconTheme),
            "Editor" => CreateEditorIconInfos(iconTheme),
            "Files" => CreateFilesIconInfos(iconTheme),
            "Finance" => CreateFinanceIconInfos(iconTheme),
            "Food" => CreateFoodIconInfos(iconTheme),
            "Games" => CreateGamesIconInfos(iconTheme),
            "Health" => CreateHealthIconInfos(iconTheme),
            "Layout" => CreateLayoutIconInfos(iconTheme),
            "Maps" => CreateMapsIconInfos(iconTheme),
            "Math" => CreateMathIconInfos(iconTheme),
            "Media" => CreateMediaIconInfos(iconTheme),
            "People" => CreatePeopleIconInfos(iconTheme),
            "Security" => CreateSecurityIconInfos(iconTheme),
            "Shapes" => CreateShapesIconInfos(iconTheme),
            "Status" => CreateStatusIconInfos(iconTheme),
            "Text" => CreateTextIconInfos(iconTheme),
            "Time" => CreateTimeIconInfos(iconTheme),
            "Tools" => CreateToolsIconInfos(iconTheme),
            "Transport" => CreateTransportIconInfos(iconTheme),
            "Unassigned" => CreateUnassignedIconInfos(iconTheme),
            "Weather" => CreateWeatherIconInfos(iconTheme),
            _ => []
        };
    }

    private static List<IconInfo> CreateArrowsIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateArrowsFilledIconInfos(),
            IconThemeType.Outlined => CreateArrowsOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateArrowsFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "CircleArrowDownFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowDownFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowDownFilled()
            },
            new IconInfo {
                Name = "CircleArrowLeftFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowLeftFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowLeftFilled()
            },
            new IconInfo {
                Name = "CircleArrowRightFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowRightFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowRightFilled()
            },
            new IconInfo {
                Name = "CircleArrowUpFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowUpFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowUpFilled()
            },
            new IconInfo {
                Name = "CircleChevronDownFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronDownFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronDownFilled()
            },
            new IconInfo {
                Name = "CircleChevronLeftFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronLeftFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronLeftFilled()
            },
            new IconInfo {
                Name = "CircleChevronRightFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronRightFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronRightFilled()
            },
            new IconInfo {
                Name = "CircleChevronUpFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronUpFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronUpFilled()
            },
            new IconInfo {
                Name = "LocationArrowFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.LocationArrowFilled),
                Creator = () => new AtomUI.Icons.Gravity.LocationArrowFilled()
            },
            new IconInfo {
                Name = "TriangleDownFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleDownFilled),
                Creator = () => new AtomUI.Icons.Gravity.TriangleDownFilled()
            },
            new IconInfo {
                Name = "TriangleLeftFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleLeftFilled),
                Creator = () => new AtomUI.Icons.Gravity.TriangleLeftFilled()
            },
            new IconInfo {
                Name = "TriangleRightFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleRightFilled),
                Creator = () => new AtomUI.Icons.Gravity.TriangleRightFilled()
            },
            new IconInfo {
                Name = "TriangleUpFilled",
                Category = "Arrows",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleUpFilled),
                Creator = () => new AtomUI.Icons.Gravity.TriangleUpFilled()
            },
        ];
    }

    private static List<IconInfo> CreateArrowsOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "ArrowChevronDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowChevronDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowChevronDownOutlined()
            },
            new IconInfo {
                Name = "ArrowChevronLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowChevronLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowChevronLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowChevronRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowChevronRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowChevronRightOutlined()
            },
            new IconInfo {
                Name = "ArrowChevronUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowChevronUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowChevronUpOutlined()
            },
            new IconInfo {
                Name = "ArrowDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowDownOutlined()
            },
            new IconInfo {
                Name = "ArrowDownFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowDownFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowDownFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowDownLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowDownLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowDownLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowDownRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowDownRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowDownRightOutlined()
            },
            new IconInfo {
                Name = "ArrowDownToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowDownToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowDownToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowDownToSquareOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowDownToSquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowDownToSquareOutlined()
            },
            new IconInfo {
                Name = "ArrowLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowLeftFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowLeftFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowLeftFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowLeftToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowLeftToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowLeftToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRightOutlined()
            },
            new IconInfo {
                Name = "ArrowRightArrowLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRightArrowLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRightArrowLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowRightFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRightFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRightFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowRightFromSquareOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRightFromSquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRightFromSquareOutlined()
            },
            new IconInfo {
                Name = "ArrowRightToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRightToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRightToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowRightToSquareOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRightToSquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRightToSquareOutlined()
            },
            new IconInfo {
                Name = "ArrowRotateLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRotateLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRotateLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowRotateLeftNumber5Outlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRotateLeftNumber5Outlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRotateLeftNumber5Outlined()
            },
            new IconInfo {
                Name = "ArrowRotateRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRotateRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRotateRightOutlined()
            },
            new IconInfo {
                Name = "ArrowRotateRightNumber5Outlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowRotateRightNumber5Outlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowRotateRightNumber5Outlined()
            },
            new IconInfo {
                Name = "ArrowShapeDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeDownOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeDownFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeDownFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeDownFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeDownToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeDownToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeDownToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeLeftFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeLeftFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeLeftFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeLeftToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeLeftToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeLeftToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeRightOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeRightFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeRightFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeRightFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeRightToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeRightToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeRightToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeTurnUpLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeTurnUpLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeTurnUpLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeTurnUpRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeTurnUpRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeTurnUpRightOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeUpOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeUpFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeUpFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeUpFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowShapeUpToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowShapeUpToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowShapeUpToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpOutlined()
            },
            new IconInfo {
                Name = "ArrowUpArrowDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpArrowDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpArrowDownOutlined()
            },
            new IconInfo {
                Name = "ArrowUpFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpFromLineOutlined()
            },
            new IconInfo {
                Name = "ArrowUpFromSquareOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpFromSquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpFromSquareOutlined()
            },
            new IconInfo {
                Name = "ArrowUpFromSquareSlashOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpFromSquareSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpFromSquareSlashOutlined()
            },
            new IconInfo {
                Name = "ArrowUpLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowUpRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpRightOutlined()
            },
            new IconInfo {
                Name = "ArrowUpRightFromSquareOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpRightFromSquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpRightFromSquareOutlined()
            },
            new IconInfo {
                Name = "ArrowUpToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUpToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUpToLineOutlined()
            },
            new IconInfo {
                Name = "ArrowUturnCcwDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUturnCcwDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUturnCcwDownOutlined()
            },
            new IconInfo {
                Name = "ArrowUturnCcwLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUturnCcwLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUturnCcwLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowUturnCcwRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUturnCcwRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUturnCcwRightOutlined()
            },
            new IconInfo {
                Name = "ArrowUturnCwDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUturnCwDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUturnCwDownOutlined()
            },
            new IconInfo {
                Name = "ArrowUturnCwLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUturnCwLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUturnCwLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowUturnCwRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowUturnCwRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowUturnCwRightOutlined()
            },
            new IconInfo {
                Name = "Arrows3RotateLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Arrows3RotateLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Arrows3RotateLeftOutlined()
            },
            new IconInfo {
                Name = "Arrows3RotateLeftLetterAOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Arrows3RotateLeftLetterAOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Arrows3RotateLeftLetterAOutlined()
            },
            new IconInfo {
                Name = "Arrows3RotateRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Arrows3RotateRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Arrows3RotateRightOutlined()
            },
            new IconInfo {
                Name = "ArrowsExpandOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsExpandOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsExpandOutlined()
            },
            new IconInfo {
                Name = "ArrowsExpandHorizontalOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsExpandHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsExpandHorizontalOutlined()
            },
            new IconInfo {
                Name = "ArrowsExpandVerticalOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsExpandVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsExpandVerticalOutlined()
            },
            new IconInfo {
                Name = "ArrowsOppositeToDotsOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsOppositeToDotsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsOppositeToDotsOutlined()
            },
            new IconInfo {
                Name = "ArrowsRotateLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsRotateLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsRotateLeftOutlined()
            },
            new IconInfo {
                Name = "ArrowsRotateLeftSlashOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsRotateLeftSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsRotateLeftSlashOutlined()
            },
            new IconInfo {
                Name = "ArrowsRotateRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsRotateRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsRotateRightOutlined()
            },
            new IconInfo {
                Name = "ArrowsRotateRightSlashOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArrowsRotateRightSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArrowsRotateRightSlashOutlined()
            },
            new IconInfo {
                Name = "BarsAscendingAlignLeftArrowDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsAscendingAlignLeftArrowDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsAscendingAlignLeftArrowDownOutlined()
            },
            new IconInfo {
                Name = "BarsAscendingAlignLeftArrowUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsAscendingAlignLeftArrowUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsAscendingAlignLeftArrowUpOutlined()
            },
            new IconInfo {
                Name = "BarsDescendingAlignLeftArrowDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsDescendingAlignLeftArrowDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsDescendingAlignLeftArrowDownOutlined()
            },
            new IconInfo {
                Name = "BarsDescendingAlignLeftArrowUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsDescendingAlignLeftArrowUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsDescendingAlignLeftArrowUpOutlined()
            },
            new IconInfo {
                Name = "BranchesDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BranchesDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BranchesDownOutlined()
            },
            new IconInfo {
                Name = "BranchesRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BranchesRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BranchesRightOutlined()
            },
            new IconInfo {
                Name = "BranchesRightArrowRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BranchesRightArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BranchesRightArrowRightOutlined()
            },
            new IconInfo {
                Name = "CaretDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CaretDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CaretDownOutlined()
            },
            new IconInfo {
                Name = "CaretLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CaretLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CaretLeftOutlined()
            },
            new IconInfo {
                Name = "CaretRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CaretRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CaretRightOutlined()
            },
            new IconInfo {
                Name = "CaretUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CaretUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CaretUpOutlined()
            },
            new IconInfo {
                Name = "CaretsExpandVerticalOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CaretsExpandVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CaretsExpandVerticalOutlined()
            },
            new IconInfo {
                Name = "ChevronDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronDownOutlined()
            },
            new IconInfo {
                Name = "ChevronDownWideOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronDownWideOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronDownWideOutlined()
            },
            new IconInfo {
                Name = "ChevronLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronLeftOutlined()
            },
            new IconInfo {
                Name = "ChevronRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronRightOutlined()
            },
            new IconInfo {
                Name = "ChevronUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronUpOutlined()
            },
            new IconInfo {
                Name = "ChevronUpWideOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronUpWideOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronUpWideOutlined()
            },
            new IconInfo {
                Name = "ChevronsCollapseFromLinesOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsCollapseFromLinesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsCollapseFromLinesOutlined()
            },
            new IconInfo {
                Name = "ChevronsCollapseHorizontalOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsCollapseHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsCollapseHorizontalOutlined()
            },
            new IconInfo {
                Name = "ChevronsCollapseToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsCollapseToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsCollapseToLineOutlined()
            },
            new IconInfo {
                Name = "ChevronsCollapseUpRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsCollapseUpRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsCollapseUpRightOutlined()
            },
            new IconInfo {
                Name = "ChevronsCollapseVerticalOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsCollapseVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsCollapseVerticalOutlined()
            },
            new IconInfo {
                Name = "ChevronsCollapseVerticalToLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsCollapseVerticalToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsCollapseVerticalToLineOutlined()
            },
            new IconInfo {
                Name = "ChevronsDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsDownOutlined()
            },
            new IconInfo {
                Name = "ChevronsDownWideOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsDownWideOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsDownWideOutlined()
            },
            new IconInfo {
                Name = "ChevronsExpandFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsExpandFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsExpandFromLineOutlined()
            },
            new IconInfo {
                Name = "ChevronsExpandHorizontalOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsExpandHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsExpandHorizontalOutlined()
            },
            new IconInfo {
                Name = "ChevronsExpandToLinesOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsExpandToLinesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsExpandToLinesOutlined()
            },
            new IconInfo {
                Name = "ChevronsExpandUpRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsExpandUpRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsExpandUpRightOutlined()
            },
            new IconInfo {
                Name = "ChevronsExpandVerticalOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsExpandVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsExpandVerticalOutlined()
            },
            new IconInfo {
                Name = "ChevronsExpandVerticalFromLineOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsExpandVerticalFromLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsExpandVerticalFromLineOutlined()
            },
            new IconInfo {
                Name = "ChevronsLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsLeftOutlined()
            },
            new IconInfo {
                Name = "ChevronsRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsRightOutlined()
            },
            new IconInfo {
                Name = "ChevronsUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsUpOutlined()
            },
            new IconInfo {
                Name = "ChevronsUpWideOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsUpWideOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsUpWideOutlined()
            },
            new IconInfo {
                Name = "CircleArrowDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowDownOutlined()
            },
            new IconInfo {
                Name = "CircleArrowLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowLeftOutlined()
            },
            new IconInfo {
                Name = "CircleArrowRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowRightOutlined()
            },
            new IconInfo {
                Name = "CircleArrowUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleArrowUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleArrowUpOutlined()
            },
            new IconInfo {
                Name = "CircleChevronDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronDownOutlined()
            },
            new IconInfo {
                Name = "CircleChevronLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronLeftOutlined()
            },
            new IconInfo {
                Name = "CircleChevronRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronRightOutlined()
            },
            new IconInfo {
                Name = "CircleChevronUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronUpOutlined()
            },
            new IconInfo {
                Name = "CircleChevronsDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronsDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronsDownOutlined()
            },
            new IconInfo {
                Name = "CircleChevronsLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronsLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronsLeftOutlined()
            },
            new IconInfo {
                Name = "CircleChevronsRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronsRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronsRightOutlined()
            },
            new IconInfo {
                Name = "CircleChevronsUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleChevronsUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleChevronsUpOutlined()
            },
            new IconInfo {
                Name = "CopyArrowRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyArrowRightOutlined()
            },
            new IconInfo {
                Name = "CopyChevronRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyChevronRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyChevronRightOutlined()
            },
            new IconInfo {
                Name = "DatabaseArrowRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DatabaseArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DatabaseArrowRightOutlined()
            },
            new IconInfo {
                Name = "FileArrowDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileArrowDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileArrowDownOutlined()
            },
            new IconInfo {
                Name = "FileArrowLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileArrowLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileArrowLeftOutlined()
            },
            new IconInfo {
                Name = "FileArrowRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileArrowRightOutlined()
            },
            new IconInfo {
                Name = "FileArrowRightOutOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileArrowRightOutOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileArrowRightOutOutlined()
            },
            new IconInfo {
                Name = "FileArrowUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileArrowUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileArrowUpOutlined()
            },
            new IconInfo {
                Name = "FolderArrowDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderArrowDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderArrowDownOutlined()
            },
            new IconInfo {
                Name = "FolderArrowLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderArrowLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderArrowLeftOutlined()
            },
            new IconInfo {
                Name = "FolderArrowRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderArrowRightOutlined()
            },
            new IconInfo {
                Name = "FolderArrowUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderArrowUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderArrowUpOutlined()
            },
            new IconInfo {
                Name = "FolderArrowUpInOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderArrowUpInOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderArrowUpInOutlined()
            },
            new IconInfo {
                Name = "LocationArrowOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LocationArrowOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LocationArrowOutlined()
            },
            new IconInfo {
                Name = "NodesDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.NodesDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.NodesDownOutlined()
            },
            new IconInfo {
                Name = "NodesLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.NodesLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.NodesLeftOutlined()
            },
            new IconInfo {
                Name = "NodesRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.NodesRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.NodesRightOutlined()
            },
            new IconInfo {
                Name = "NodesUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.NodesUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.NodesUpOutlined()
            },
            new IconInfo {
                Name = "ShuffleOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShuffleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShuffleOutlined()
            },
            new IconInfo {
                Name = "TriangleDownOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TriangleDownOutlined()
            },
            new IconInfo {
                Name = "TriangleLeftOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TriangleLeftOutlined()
            },
            new IconInfo {
                Name = "TriangleRightOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TriangleRightOutlined()
            },
            new IconInfo {
                Name = "TriangleUpOutlined",
                Category = "Arrows",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TriangleUpOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateBrandsIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateBrandsOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateBrandsOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "LogoAcrobatOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoAcrobatOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoAcrobatOutlined()
            },
            new IconInfo {
                Name = "LogoAndroidOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoAndroidOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoAndroidOutlined()
            },
            new IconInfo {
                Name = "LogoAppStoreOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoAppStoreOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoAppStoreOutlined()
            },
            new IconInfo {
                Name = "LogoAppleOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoAppleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoAppleOutlined()
            },
            new IconInfo {
                Name = "LogoDebianOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoDebianOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoDebianOutlined()
            },
            new IconInfo {
                Name = "LogoDockerOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoDockerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoDockerOutlined()
            },
            new IconInfo {
                Name = "LogoDrawIoOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoDrawIoOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoDrawIoOutlined()
            },
            new IconInfo {
                Name = "LogoFacebookOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoFacebookOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoFacebookOutlined()
            },
            new IconInfo {
                Name = "LogoFigmaOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoFigmaOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoFigmaOutlined()
            },
            new IconInfo {
                Name = "LogoGithubOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoGithubOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoGithubOutlined()
            },
            new IconInfo {
                Name = "LogoGitlabOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoGitlabOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoGitlabOutlined()
            },
            new IconInfo {
                Name = "LogoGooglePlayOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoGooglePlayOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoGooglePlayOutlined()
            },
            new IconInfo {
                Name = "LogoHuaweiAppgalleryOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoHuaweiAppgalleryOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoHuaweiAppgalleryOutlined()
            },
            new IconInfo {
                Name = "LogoLinkedinOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoLinkedinOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoLinkedinOutlined()
            },
            new IconInfo {
                Name = "LogoLinuxOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoLinuxOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoLinuxOutlined()
            },
            new IconInfo {
                Name = "LogoMacosOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoMacosOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoMacosOutlined()
            },
            new IconInfo {
                Name = "LogoMarkdownOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoMarkdownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoMarkdownOutlined()
            },
            new IconInfo {
                Name = "LogoMcpOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoMcpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoMcpOutlined()
            },
            new IconInfo {
                Name = "LogoMermaidOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoMermaidOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoMermaidOutlined()
            },
            new IconInfo {
                Name = "LogoMicrosoftOfficeOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoMicrosoftOfficeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoMicrosoftOfficeOutlined()
            },
            new IconInfo {
                Name = "LogoNodejsOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoNodejsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoNodejsOutlined()
            },
            new IconInfo {
                Name = "LogoNotionOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoNotionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoNotionOutlined()
            },
            new IconInfo {
                Name = "LogoOsiOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoOsiOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoOsiOutlined()
            },
            new IconInfo {
                Name = "LogoPythonOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoPythonOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoPythonOutlined()
            },
            new IconInfo {
                Name = "LogoRustoreOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoRustoreOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoRustoreOutlined()
            },
            new IconInfo {
                Name = "LogoSlackOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoSlackOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoSlackOutlined()
            },
            new IconInfo {
                Name = "LogoStackOverflowOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoStackOverflowOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoStackOverflowOutlined()
            },
            new IconInfo {
                Name = "LogoTelegramOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoTelegramOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoTelegramOutlined()
            },
            new IconInfo {
                Name = "LogoUbuntuOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoUbuntuOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoUbuntuOutlined()
            },
            new IconInfo {
                Name = "LogoWebhookOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoWebhookOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoWebhookOutlined()
            },
            new IconInfo {
                Name = "LogoWindowsOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoWindowsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoWindowsOutlined()
            },
            new IconInfo {
                Name = "LogoYandexOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoYandexOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoYandexOutlined()
            },
            new IconInfo {
                Name = "LogoYandexCloudOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoYandexCloudOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoYandexCloudOutlined()
            },
            new IconInfo {
                Name = "LogoYandexMessengerOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoYandexMessengerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoYandexMessengerOutlined()
            },
            new IconInfo {
                Name = "LogoYandexTrackerOutlined",
                Category = "Brands",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoYandexTrackerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoYandexTrackerOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateChartsIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateChartsOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateChartsOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "ChartAreaStackedOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartAreaStackedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartAreaStackedOutlined()
            },
            new IconInfo {
                Name = "ChartAreaStackedNormalizedOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartAreaStackedNormalizedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartAreaStackedNormalizedOutlined()
            },
            new IconInfo {
                Name = "ChartBarOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartBarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartBarOutlined()
            },
            new IconInfo {
                Name = "ChartBarStackedOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartBarStackedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartBarStackedOutlined()
            },
            new IconInfo {
                Name = "ChartColumnOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartColumnOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartColumnOutlined()
            },
            new IconInfo {
                Name = "ChartColumnStackedOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartColumnStackedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartColumnStackedOutlined()
            },
            new IconInfo {
                Name = "ChartDonutOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartDonutOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartDonutOutlined()
            },
            new IconInfo {
                Name = "ChartLineOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartLineOutlined()
            },
            new IconInfo {
                Name = "ChartLineArrowUpOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartLineArrowUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartLineArrowUpOutlined()
            },
            new IconInfo {
                Name = "ChartLineLabelOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartLineLabelOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartLineLabelOutlined()
            },
            new IconInfo {
                Name = "ChartLinePointsOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartLinePointsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartLinePointsOutlined()
            },
            new IconInfo {
                Name = "ChartMixedOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartMixedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartMixedOutlined()
            },
            new IconInfo {
                Name = "ChartPieOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartPieOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartPieOutlined()
            },
            new IconInfo {
                Name = "ChartTreemapOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChartTreemapOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChartTreemapOutlined()
            },
            new IconInfo {
                Name = "DisplayPulseOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DisplayPulseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DisplayPulseOutlined()
            },
            new IconInfo {
                Name = "GraphNodeOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GraphNodeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GraphNodeOutlined()
            },
            new IconInfo {
                Name = "HeartPulseOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HeartPulseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HeartPulseOutlined()
            },
            new IconInfo {
                Name = "ListTimelineOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ListTimelineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ListTimelineOutlined()
            },
            new IconInfo {
                Name = "PulseOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PulseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PulseOutlined()
            },
            new IconInfo {
                Name = "RectanglePulseOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.RectanglePulseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.RectanglePulseOutlined()
            },
            new IconInfo {
                Name = "SpeedometerOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SpeedometerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SpeedometerOutlined()
            },
            new IconInfo {
                Name = "SquareBarsOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareBarsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareBarsOutlined()
            },
            new IconInfo {
                Name = "SquareBarsVerticalOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareBarsVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareBarsVerticalOutlined()
            },
            new IconInfo {
                Name = "SquareBracketsBarsVerticalOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareBracketsBarsVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareBracketsBarsVerticalOutlined()
            },
            new IconInfo {
                Name = "SquareChartBarOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareChartBarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareChartBarOutlined()
            },
            new IconInfo {
                Name = "SquareChartColumnOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareChartColumnOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareChartColumnOutlined()
            },
            new IconInfo {
                Name = "TachometerOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TachometerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TachometerOutlined()
            },
            new IconInfo {
                Name = "TimelineOutlined",
                Category = "Charts",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TimelineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TimelineOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateCloudIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateCloudFilledIconInfos(),
            IconThemeType.Outlined => CreateCloudOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateCloudFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "DatabaseFilled",
                Category = "Cloud",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.DatabaseFilled),
                Creator = () => new AtomUI.Icons.Gravity.DatabaseFilled()
            },
            new IconInfo {
                Name = "DatabasesFilled",
                Category = "Cloud",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.DatabasesFilled),
                Creator = () => new AtomUI.Icons.Gravity.DatabasesFilled()
            },
        ];
    }

    private static List<IconInfo> CreateCloudOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CloudOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CloudOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CloudOutlined()
            },
            new IconInfo {
                Name = "CloudArrowUpInOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CloudArrowUpInOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CloudArrowUpInOutlined()
            },
            new IconInfo {
                Name = "CloudCheckOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CloudCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CloudCheckOutlined()
            },
            new IconInfo {
                Name = "CloudGearOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CloudGearOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CloudGearOutlined()
            },
            new IconInfo {
                Name = "CloudNutHexOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CloudNutHexOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CloudNutHexOutlined()
            },
            new IconInfo {
                Name = "CloudSlashOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CloudSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CloudSlashOutlined()
            },
            new IconInfo {
                Name = "DatabaseOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DatabaseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DatabaseOutlined()
            },
            new IconInfo {
                Name = "DatabaseMagnifierOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DatabaseMagnifierOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DatabaseMagnifierOutlined()
            },
            new IconInfo {
                Name = "DatabaseNutHexOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DatabaseNutHexOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DatabaseNutHexOutlined()
            },
            new IconInfo {
                Name = "DatabasePlusOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DatabasePlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DatabasePlusOutlined()
            },
            new IconInfo {
                Name = "DatabasesOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DatabasesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DatabasesOutlined()
            },
            new IconInfo {
                Name = "FirewallOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FirewallOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FirewallOutlined()
            },
            new IconInfo {
                Name = "FloppyDiskOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FloppyDiskOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FloppyDiskOutlined()
            },
            new IconInfo {
                Name = "HardDriveOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HardDriveOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HardDriveOutlined()
            },
            new IconInfo {
                Name = "ServerOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ServerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ServerOutlined()
            },
            new IconInfo {
                Name = "ServerPlusOutlined",
                Category = "Cloud",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ServerPlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ServerPlusOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateCommerceIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateCommerceFilledIconInfos(),
            IconThemeType.Outlined => CreateCommerceOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateCommerceFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "BriefcaseFilled",
                Category = "Commerce",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.BriefcaseFilled),
                Creator = () => new AtomUI.Icons.Gravity.BriefcaseFilled()
            },
        ];
    }

    private static List<IconInfo> CreateCommerceOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "BoxOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BoxOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BoxOutlined()
            },
            new IconInfo {
                Name = "Boxes3Outlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Boxes3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Boxes3Outlined()
            },
            new IconInfo {
                Name = "BriefcaseOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BriefcaseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BriefcaseOutlined()
            },
            new IconInfo {
                Name = "CreditCardOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CreditCardOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CreditCardOutlined()
            },
            new IconInfo {
                Name = "CrownDiamondOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CrownDiamondOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CrownDiamondOutlined()
            },
            new IconInfo {
                Name = "FactoryOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FactoryOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FactoryOutlined()
            },
            new IconInfo {
                Name = "GemOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GemOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GemOutlined()
            },
            new IconInfo {
                Name = "GiftOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GiftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GiftOutlined()
            },
            new IconInfo {
                Name = "OfficeBadgeOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.OfficeBadgeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.OfficeBadgeOutlined()
            },
            new IconInfo {
                Name = "ReceiptOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ReceiptOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ReceiptOutlined()
            },
            new IconInfo {
                Name = "SackOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SackOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SackOutlined()
            },
            new IconInfo {
                Name = "SealCheckOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SealCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SealCheckOutlined()
            },
            new IconInfo {
                Name = "SealPercentOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SealPercentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SealPercentOutlined()
            },
            new IconInfo {
                Name = "ShoppingBagOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShoppingBagOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShoppingBagOutlined()
            },
            new IconInfo {
                Name = "ShoppingBasketOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShoppingBasketOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShoppingBasketOutlined()
            },
            new IconInfo {
                Name = "ShoppingCartOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShoppingCartOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShoppingCartOutlined()
            },
            new IconInfo {
                Name = "SuitcaseOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SuitcaseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SuitcaseOutlined()
            },
            new IconInfo {
                Name = "TShirtOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TShirtOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TShirtOutlined()
            },
            new IconInfo {
                Name = "TagOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TagOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TagOutlined()
            },
            new IconInfo {
                Name = "TagDollarOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TagDollarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TagDollarOutlined()
            },
            new IconInfo {
                Name = "TagRubleOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TagRubleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TagRubleOutlined()
            },
            new IconInfo {
                Name = "TagsOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TagsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TagsOutlined()
            },
            new IconInfo {
                Name = "TicketOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TicketOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TicketOutlined()
            },
            new IconInfo {
                Name = "TrolleyOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TrolleyOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TrolleyOutlined()
            },
            new IconInfo {
                Name = "WalletOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.WalletOutlined),
                Creator = () => new AtomUI.Icons.Gravity.WalletOutlined()
            },
            new IconInfo {
                Name = "WalletDotOutlined",
                Category = "Commerce",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.WalletDotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.WalletDotOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateCommunicationIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateCommunicationFilledIconInfos(),
            IconThemeType.Outlined => CreateCommunicationOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateCommunicationFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "CommentFilled",
                Category = "Communication",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CommentFilled),
                Creator = () => new AtomUI.Icons.Gravity.CommentFilled()
            },
        ];
    }

    private static List<IconInfo> CreateCommunicationOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "AntennaSignalOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AntennaSignalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AntennaSignalOutlined()
            },
            new IconInfo {
                Name = "AtOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AtOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AtOutlined()
            },
            new IconInfo {
                Name = "BroadcastSignalOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BroadcastSignalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BroadcastSignalOutlined()
            },
            new IconInfo {
                Name = "CircleLinkOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLinkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLinkOutlined()
            },
            new IconInfo {
                Name = "CommentOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CommentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CommentOutlined()
            },
            new IconInfo {
                Name = "CommentDotOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CommentDotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CommentDotOutlined()
            },
            new IconInfo {
                Name = "CommentPlusOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CommentPlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CommentPlusOutlined()
            },
            new IconInfo {
                Name = "CommentSlashOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CommentSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CommentSlashOutlined()
            },
            new IconInfo {
                Name = "CommentsOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CommentsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CommentsOutlined()
            },
            new IconInfo {
                Name = "CommentsDotOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CommentsDotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CommentsDotOutlined()
            },
            new IconInfo {
                Name = "EnvelopeOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EnvelopeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EnvelopeOutlined()
            },
            new IconInfo {
                Name = "EnvelopeOpenOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EnvelopeOpenOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EnvelopeOpenOutlined()
            },
            new IconInfo {
                Name = "EnvelopeOpenXmarkOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EnvelopeOpenXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EnvelopeOpenXmarkOutlined()
            },
            new IconInfo {
                Name = "HandsetOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandsetOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandsetOutlined()
            },
            new IconInfo {
                Name = "HandsetArrowInOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandsetArrowInOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandsetArrowInOutlined()
            },
            new IconInfo {
                Name = "HandsetArrowOutOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandsetArrowOutOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandsetArrowOutOutlined()
            },
            new IconInfo {
                Name = "LinkOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LinkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LinkOutlined()
            },
            new IconInfo {
                Name = "LinkSlashOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LinkSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LinkSlashOutlined()
            },
            new IconInfo {
                Name = "MegaphoneOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MegaphoneOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MegaphoneOutlined()
            },
            new IconInfo {
                Name = "MicrophoneOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MicrophoneOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MicrophoneOutlined()
            },
            new IconInfo {
                Name = "MicrophoneSlashOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MicrophoneSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MicrophoneSlashOutlined()
            },
            new IconInfo {
                Name = "PaperPlaneOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PaperPlaneOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PaperPlaneOutlined()
            },
            new IconInfo {
                Name = "PersonSpeakerOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonSpeakerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonSpeakerOutlined()
            },
            new IconInfo {
                Name = "QrCodeOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.QrCodeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.QrCodeOutlined()
            },
            new IconInfo {
                Name = "SignalOutlined",
                Category = "Communication",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SignalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SignalOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateDevelopmentIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateDevelopmentOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateDevelopmentOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "BugOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BugOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BugOutlined()
            },
            new IconInfo {
                Name = "BulbOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BulbOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BulbOutlined()
            },
            new IconInfo {
                Name = "CircleTreeOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleTreeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleTreeOutlined()
            },
            new IconInfo {
                Name = "CodeOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeOutlined()
            },
            new IconInfo {
                Name = "CodeCommitOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeCommitOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeCommitOutlined()
            },
            new IconInfo {
                Name = "CodeCommitHorizontalOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeCommitHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeCommitHorizontalOutlined()
            },
            new IconInfo {
                Name = "CodeCommitsOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeCommitsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeCommitsOutlined()
            },
            new IconInfo {
                Name = "CodeCompareOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeCompareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeCompareOutlined()
            },
            new IconInfo {
                Name = "CodeForkOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeForkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeForkOutlined()
            },
            new IconInfo {
                Name = "CodeMergeOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeMergeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeMergeOutlined()
            },
            new IconInfo {
                Name = "CodePullRequestOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodePullRequestOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodePullRequestOutlined()
            },
            new IconInfo {
                Name = "CodePullRequestArrowLeftOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodePullRequestArrowLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodePullRequestArrowLeftOutlined()
            },
            new IconInfo {
                Name = "CodePullRequestArrowRightOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodePullRequestArrowRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodePullRequestArrowRightOutlined()
            },
            new IconInfo {
                Name = "CodePullRequestCheckOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodePullRequestCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodePullRequestCheckOutlined()
            },
            new IconInfo {
                Name = "CodePullRequestXmarkOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodePullRequestXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodePullRequestXmarkOutlined()
            },
            new IconInfo {
                Name = "CodeTrunkOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CodeTrunkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CodeTrunkOutlined()
            },
            new IconInfo {
                Name = "CurlyBracketsOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CurlyBracketsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CurlyBracketsOutlined()
            },
            new IconInfo {
                Name = "CurlyBracketsFunctionOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CurlyBracketsFunctionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CurlyBracketsFunctionOutlined()
            },
            new IconInfo {
                Name = "CurlyBracketsLockOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CurlyBracketsLockOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CurlyBracketsLockOutlined()
            },
            new IconInfo {
                Name = "FileCodeOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileCodeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileCodeOutlined()
            },
            new IconInfo {
                Name = "FolderCodeOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderCodeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderCodeOutlined()
            },
            new IconInfo {
                Name = "FolderFlowsOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderFlowsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderFlowsOutlined()
            },
            new IconInfo {
                Name = "FolderTreeOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderTreeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderTreeOutlined()
            },
            new IconInfo {
                Name = "FunctionOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FunctionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FunctionOutlined()
            },
            new IconInfo {
                Name = "GearOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GearOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GearOutlined()
            },
            new IconInfo {
                Name = "GearBranchesOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GearBranchesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GearBranchesOutlined()
            },
            new IconInfo {
                Name = "GearDotOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GearDotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GearDotOutlined()
            },
            new IconInfo {
                Name = "GearPlayOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GearPlayOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GearPlayOutlined()
            },
            new IconInfo {
                Name = "HashtagOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HashtagOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HashtagOutlined()
            },
            new IconInfo {
                Name = "HierarchyOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HierarchyOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HierarchyOutlined()
            },
            new IconInfo {
                Name = "NutHexOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.NutHexOutlined),
                Creator = () => new AtomUI.Icons.Gravity.NutHexOutlined()
            },
            new IconInfo {
                Name = "PersonGearOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonGearOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonGearOutlined()
            },
            new IconInfo {
                Name = "PersonNutHexOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonNutHexOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonNutHexOutlined()
            },
            new IconInfo {
                Name = "PipelineOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PipelineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PipelineOutlined()
            },
            new IconInfo {
                Name = "RoundBracketsOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.RoundBracketsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.RoundBracketsOutlined()
            },
            new IconInfo {
                Name = "SquareBracketsOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareBracketsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareBracketsOutlined()
            },
            new IconInfo {
                Name = "SquareBracketsLetterAOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareBracketsLetterAOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareBracketsLetterAOutlined()
            },
            new IconInfo {
                Name = "SquareHashtagOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareHashtagOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareHashtagOutlined()
            },
            new IconInfo {
                Name = "TerminalOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TerminalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TerminalOutlined()
            },
            new IconInfo {
                Name = "TerminalLineOutlined",
                Category = "Development",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TerminalLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TerminalLineOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateDevicesIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateDevicesOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateDevicesOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CpuOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CpuOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CpuOutlined()
            },
            new IconInfo {
                Name = "CpusOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CpusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CpusOutlined()
            },
            new IconInfo {
                Name = "DisplayOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DisplayOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DisplayOutlined()
            },
            new IconInfo {
                Name = "GpuOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GpuOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GpuOutlined()
            },
            new IconInfo {
                Name = "HeadphonesOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HeadphonesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HeadphonesOutlined()
            },
            new IconInfo {
                Name = "KeyboardOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.KeyboardOutlined),
                Creator = () => new AtomUI.Icons.Gravity.KeyboardOutlined()
            },
            new IconInfo {
                Name = "PlugConnectionOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PlugConnectionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PlugConnectionOutlined()
            },
            new IconInfo {
                Name = "PlugWireOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PlugWireOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PlugWireOutlined()
            },
            new IconInfo {
                Name = "PowerOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PowerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PowerOutlined()
            },
            new IconInfo {
                Name = "PrinterOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PrinterOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PrinterOutlined()
            },
            new IconInfo {
                Name = "SmartphoneOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SmartphoneOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SmartphoneOutlined()
            },
            new IconInfo {
                Name = "TvOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TvOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TvOutlined()
            },
            new IconInfo {
                Name = "TvRetroOutlined",
                Category = "Devices",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TvRetroOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TvRetroOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateEditorIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateEditorFilledIconInfos(),
            IconThemeType.Outlined => CreateEditorOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateEditorFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "SparklesFilled",
                Category = "Editor",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.SparklesFilled),
                Creator = () => new AtomUI.Icons.Gravity.SparklesFilled()
            },
        ];
    }

    private static List<IconInfo> CreateEditorOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "ApertureOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ApertureOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ApertureOutlined()
            },
            new IconInfo {
                Name = "BrushOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BrushOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BrushOutlined()
            },
            new IconInfo {
                Name = "BucketOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BucketOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BucketOutlined()
            },
            new IconInfo {
                Name = "BucketPaintOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BucketPaintOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BucketPaintOutlined()
            },
            new IconInfo {
                Name = "CameraOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CameraOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CameraOutlined()
            },
            new IconInfo {
                Name = "CopyOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyOutlined()
            },
            new IconInfo {
                Name = "CopyCheckOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyCheckOutlined()
            },
            new IconInfo {
                Name = "CopyCheckXmarkOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyCheckXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyCheckXmarkOutlined()
            },
            new IconInfo {
                Name = "CopyMinusOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyMinusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyMinusOutlined()
            },
            new IconInfo {
                Name = "CopyPictureOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyPictureOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyPictureOutlined()
            },
            new IconInfo {
                Name = "CopyPlusOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyPlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyPlusOutlined()
            },
            new IconInfo {
                Name = "CopyTransparentOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyTransparentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyTransparentOutlined()
            },
            new IconInfo {
                Name = "CopyXmarkOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CopyXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CopyXmarkOutlined()
            },
            new IconInfo {
                Name = "CropOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CropOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CropOutlined()
            },
            new IconInfo {
                Name = "EraserOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EraserOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EraserOutlined()
            },
            new IconInfo {
                Name = "FilmstripOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FilmstripOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FilmstripOutlined()
            },
            new IconInfo {
                Name = "FlaskOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FlaskOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FlaskOutlined()
            },
            new IconInfo {
                Name = "FontCursorOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FontCursorOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FontCursorOutlined()
            },
            new IconInfo {
                Name = "LayersOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayersOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayersOutlined()
            },
            new IconInfo {
                Name = "Layers3DiagonalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Layers3DiagonalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Layers3DiagonalOutlined()
            },
            new IconInfo {
                Name = "LayersVerticalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayersVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayersVerticalOutlined()
            },
            new IconInfo {
                Name = "MagicWandOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MagicWandOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MagicWandOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignBottomOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignBottomOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignBottomOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignCenterHorizontalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignCenterHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignCenterHorizontalOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignCenterVerticalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignCenterVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignCenterVerticalOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignJustifyHorizontalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignJustifyHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignJustifyHorizontalOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignJustifyVerticalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignJustifyVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignJustifyVerticalOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignLeftOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignLeftOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignRightOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignRightOutlined()
            },
            new IconInfo {
                Name = "ObjectAlignTopOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectAlignTopOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectAlignTopOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignBottomOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignBottomOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignBottomOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignCenterHorizontalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignCenterHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignCenterHorizontalOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignCenterVerticalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignCenterVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignCenterVerticalOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignJustifyHorizontalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignJustifyHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignJustifyHorizontalOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignJustifyVerticalOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignJustifyVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignJustifyVerticalOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignLeftOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignLeftOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignRightOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignRightOutlined()
            },
            new IconInfo {
                Name = "ObjectsAlignTopOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ObjectsAlignTopOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ObjectsAlignTopOutlined()
            },
            new IconInfo {
                Name = "PaintbrushOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PaintbrushOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PaintbrushOutlined()
            },
            new IconInfo {
                Name = "PaletteOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PaletteOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PaletteOutlined()
            },
            new IconInfo {
                Name = "PencilOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PencilOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PencilOutlined()
            },
            new IconInfo {
                Name = "PencilToLineOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PencilToLineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PencilToLineOutlined()
            },
            new IconInfo {
                Name = "PencilToSquareOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PencilToSquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PencilToSquareOutlined()
            },
            new IconInfo {
                Name = "PersonPencilOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonPencilOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonPencilOutlined()
            },
            new IconInfo {
                Name = "PictureOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PictureOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PictureOutlined()
            },
            new IconInfo {
                Name = "ScissorsOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ScissorsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ScissorsOutlined()
            },
            new IconInfo {
                Name = "SparklesOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SparklesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SparklesOutlined()
            },
            new IconInfo {
                Name = "StickerOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.StickerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.StickerOutlined()
            },
            new IconInfo {
                Name = "VectorCircleOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VectorCircleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VectorCircleOutlined()
            },
            new IconInfo {
                Name = "VectorSquareOutlined",
                Category = "Editor",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VectorSquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VectorSquareOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateFilesIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateFilesFilledIconInfos(),
            IconThemeType.Outlined => CreateFilesOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateFilesFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "BookmarkFilled",
                Category = "Files",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.BookmarkFilled),
                Creator = () => new AtomUI.Icons.Gravity.BookmarkFilled()
            },
            new IconInfo {
                Name = "FolderFilled",
                Category = "Files",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.FolderFilled),
                Creator = () => new AtomUI.Icons.Gravity.FolderFilled()
            },
            new IconInfo {
                Name = "FolderOpenFilled",
                Category = "Files",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.FolderOpenFilled),
                Creator = () => new AtomUI.Icons.Gravity.FolderOpenFilled()
            },
        ];
    }

    private static List<IconInfo> CreateFilesOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "ArchiveOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ArchiveOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ArchiveOutlined()
            },
            new IconInfo {
                Name = "BookOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BookOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BookOutlined()
            },
            new IconInfo {
                Name = "BookOpenOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BookOpenOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BookOpenOutlined()
            },
            new IconInfo {
                Name = "BookmarkOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BookmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BookmarkOutlined()
            },
            new IconInfo {
                Name = "BooksOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BooksOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BooksOutlined()
            },
            new IconInfo {
                Name = "DeleteOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DeleteOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DeleteOutlined()
            },
            new IconInfo {
                Name = "FileOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileOutlined()
            },
            new IconInfo {
                Name = "FileCheckOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileCheckOutlined()
            },
            new IconInfo {
                Name = "FileDollarOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileDollarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileDollarOutlined()
            },
            new IconInfo {
                Name = "FileExclamationOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileExclamationOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileExclamationOutlined()
            },
            new IconInfo {
                Name = "FileLetterPOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileLetterPOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileLetterPOutlined()
            },
            new IconInfo {
                Name = "FileLetterWOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileLetterWOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileLetterWOutlined()
            },
            new IconInfo {
                Name = "FileLetterXOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileLetterXOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileLetterXOutlined()
            },
            new IconInfo {
                Name = "FileMagnifierOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileMagnifierOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileMagnifierOutlined()
            },
            new IconInfo {
                Name = "FileMinusOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileMinusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileMinusOutlined()
            },
            new IconInfo {
                Name = "FilePlusOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FilePlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FilePlusOutlined()
            },
            new IconInfo {
                Name = "FileQuestionOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileQuestionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileQuestionOutlined()
            },
            new IconInfo {
                Name = "FileRubleOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileRubleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileRubleOutlined()
            },
            new IconInfo {
                Name = "FileTextOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileTextOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileTextOutlined()
            },
            new IconInfo {
                Name = "FileXmarkOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileXmarkOutlined()
            },
            new IconInfo {
                Name = "FileZipperOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FileZipperOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FileZipperOutlined()
            },
            new IconInfo {
                Name = "FilesOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FilesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FilesOutlined()
            },
            new IconInfo {
                Name = "FolderOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderOutlined()
            },
            new IconInfo {
                Name = "FolderCheckOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderCheckOutlined()
            },
            new IconInfo {
                Name = "FolderExclamationOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderExclamationOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderExclamationOutlined()
            },
            new IconInfo {
                Name = "FolderHouseOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderHouseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderHouseOutlined()
            },
            new IconInfo {
                Name = "FolderKeyholeOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderKeyholeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderKeyholeOutlined()
            },
            new IconInfo {
                Name = "FolderLockOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderLockOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderLockOutlined()
            },
            new IconInfo {
                Name = "FolderMagnifierOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderMagnifierOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderMagnifierOutlined()
            },
            new IconInfo {
                Name = "FolderOpenOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderOpenOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderOpenOutlined()
            },
            new IconInfo {
                Name = "FolderPlusOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FolderPlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FolderPlusOutlined()
            },
            new IconInfo {
                Name = "FoldersOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FoldersOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FoldersOutlined()
            },
            new IconInfo {
                Name = "PaperclipOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PaperclipOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PaperclipOutlined()
            },
            new IconInfo {
                Name = "PassportOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PassportOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PassportOutlined()
            },
            new IconInfo {
                Name = "TrashBinOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TrashBinOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TrashBinOutlined()
            },
            new IconInfo {
                Name = "TrayOutlined",
                Category = "Files",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TrayOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TrayOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateFinanceIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateFinanceOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateFinanceOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CircleDollarOutlined",
                Category = "Finance",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleDollarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleDollarOutlined()
            },
            new IconInfo {
                Name = "CircleRubleOutlined",
                Category = "Finance",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleRubleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleRubleOutlined()
            },
            new IconInfo {
                Name = "PercentOutlined",
                Category = "Finance",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PercentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PercentOutlined()
            },
            new IconInfo {
                Name = "ScalesBalancedOutlined",
                Category = "Finance",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ScalesBalancedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ScalesBalancedOutlined()
            },
            new IconInfo {
                Name = "ScalesUnbalancedOutlined",
                Category = "Finance",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ScalesUnbalancedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ScalesUnbalancedOutlined()
            },
            new IconInfo {
                Name = "VaultOutlined",
                Category = "Finance",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VaultOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VaultOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateFoodIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateFoodOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateFoodOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CherryOutlined",
                Category = "Food",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CherryOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CherryOutlined()
            },
            new IconInfo {
                Name = "CupOutlined",
                Category = "Food",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CupOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CupOutlined()
            },
            new IconInfo {
                Name = "MugOutlined",
                Category = "Food",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MugOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MugOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateGamesIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateGamesFilledIconInfos(),
            IconThemeType.Outlined => CreateGamesOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateGamesFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "StarFilled",
                Category = "Games",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.StarFilled),
                Creator = () => new AtomUI.Icons.Gravity.StarFilled()
            },
        ];
    }

    private static List<IconInfo> CreateGamesOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CardClubOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CardClubOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CardClubOutlined()
            },
            new IconInfo {
                Name = "CardDiamondOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CardDiamondOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CardDiamondOutlined()
            },
            new IconInfo {
                Name = "CardHeartOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CardHeartOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CardHeartOutlined()
            },
            new IconInfo {
                Name = "CardSpadeOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CardSpadeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CardSpadeOutlined()
            },
            new IconInfo {
                Name = "Dice1Outlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Dice1Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Dice1Outlined()
            },
            new IconInfo {
                Name = "Dice2Outlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Dice2Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Dice2Outlined()
            },
            new IconInfo {
                Name = "Dice3Outlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Dice3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Dice3Outlined()
            },
            new IconInfo {
                Name = "Dice4Outlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Dice4Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Dice4Outlined()
            },
            new IconInfo {
                Name = "Dice5Outlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Dice5Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Dice5Outlined()
            },
            new IconInfo {
                Name = "Dice6Outlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Dice6Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Dice6Outlined()
            },
            new IconInfo {
                Name = "FaceAlienOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceAlienOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceAlienOutlined()
            },
            new IconInfo {
                Name = "FaceRobotOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceRobotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceRobotOutlined()
            },
            new IconInfo {
                Name = "FaceRobotSmileOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceRobotSmileOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceRobotSmileOutlined()
            },
            new IconInfo {
                Name = "GhostOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GhostOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GhostOutlined()
            },
            new IconInfo {
                Name = "MedalOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MedalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MedalOutlined()
            },
            new IconInfo {
                Name = "PuzzleOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PuzzleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PuzzleOutlined()
            },
            new IconInfo {
                Name = "SkullOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SkullOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SkullOutlined()
            },
            new IconInfo {
                Name = "StarOutlined",
                Category = "Games",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.StarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.StarOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateHealthIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateHealthFilledIconInfos(),
            IconThemeType.Outlined => CreateHealthOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateHealthFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "HeartFilled",
                Category = "Health",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.HeartFilled),
                Creator = () => new AtomUI.Icons.Gravity.HeartFilled()
            },
        ];
    }

    private static List<IconInfo> CreateHealthOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "HeartOutlined",
                Category = "Health",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HeartOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HeartOutlined()
            },
            new IconInfo {
                Name = "HeartCrackOutlined",
                Category = "Health",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HeartCrackOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HeartCrackOutlined()
            },
            new IconInfo {
                Name = "LifeRingOutlined",
                Category = "Health",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LifeRingOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LifeRingOutlined()
            },
            new IconInfo {
                Name = "MicroscopeOutlined",
                Category = "Health",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MicroscopeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MicroscopeOutlined()
            },
            new IconInfo {
                Name = "MoleculeOutlined",
                Category = "Health",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MoleculeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MoleculeOutlined()
            },
            new IconInfo {
                Name = "PillOutlined",
                Category = "Health",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PillOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PillOutlined()
            },
            new IconInfo {
                Name = "StethoscopeOutlined",
                Category = "Health",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.StethoscopeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.StethoscopeOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateLayoutIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateLayoutFilledIconInfos(),
            IconThemeType.Outlined => CreateLayoutOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateLayoutFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "LayoutHeaderCellsLargeFilled",
                Category = "Layout",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderCellsLargeFilled),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderCellsLargeFilled()
            },
            new IconInfo {
                Name = "PinFilled",
                Category = "Layout",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.PinFilled),
                Creator = () => new AtomUI.Icons.Gravity.PinFilled()
            },
            new IconInfo {
                Name = "PinSlashFilled",
                Category = "Layout",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.PinSlashFilled),
                Creator = () => new AtomUI.Icons.Gravity.PinSlashFilled()
            },
        ];
    }

    private static List<IconInfo> CreateLayoutOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "BarsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsOutlined()
            },
            new IconInfo {
                Name = "BarsAscendingAlignCenterOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsAscendingAlignCenterOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsAscendingAlignCenterOutlined()
            },
            new IconInfo {
                Name = "BarsAscendingAlignLeftOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsAscendingAlignLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsAscendingAlignLeftOutlined()
            },
            new IconInfo {
                Name = "BarsAscendingAlignRightOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsAscendingAlignRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsAscendingAlignRightOutlined()
            },
            new IconInfo {
                Name = "BarsDescendingAlignCenterOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsDescendingAlignCenterOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsDescendingAlignCenterOutlined()
            },
            new IconInfo {
                Name = "BarsDescendingAlignLeftOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsDescendingAlignLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsDescendingAlignLeftOutlined()
            },
            new IconInfo {
                Name = "BarsDescendingAlignRightOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsDescendingAlignRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsDescendingAlignRightOutlined()
            },
            new IconInfo {
                Name = "BarsPlayOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsPlayOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsPlayOutlined()
            },
            new IconInfo {
                Name = "BarsUnalignedOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BarsUnalignedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BarsUnalignedOutlined()
            },
            new IconInfo {
                Name = "Dots9Outlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Dots9Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Dots9Outlined()
            },
            new IconInfo {
                Name = "EllipsisOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EllipsisOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EllipsisOutlined()
            },
            new IconInfo {
                Name = "EllipsisVerticalOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EllipsisVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EllipsisVerticalOutlined()
            },
            new IconInfo {
                Name = "FrameOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FrameOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FrameOutlined()
            },
            new IconInfo {
                Name = "FramesOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FramesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FramesOutlined()
            },
            new IconInfo {
                Name = "FunnelOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FunnelOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FunnelOutlined()
            },
            new IconInfo {
                Name = "FunnelXmarkOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FunnelXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FunnelXmarkOutlined()
            },
            new IconInfo {
                Name = "GripOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GripOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GripOutlined()
            },
            new IconInfo {
                Name = "GripHorizontalOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GripHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GripHorizontalOutlined()
            },
            new IconInfo {
                Name = "LayoutCellsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutCellsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutCellsOutlined()
            },
            new IconInfo {
                Name = "LayoutCellsLargeOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutCellsLargeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutCellsLargeOutlined()
            },
            new IconInfo {
                Name = "LayoutColumnsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutColumnsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutColumnsOutlined()
            },
            new IconInfo {
                Name = "LayoutColumns3Outlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutColumns3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutColumns3Outlined()
            },
            new IconInfo {
                Name = "LayoutFooterOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutFooterOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutFooterOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderCellsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderCellsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderCellsOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderCellsLargeOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderCellsLargeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderCellsLargeOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderCellsLargeLetterDOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderCellsLargeLetterDOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderCellsLargeLetterDOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderCellsLargeThunderboltOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderCellsLargeThunderboltOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderCellsLargeThunderboltOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderColumnsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderColumnsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderColumnsOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderCursorOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderCursorOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderCursorOutlined()
            },
            new IconInfo {
                Name = "LayoutHeaderSideContentOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutHeaderSideContentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutHeaderSideContentOutlined()
            },
            new IconInfo {
                Name = "LayoutListOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutListOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutListOutlined()
            },
            new IconInfo {
                Name = "LayoutRowsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutRowsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutRowsOutlined()
            },
            new IconInfo {
                Name = "LayoutRows3Outlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutRows3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutRows3Outlined()
            },
            new IconInfo {
                Name = "LayoutSideContentOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSideContentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSideContentOutlined()
            },
            new IconInfo {
                Name = "LayoutSideContentLeftOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSideContentLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSideContentLeftOutlined()
            },
            new IconInfo {
                Name = "LayoutSideContentRightOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSideContentRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSideContentRightOutlined()
            },
            new IconInfo {
                Name = "LayoutSplitColumnsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSplitColumnsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSplitColumnsOutlined()
            },
            new IconInfo {
                Name = "LayoutSplitColumns3Outlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSplitColumns3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSplitColumns3Outlined()
            },
            new IconInfo {
                Name = "LayoutSplitRowsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSplitRowsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSplitRowsOutlined()
            },
            new IconInfo {
                Name = "LayoutSplitSideContentLeftOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSplitSideContentLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSplitSideContentLeftOutlined()
            },
            new IconInfo {
                Name = "LayoutSplitSideContentRightOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutSplitSideContentRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutSplitSideContentRightOutlined()
            },
            new IconInfo {
                Name = "LayoutTabsOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LayoutTabsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LayoutTabsOutlined()
            },
            new IconInfo {
                Name = "ListCheckOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ListCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ListCheckOutlined()
            },
            new IconInfo {
                Name = "ListCheckLockOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ListCheckLockOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ListCheckLockOutlined()
            },
            new IconInfo {
                Name = "ListOlOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ListOlOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ListOlOutlined()
            },
            new IconInfo {
                Name = "ListUlOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ListUlOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ListUlOutlined()
            },
            new IconInfo {
                Name = "PinOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PinOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PinOutlined()
            },
            new IconInfo {
                Name = "PinSlashOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PinSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PinSlashOutlined()
            },
            new IconInfo {
                Name = "Rectangles4Outlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Rectangles4Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Rectangles4Outlined()
            },
            new IconInfo {
                Name = "SlidersOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SlidersOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SlidersOutlined()
            },
            new IconInfo {
                Name = "SlidersVerticalOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SlidersVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SlidersVerticalOutlined()
            },
            new IconInfo {
                Name = "SquareArticleOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareArticleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareArticleOutlined()
            },
            new IconInfo {
                Name = "SquareListUlOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareListUlOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareListUlOutlined()
            },
            new IconInfo {
                Name = "TextAlignCenterOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TextAlignCenterOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TextAlignCenterOutlined()
            },
            new IconInfo {
                Name = "TextAlignJustifyOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TextAlignJustifyOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TextAlignJustifyOutlined()
            },
            new IconInfo {
                Name = "TextAlignLeftOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TextAlignLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TextAlignLeftOutlined()
            },
            new IconInfo {
                Name = "TextAlignRightOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TextAlignRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TextAlignRightOutlined()
            },
            new IconInfo {
                Name = "TextIndentOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TextIndentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TextIndentOutlined()
            },
            new IconInfo {
                Name = "TextOutdentOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TextOutdentOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TextOutdentOutlined()
            },
            new IconInfo {
                Name = "ToggleOffOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ToggleOffOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ToggleOffOutlined()
            },
            new IconInfo {
                Name = "ToggleOnOutlined",
                Category = "Layout",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ToggleOnOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ToggleOnOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateMapsIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateMapsFilledIconInfos(),
            IconThemeType.Outlined => CreateMapsOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateMapsFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "GeoFilled",
                Category = "Maps",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.GeoFilled),
                Creator = () => new AtomUI.Icons.Gravity.GeoFilled()
            },
            new IconInfo {
                Name = "HouseFilled",
                Category = "Maps",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.HouseFilled),
                Creator = () => new AtomUI.Icons.Gravity.HouseFilled()
            },
        ];
    }

    private static List<IconInfo> CreateMapsOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CompassOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CompassOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CompassOutlined()
            },
            new IconInfo {
                Name = "GeoOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GeoOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GeoOutlined()
            },
            new IconInfo {
                Name = "GeoDotsOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GeoDotsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GeoDotsOutlined()
            },
            new IconInfo {
                Name = "GeoPinOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GeoPinOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GeoPinOutlined()
            },
            new IconInfo {
                Name = "GeoPolygonsOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GeoPolygonsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GeoPolygonsOutlined()
            },
            new IconInfo {
                Name = "GlobeOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GlobeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GlobeOutlined()
            },
            new IconInfo {
                Name = "HouseOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HouseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HouseOutlined()
            },
            new IconInfo {
                Name = "MapPinOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MapPinOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MapPinOutlined()
            },
            new IconInfo {
                Name = "MapPinMinusOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MapPinMinusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MapPinMinusOutlined()
            },
            new IconInfo {
                Name = "MapPinPlusOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MapPinPlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MapPinPlusOutlined()
            },
            new IconInfo {
                Name = "PersonPlanetEarthOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonPlanetEarthOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonPlanetEarthOutlined()
            },
            new IconInfo {
                Name = "PlanetEarthOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PlanetEarthOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PlanetEarthOutlined()
            },
            new IconInfo {
                Name = "RouteOutlined",
                Category = "Maps",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.RouteOutlined),
                Creator = () => new AtomUI.Icons.Gravity.RouteOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateMathIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateMathOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateMathOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "AlmostEqualOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AlmostEqualOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AlmostEqualOutlined()
            },
            new IconInfo {
                Name = "CalculatorOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CalculatorOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CalculatorOutlined()
            },
            new IconInfo {
                Name = "EqualOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EqualOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EqualOutlined()
            },
            new IconInfo {
                Name = "MathIntersectionShapeOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MathIntersectionShapeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MathIntersectionShapeOutlined()
            },
            new IconInfo {
                Name = "MathOperationsOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MathOperationsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MathOperationsOutlined()
            },
            new IconInfo {
                Name = "MathUnionShapeOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MathUnionShapeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MathUnionShapeOutlined()
            },
            new IconInfo {
                Name = "MinusOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MinusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MinusOutlined()
            },
            new IconInfo {
                Name = "PlusOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PlusOutlined()
            },
            new IconInfo {
                Name = "SuperscriptOutlined",
                Category = "Math",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SuperscriptOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SuperscriptOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateMediaIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateMediaFilledIconInfos(),
            IconThemeType.Outlined => CreateMediaOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateMediaFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "BackwardStepFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.BackwardStepFilled),
                Creator = () => new AtomUI.Icons.Gravity.BackwardStepFilled()
            },
            new IconInfo {
                Name = "CirclePauseFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CirclePauseFilled),
                Creator = () => new AtomUI.Icons.Gravity.CirclePauseFilled()
            },
            new IconInfo {
                Name = "CirclePlayFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CirclePlayFilled),
                Creator = () => new AtomUI.Icons.Gravity.CirclePlayFilled()
            },
            new IconInfo {
                Name = "CircleStopFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleStopFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleStopFilled()
            },
            new IconInfo {
                Name = "ForwardStepFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.ForwardStepFilled),
                Creator = () => new AtomUI.Icons.Gravity.ForwardStepFilled()
            },
            new IconInfo {
                Name = "PauseFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.PauseFilled),
                Creator = () => new AtomUI.Icons.Gravity.PauseFilled()
            },
            new IconInfo {
                Name = "PlayFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.PlayFilled),
                Creator = () => new AtomUI.Icons.Gravity.PlayFilled()
            },
            new IconInfo {
                Name = "StopFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.StopFilled),
                Creator = () => new AtomUI.Icons.Gravity.StopFilled()
            },
            new IconInfo {
                Name = "VolumeFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeFilled),
                Creator = () => new AtomUI.Icons.Gravity.VolumeFilled()
            },
            new IconInfo {
                Name = "VolumeLowFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeLowFilled),
                Creator = () => new AtomUI.Icons.Gravity.VolumeLowFilled()
            },
            new IconInfo {
                Name = "VolumeOffFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeOffFilled),
                Creator = () => new AtomUI.Icons.Gravity.VolumeOffFilled()
            },
            new IconInfo {
                Name = "VolumeSlashFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeSlashFilled),
                Creator = () => new AtomUI.Icons.Gravity.VolumeSlashFilled()
            },
            new IconInfo {
                Name = "VolumeXmarkFilled",
                Category = "Media",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeXmarkFilled),
                Creator = () => new AtomUI.Icons.Gravity.VolumeXmarkFilled()
            },
        ];
    }

    private static List<IconInfo> CreateMediaOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "BackwardStepOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BackwardStepOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BackwardStepOutlined()
            },
            new IconInfo {
                Name = "CirclePauseOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CirclePauseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CirclePauseOutlined()
            },
            new IconInfo {
                Name = "CirclePlayOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CirclePlayOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CirclePlayOutlined()
            },
            new IconInfo {
                Name = "CircleStopOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleStopOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleStopOutlined()
            },
            new IconInfo {
                Name = "ForwardStepOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ForwardStepOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ForwardStepOutlined()
            },
            new IconInfo {
                Name = "MusicNoteOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MusicNoteOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MusicNoteOutlined()
            },
            new IconInfo {
                Name = "PauseOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PauseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PauseOutlined()
            },
            new IconInfo {
                Name = "PlayOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PlayOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PlayOutlined()
            },
            new IconInfo {
                Name = "StopOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.StopOutlined),
                Creator = () => new AtomUI.Icons.Gravity.StopOutlined()
            },
            new IconInfo {
                Name = "VideoOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VideoOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VideoOutlined()
            },
            new IconInfo {
                Name = "VolumeOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VolumeOutlined()
            },
            new IconInfo {
                Name = "VolumeLowOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeLowOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VolumeLowOutlined()
            },
            new IconInfo {
                Name = "VolumeOffOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeOffOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VolumeOffOutlined()
            },
            new IconInfo {
                Name = "VolumeSlashOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VolumeSlashOutlined()
            },
            new IconInfo {
                Name = "VolumeXmarkOutlined",
                Category = "Media",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.VolumeXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.VolumeXmarkOutlined()
            },
        ];
    }

    private static List<IconInfo> CreatePeopleIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreatePeopleFilledIconInfos(),
            IconThemeType.Outlined => CreatePeopleOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreatePeopleFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "PersonFilled",
                Category = "People",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.PersonFilled),
                Creator = () => new AtomUI.Icons.Gravity.PersonFilled()
            },
        ];
    }

    private static List<IconInfo> CreatePeopleOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "EarOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EarOutlined()
            },
            new IconInfo {
                Name = "EyeOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EyeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EyeOutlined()
            },
            new IconInfo {
                Name = "EyeClosedOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EyeClosedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EyeClosedOutlined()
            },
            new IconInfo {
                Name = "EyeDashedOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EyeDashedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EyeDashedOutlined()
            },
            new IconInfo {
                Name = "EyeSlashOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EyeSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EyeSlashOutlined()
            },
            new IconInfo {
                Name = "EyesLookLeftOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EyesLookLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EyesLookLeftOutlined()
            },
            new IconInfo {
                Name = "EyesLookRightOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.EyesLookRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.EyesLookRightOutlined()
            },
            new IconInfo {
                Name = "FaceAngryOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceAngryOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceAngryOutlined()
            },
            new IconInfo {
                Name = "FaceFunOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceFunOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceFunOutlined()
            },
            new IconInfo {
                Name = "FaceNeutralOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceNeutralOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceNeutralOutlined()
            },
            new IconInfo {
                Name = "FaceNeutralDashedOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceNeutralDashedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceNeutralDashedOutlined()
            },
            new IconInfo {
                Name = "FaceSadOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceSadOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceSadOutlined()
            },
            new IconInfo {
                Name = "FaceSmileOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceSmileOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceSmileOutlined()
            },
            new IconInfo {
                Name = "FaceSurpriseOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FaceSurpriseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FaceSurpriseOutlined()
            },
            new IconInfo {
                Name = "FingerprintOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FingerprintOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FingerprintOutlined()
            },
            new IconInfo {
                Name = "GraduationCapOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.GraduationCapOutlined),
                Creator = () => new AtomUI.Icons.Gravity.GraduationCapOutlined()
            },
            new IconInfo {
                Name = "HandOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandOutlined()
            },
            new IconInfo {
                Name = "HandOkOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandOkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandOkOutlined()
            },
            new IconInfo {
                Name = "HandPointDownOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandPointDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandPointDownOutlined()
            },
            new IconInfo {
                Name = "HandPointLeftOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandPointLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandPointLeftOutlined()
            },
            new IconInfo {
                Name = "HandPointRightOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandPointRightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandPointRightOutlined()
            },
            new IconInfo {
                Name = "HandPointUpOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandPointUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandPointUpOutlined()
            },
            new IconInfo {
                Name = "HandStopOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HandStopOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HandStopOutlined()
            },
            new IconInfo {
                Name = "PersonOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonOutlined()
            },
            new IconInfo {
                Name = "PersonMagnifierOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonMagnifierOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonMagnifierOutlined()
            },
            new IconInfo {
                Name = "PersonPlusOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonPlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonPlusOutlined()
            },
            new IconInfo {
                Name = "PersonWorkerOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonWorkerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonWorkerOutlined()
            },
            new IconInfo {
                Name = "PersonXmarkOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonXmarkOutlined()
            },
            new IconInfo {
                Name = "PersonsOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonsOutlined()
            },
            new IconInfo {
                Name = "PersonsLockOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PersonsLockOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PersonsLockOutlined()
            },
            new IconInfo {
                Name = "UniversalAccessOutlined",
                Category = "People",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.UniversalAccessOutlined),
                Creator = () => new AtomUI.Icons.Gravity.UniversalAccessOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateSecurityIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateSecurityFilledIconInfos(),
            IconThemeType.Outlined => CreateSecurityOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateSecurityFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "LockFilled",
                Category = "Security",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.LockFilled),
                Creator = () => new AtomUI.Icons.Gravity.LockFilled()
            },
            new IconInfo {
                Name = "LockOpenFilled",
                Category = "Security",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.LockOpenFilled),
                Creator = () => new AtomUI.Icons.Gravity.LockOpenFilled()
            },
        ];
    }

    private static List<IconInfo> CreateSecurityOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "KeyOutlined",
                Category = "Security",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.KeyOutlined),
                Creator = () => new AtomUI.Icons.Gravity.KeyOutlined()
            },
            new IconInfo {
                Name = "LockOutlined",
                Category = "Security",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LockOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LockOutlined()
            },
            new IconInfo {
                Name = "LockOpenOutlined",
                Category = "Security",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LockOpenOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LockOpenOutlined()
            },
            new IconInfo {
                Name = "ShieldOutlined",
                Category = "Security",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShieldOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShieldOutlined()
            },
            new IconInfo {
                Name = "ShieldCheckOutlined",
                Category = "Security",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShieldCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShieldCheckOutlined()
            },
            new IconInfo {
                Name = "ShieldExclamationOutlined",
                Category = "Security",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShieldExclamationOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShieldExclamationOutlined()
            },
            new IconInfo {
                Name = "ShieldKeyholeOutlined",
                Category = "Security",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ShieldKeyholeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ShieldKeyholeOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateShapesIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateShapesFilledIconInfos(),
            IconThemeType.Outlined => CreateShapesOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateShapesFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "CheckShapeFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CheckShapeFilled),
                Creator = () => new AtomUI.Icons.Gravity.CheckShapeFilled()
            },
            new IconInfo {
                Name = "CircleFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleFilled()
            },
            new IconInfo {
                Name = "DiamondFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.DiamondFilled),
                Creator = () => new AtomUI.Icons.Gravity.DiamondFilled()
            },
            new IconInfo {
                Name = "DiamondExclamationFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.DiamondExclamationFilled),
                Creator = () => new AtomUI.Icons.Gravity.DiamondExclamationFilled()
            },
            new IconInfo {
                Name = "ExclamationShapeFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.ExclamationShapeFilled),
                Creator = () => new AtomUI.Icons.Gravity.ExclamationShapeFilled()
            },
            new IconInfo {
                Name = "MinusShapeFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.MinusShapeFilled),
                Creator = () => new AtomUI.Icons.Gravity.MinusShapeFilled()
            },
            new IconInfo {
                Name = "PlusShapeFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.PlusShapeFilled),
                Creator = () => new AtomUI.Icons.Gravity.PlusShapeFilled()
            },
            new IconInfo {
                Name = "SquareFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.SquareFilled),
                Creator = () => new AtomUI.Icons.Gravity.SquareFilled()
            },
            new IconInfo {
                Name = "TriangleExclamationFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleExclamationFilled),
                Creator = () => new AtomUI.Icons.Gravity.TriangleExclamationFilled()
            },
            new IconInfo {
                Name = "XmarkShapeFilled",
                Category = "Shapes",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.XmarkShapeFilled),
                Creator = () => new AtomUI.Icons.Gravity.XmarkShapeFilled()
            },
        ];
    }

    private static List<IconInfo> CreateShapesOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CheckShapeOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CheckShapeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CheckShapeOutlined()
            },
            new IconInfo {
                Name = "CircleOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleOutlined()
            },
            new IconInfo {
                Name = "CircleDashedOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleDashedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleDashedOutlined()
            },
            new IconInfo {
                Name = "Circles3PlusOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Circles3PlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Circles3PlusOutlined()
            },
            new IconInfo {
                Name = "Circles4DiamondOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Circles4DiamondOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Circles4DiamondOutlined()
            },
            new IconInfo {
                Name = "Circles4SquareOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Circles4SquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Circles4SquareOutlined()
            },
            new IconInfo {
                Name = "Circles5RandomOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Circles5RandomOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Circles5RandomOutlined()
            },
            new IconInfo {
                Name = "CirclesConcentricOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CirclesConcentricOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CirclesConcentricOutlined()
            },
            new IconInfo {
                Name = "CirclesIntersectionOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CirclesIntersectionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CirclesIntersectionOutlined()
            },
            new IconInfo {
                Name = "CubeOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CubeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CubeOutlined()
            },
            new IconInfo {
                Name = "Cubes3Outlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Cubes3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Cubes3Outlined()
            },
            new IconInfo {
                Name = "Cubes3OverlapOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Cubes3OverlapOutlined),
                Creator = () => new AtomUI.Icons.Gravity.Cubes3OverlapOutlined()
            },
            new IconInfo {
                Name = "DiamondOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DiamondOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DiamondOutlined()
            },
            new IconInfo {
                Name = "DiamondExclamationOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DiamondExclamationOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DiamondExclamationOutlined()
            },
            new IconInfo {
                Name = "ExclamationShapeOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ExclamationShapeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ExclamationShapeOutlined()
            },
            new IconInfo {
                Name = "MinusShapeOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MinusShapeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MinusShapeOutlined()
            },
            new IconInfo {
                Name = "OctagonXmarkOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.OctagonXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.OctagonXmarkOutlined()
            },
            new IconInfo {
                Name = "PlusShapeOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PlusShapeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PlusShapeOutlined()
            },
            new IconInfo {
                Name = "Shapes3Outlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Shapes3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Shapes3Outlined()
            },
            new IconInfo {
                Name = "Shapes4Outlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Shapes4Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Shapes4Outlined()
            },
            new IconInfo {
                Name = "SphereOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SphereOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SphereOutlined()
            },
            new IconInfo {
                Name = "SquareOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareOutlined()
            },
            new IconInfo {
                Name = "SquareDashedOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareDashedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareDashedOutlined()
            },
            new IconInfo {
                Name = "SquareDashedCircleOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareDashedCircleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareDashedCircleOutlined()
            },
            new IconInfo {
                Name = "SquareDotOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareDotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareDotOutlined()
            },
            new IconInfo {
                Name = "SquareLineHorizontalOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareLineHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareLineHorizontalOutlined()
            },
            new IconInfo {
                Name = "SquareLineVerticalOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareLineVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareLineVerticalOutlined()
            },
            new IconInfo {
                Name = "TrapezoidLeftLineHorizontalOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TrapezoidLeftLineHorizontalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TrapezoidLeftLineHorizontalOutlined()
            },
            new IconInfo {
                Name = "TrapezoidUpLineVerticalOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TrapezoidUpLineVerticalOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TrapezoidUpLineVerticalOutlined()
            },
            new IconInfo {
                Name = "TriangleExclamationOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleExclamationOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TriangleExclamationOutlined()
            },
            new IconInfo {
                Name = "TriangleThunderboltOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TriangleThunderboltOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TriangleThunderboltOutlined()
            },
            new IconInfo {
                Name = "XmarkShapeOutlined",
                Category = "Shapes",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.XmarkShapeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.XmarkShapeOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateStatusIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateStatusFilledIconInfos(),
            IconThemeType.Outlined => CreateStatusOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateStatusFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "AlarmFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.AlarmFilled),
                Creator = () => new AtomUI.Icons.Gravity.AlarmFilled()
            },
            new IconInfo {
                Name = "BellFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.BellFilled),
                Creator = () => new AtomUI.Icons.Gravity.BellFilled()
            },
            new IconInfo {
                Name = "CircleCheckFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleCheckFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleCheckFilled()
            },
            new IconInfo {
                Name = "CircleExclamationFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleExclamationFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleExclamationFilled()
            },
            new IconInfo {
                Name = "CircleInfoFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleInfoFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleInfoFilled()
            },
            new IconInfo {
                Name = "CircleMinusFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleMinusFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleMinusFilled()
            },
            new IconInfo {
                Name = "CirclePlusFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CirclePlusFilled),
                Creator = () => new AtomUI.Icons.Gravity.CirclePlusFilled()
            },
            new IconInfo {
                Name = "CircleQuestionFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleQuestionFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleQuestionFilled()
            },
            new IconInfo {
                Name = "CircleXmarkFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleXmarkFilled),
                Creator = () => new AtomUI.Icons.Gravity.CircleXmarkFilled()
            },
            new IconInfo {
                Name = "ThumbsDownFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.ThumbsDownFilled),
                Creator = () => new AtomUI.Icons.Gravity.ThumbsDownFilled()
            },
            new IconInfo {
                Name = "ThumbsUpFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.ThumbsUpFilled),
                Creator = () => new AtomUI.Icons.Gravity.ThumbsUpFilled()
            },
            new IconInfo {
                Name = "ThunderboltFilled",
                Category = "Status",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.ThunderboltFilled),
                Creator = () => new AtomUI.Icons.Gravity.ThunderboltFilled()
            },
        ];
    }

    private static List<IconInfo> CreateStatusOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "AlarmOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AlarmOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AlarmOutlined()
            },
            new IconInfo {
                Name = "BanOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BanOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BanOutlined()
            },
            new IconInfo {
                Name = "BanDashedOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BanDashedOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BanDashedOutlined()
            },
            new IconInfo {
                Name = "BellOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BellOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BellOutlined()
            },
            new IconInfo {
                Name = "BellDotOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BellDotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BellDotOutlined()
            },
            new IconInfo {
                Name = "BellSlashOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BellSlashOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BellSlashOutlined()
            },
            new IconInfo {
                Name = "CheckOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CheckOutlined()
            },
            new IconInfo {
                Name = "CheckDoubleOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CheckDoubleOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CheckDoubleOutlined()
            },
            new IconInfo {
                Name = "CircleCheckOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleCheckOutlined()
            },
            new IconInfo {
                Name = "CircleExclamationOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleExclamationOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleExclamationOutlined()
            },
            new IconInfo {
                Name = "CircleInfoOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleInfoOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleInfoOutlined()
            },
            new IconInfo {
                Name = "CircleMinusOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleMinusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleMinusOutlined()
            },
            new IconInfo {
                Name = "CirclePlusOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CirclePlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CirclePlusOutlined()
            },
            new IconInfo {
                Name = "CircleQuestionOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleQuestionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleQuestionOutlined()
            },
            new IconInfo {
                Name = "CircleQuestionDotOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleQuestionDotOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleQuestionDotOutlined()
            },
            new IconInfo {
                Name = "CircleXmarkOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleXmarkOutlined()
            },
            new IconInfo {
                Name = "FlagOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FlagOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FlagOutlined()
            },
            new IconInfo {
                Name = "SquareCheckOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareCheckOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareCheckOutlined()
            },
            new IconInfo {
                Name = "SquareExclamationOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareExclamationOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareExclamationOutlined()
            },
            new IconInfo {
                Name = "SquareMinusOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareMinusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareMinusOutlined()
            },
            new IconInfo {
                Name = "SquarePlusOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquarePlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquarePlusOutlined()
            },
            new IconInfo {
                Name = "SquareXmarkOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareXmarkOutlined()
            },
            new IconInfo {
                Name = "ThumbsDownOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ThumbsDownOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ThumbsDownOutlined()
            },
            new IconInfo {
                Name = "ThumbsUpOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ThumbsUpOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ThumbsUpOutlined()
            },
            new IconInfo {
                Name = "ThumbsUp2Outlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ThumbsUp2Outlined),
                Creator = () => new AtomUI.Icons.Gravity.ThumbsUp2Outlined()
            },
            new IconInfo {
                Name = "ThunderboltOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ThunderboltOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ThunderboltOutlined()
            },
            new IconInfo {
                Name = "TrafficLightOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TrafficLightOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TrafficLightOutlined()
            },
            new IconInfo {
                Name = "XmarkOutlined",
                Category = "Status",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.XmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.XmarkOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateTextIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateTextFilledIconInfos(),
            IconThemeType.Outlined => CreateTextOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateTextFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "CircleNumber0Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber0Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber0Filled()
            },
            new IconInfo {
                Name = "CircleNumber1Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber1Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber1Filled()
            },
            new IconInfo {
                Name = "CircleNumber2Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber2Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber2Filled()
            },
            new IconInfo {
                Name = "CircleNumber3Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber3Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber3Filled()
            },
            new IconInfo {
                Name = "CircleNumber4Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber4Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber4Filled()
            },
            new IconInfo {
                Name = "CircleNumber5Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber5Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber5Filled()
            },
            new IconInfo {
                Name = "CircleNumber6Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber6Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber6Filled()
            },
            new IconInfo {
                Name = "CircleNumber7Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber7Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber7Filled()
            },
            new IconInfo {
                Name = "CircleNumber8Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber8Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber8Filled()
            },
            new IconInfo {
                Name = "CircleNumber9Filled",
                Category = "Text",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber9Filled),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber9Filled()
            },
        ];
    }

    private static List<IconInfo> CreateTextOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "AbbrApiOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AbbrApiOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AbbrApiOutlined()
            },
            new IconInfo {
                Name = "AbbrMlOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AbbrMlOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AbbrMlOutlined()
            },
            new IconInfo {
                Name = "AbbrQlOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AbbrQlOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AbbrQlOutlined()
            },
            new IconInfo {
                Name = "AbbrSqlOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AbbrSqlOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AbbrSqlOutlined()
            },
            new IconInfo {
                Name = "AbbrZipOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.AbbrZipOutlined),
                Creator = () => new AtomUI.Icons.Gravity.AbbrZipOutlined()
            },
            new IconInfo {
                Name = "BoldOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BoldOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BoldOutlined()
            },
            new IconInfo {
                Name = "CircleLetterAOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterAOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterAOutlined()
            },
            new IconInfo {
                Name = "CircleLetterBOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterBOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterBOutlined()
            },
            new IconInfo {
                Name = "CircleLetterCOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterCOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterCOutlined()
            },
            new IconInfo {
                Name = "CircleLetterDOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterDOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterDOutlined()
            },
            new IconInfo {
                Name = "CircleLetterEOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterEOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterEOutlined()
            },
            new IconInfo {
                Name = "CircleLetterFOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterFOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterFOutlined()
            },
            new IconInfo {
                Name = "CircleLetterGOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterGOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterGOutlined()
            },
            new IconInfo {
                Name = "CircleLetterHOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterHOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterHOutlined()
            },
            new IconInfo {
                Name = "CircleLetterIOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterIOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterIOutlined()
            },
            new IconInfo {
                Name = "CircleLetterJOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterJOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterJOutlined()
            },
            new IconInfo {
                Name = "CircleLetterKOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterKOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterKOutlined()
            },
            new IconInfo {
                Name = "CircleLetterLOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterLOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterLOutlined()
            },
            new IconInfo {
                Name = "CircleLetterMOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterMOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterMOutlined()
            },
            new IconInfo {
                Name = "CircleLetterNOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterNOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterNOutlined()
            },
            new IconInfo {
                Name = "CircleLetterOOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterOOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterOOutlined()
            },
            new IconInfo {
                Name = "CircleLetterPOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterPOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterPOutlined()
            },
            new IconInfo {
                Name = "CircleLetterQOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterQOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterQOutlined()
            },
            new IconInfo {
                Name = "CircleLetterROutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterROutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterROutlined()
            },
            new IconInfo {
                Name = "CircleLetterSOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterSOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterSOutlined()
            },
            new IconInfo {
                Name = "CircleLetterTOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterTOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterTOutlined()
            },
            new IconInfo {
                Name = "CircleLetterUOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterUOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterUOutlined()
            },
            new IconInfo {
                Name = "CircleLetterVOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterVOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterVOutlined()
            },
            new IconInfo {
                Name = "CircleLetterWOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterWOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterWOutlined()
            },
            new IconInfo {
                Name = "CircleLetterXOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterXOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterXOutlined()
            },
            new IconInfo {
                Name = "CircleLetterYOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterYOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterYOutlined()
            },
            new IconInfo {
                Name = "CircleLetterZOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleLetterZOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleLetterZOutlined()
            },
            new IconInfo {
                Name = "CircleNumber0Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber0Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber0Outlined()
            },
            new IconInfo {
                Name = "CircleNumber1Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber1Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber1Outlined()
            },
            new IconInfo {
                Name = "CircleNumber2Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber2Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber2Outlined()
            },
            new IconInfo {
                Name = "CircleNumber3Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber3Outlined()
            },
            new IconInfo {
                Name = "CircleNumber4Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber4Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber4Outlined()
            },
            new IconInfo {
                Name = "CircleNumber5Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber5Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber5Outlined()
            },
            new IconInfo {
                Name = "CircleNumber6Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber6Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber6Outlined()
            },
            new IconInfo {
                Name = "CircleNumber7Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber7Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber7Outlined()
            },
            new IconInfo {
                Name = "CircleNumber8Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber8Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber8Outlined()
            },
            new IconInfo {
                Name = "CircleNumber9Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CircleNumber9Outlined),
                Creator = () => new AtomUI.Icons.Gravity.CircleNumber9Outlined()
            },
            new IconInfo {
                Name = "FontOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FontOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FontOutlined()
            },
            new IconInfo {
                Name = "FontCaseOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FontCaseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FontCaseOutlined()
            },
            new IconInfo {
                Name = "HeadingOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HeadingOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HeadingOutlined()
            },
            new IconInfo {
                Name = "Heading1Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Heading1Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Heading1Outlined()
            },
            new IconInfo {
                Name = "Heading2Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Heading2Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Heading2Outlined()
            },
            new IconInfo {
                Name = "Heading3Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Heading3Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Heading3Outlined()
            },
            new IconInfo {
                Name = "Heading4Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Heading4Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Heading4Outlined()
            },
            new IconInfo {
                Name = "Heading5Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Heading5Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Heading5Outlined()
            },
            new IconInfo {
                Name = "Heading6Outlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.Heading6Outlined),
                Creator = () => new AtomUI.Icons.Gravity.Heading6Outlined()
            },
            new IconInfo {
                Name = "ItalicOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ItalicOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ItalicOutlined()
            },
            new IconInfo {
                Name = "LetterAUnderlineOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LetterAUnderlineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LetterAUnderlineOutlined()
            },
            new IconInfo {
                Name = "LetterGroupOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LetterGroupOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LetterGroupOutlined()
            },
            new IconInfo {
                Name = "LetterMOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LetterMOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LetterMOutlined()
            },
            new IconInfo {
                Name = "QuoteCloseOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.QuoteCloseOutlined),
                Creator = () => new AtomUI.Icons.Gravity.QuoteCloseOutlined()
            },
            new IconInfo {
                Name = "QuoteOpenOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.QuoteOpenOutlined),
                Creator = () => new AtomUI.Icons.Gravity.QuoteOpenOutlined()
            },
            new IconInfo {
                Name = "SquareDashedLetterAOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareDashedLetterAOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareDashedLetterAOutlined()
            },
            new IconInfo {
                Name = "SquareDashedLetterTOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareDashedLetterTOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareDashedLetterTOutlined()
            },
            new IconInfo {
                Name = "SquareDashedTextOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareDashedTextOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareDashedTextOutlined()
            },
            new IconInfo {
                Name = "SquareLetterPOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareLetterPOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareLetterPOutlined()
            },
            new IconInfo {
                Name = "SquareLetterTOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SquareLetterTOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SquareLetterTOutlined()
            },
            new IconInfo {
                Name = "StrikethroughOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.StrikethroughOutlined),
                Creator = () => new AtomUI.Icons.Gravity.StrikethroughOutlined()
            },
            new IconInfo {
                Name = "TextOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TextOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TextOutlined()
            },
            new IconInfo {
                Name = "UnderlineOutlined",
                Category = "Text",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.UnderlineOutlined),
                Creator = () => new AtomUI.Icons.Gravity.UnderlineOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateTimeIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateTimeFilledIconInfos(),
            IconThemeType.Outlined => CreateTimeOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateTimeFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "ClockFilled",
                Category = "Time",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.ClockFilled),
                Creator = () => new AtomUI.Icons.Gravity.ClockFilled()
            },
        ];
    }

    private static List<IconInfo> CreateTimeOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CalendarOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CalendarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CalendarOutlined()
            },
            new IconInfo {
                Name = "CalendarXmarkOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CalendarXmarkOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CalendarXmarkOutlined()
            },
            new IconInfo {
                Name = "ClockOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ClockOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ClockOutlined()
            },
            new IconInfo {
                Name = "ClockArrowRotateLeftOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ClockArrowRotateLeftOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ClockArrowRotateLeftOutlined()
            },
            new IconInfo {
                Name = "HourglassOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HourglassOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HourglassOutlined()
            },
            new IconInfo {
                Name = "HourglassEndOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HourglassEndOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HourglassEndOutlined()
            },
            new IconInfo {
                Name = "HourglassStartOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HourglassStartOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HourglassStartOutlined()
            },
            new IconInfo {
                Name = "StopwatchOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.StopwatchOutlined),
                Creator = () => new AtomUI.Icons.Gravity.StopwatchOutlined()
            },
            new IconInfo {
                Name = "TimestampsOutlined",
                Category = "Time",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TimestampsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TimestampsOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateToolsIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateToolsFilledIconInfos(),
            IconThemeType.Outlined => CreateToolsOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateToolsFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "BroomMotionFilled",
                Category = "Tools",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.BroomMotionFilled),
                Creator = () => new AtomUI.Icons.Gravity.BroomMotionFilled()
            },
        ];
    }

    private static List<IconInfo> CreateToolsOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "BinocularsOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BinocularsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BinocularsOutlined()
            },
            new IconInfo {
                Name = "BroomMotionOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.BroomMotionOutlined),
                Creator = () => new AtomUI.Icons.Gravity.BroomMotionOutlined()
            },
            new IconInfo {
                Name = "HammerOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.HammerOutlined),
                Creator = () => new AtomUI.Icons.Gravity.HammerOutlined()
            },
            new IconInfo {
                Name = "MagnetOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MagnetOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MagnetOutlined()
            },
            new IconInfo {
                Name = "MagnifierOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MagnifierOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MagnifierOutlined()
            },
            new IconInfo {
                Name = "MagnifierMinusOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MagnifierMinusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MagnifierMinusOutlined()
            },
            new IconInfo {
                Name = "MagnifierPlusOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MagnifierPlusOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MagnifierPlusOutlined()
            },
            new IconInfo {
                Name = "TargetOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TargetOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TargetOutlined()
            },
            new IconInfo {
                Name = "TargetDartOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.TargetDartOutlined),
                Creator = () => new AtomUI.Icons.Gravity.TargetDartOutlined()
            },
            new IconInfo {
                Name = "WeightHangingOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.WeightHangingOutlined),
                Creator = () => new AtomUI.Icons.Gravity.WeightHangingOutlined()
            },
            new IconInfo {
                Name = "WrenchOutlined",
                Category = "Tools",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.WrenchOutlined),
                Creator = () => new AtomUI.Icons.Gravity.WrenchOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateTransportIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Filled => CreateTransportFilledIconInfos(),
            IconThemeType.Outlined => CreateTransportOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateTransportFilledIconInfos()
    {
        return [
            new IconInfo {
                Name = "PlaneFilled",
                Category = "Transport",
                ThemeType = IconThemeType.Filled,
                IconType = typeof(AtomUI.Icons.Gravity.PlaneFilled),
                Creator = () => new AtomUI.Icons.Gravity.PlaneFilled()
            },
        ];
    }

    private static List<IconInfo> CreateTransportOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CarOutlined",
                Category = "Transport",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CarOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CarOutlined()
            },
            new IconInfo {
                Name = "PlaneOutlined",
                Category = "Transport",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.PlaneOutlined),
                Creator = () => new AtomUI.Icons.Gravity.PlaneOutlined()
            },
            new IconInfo {
                Name = "RocketOutlined",
                Category = "Transport",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.RocketOutlined),
                Creator = () => new AtomUI.Icons.Gravity.RocketOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateUnassignedIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateUnassignedOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateUnassignedOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "ChevronsCollapseVerticalFromLinesOutlined",
                Category = "Unassigned",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsCollapseVerticalFromLinesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsCollapseVerticalFromLinesOutlined()
            },
            new IconInfo {
                Name = "ChevronsExpandVerticalToLinesOutlined",
                Category = "Unassigned",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.ChevronsExpandVerticalToLinesOutlined),
                Creator = () => new AtomUI.Icons.Gravity.ChevronsExpandVerticalToLinesOutlined()
            },
            new IconInfo {
                Name = "CookieOutlined",
                Category = "Unassigned",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CookieOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CookieOutlined()
            },
            new IconInfo {
                Name = "IncognitoOutlined",
                Category = "Unassigned",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.IncognitoOutlined),
                Creator = () => new AtomUI.Icons.Gravity.IncognitoOutlined()
            },
            new IconInfo {
                Name = "LogoYandexAiStudioOutlined",
                Category = "Unassigned",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoYandexAiStudioOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoYandexAiStudioOutlined()
            },
            new IconInfo {
                Name = "LogoYandexIdOutlined",
                Category = "Unassigned",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.LogoYandexIdOutlined),
                Creator = () => new AtomUI.Icons.Gravity.LogoYandexIdOutlined()
            },
            new IconInfo {
                Name = "SubscriptOutlined",
                Category = "Unassigned",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SubscriptOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SubscriptOutlined()
            },
        ];
    }

    private static List<IconInfo> CreateWeatherIconInfos(IconThemeType iconTheme)
    {
        return iconTheme switch
        {
            IconThemeType.Outlined => CreateWeatherOutlinedIconInfos(),
            _ => []
        };
    }

    private static List<IconInfo> CreateWeatherOutlinedIconInfos()
    {
        return [
            new IconInfo {
                Name = "CloudsOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.CloudsOutlined),
                Creator = () => new AtomUI.Icons.Gravity.CloudsOutlined()
            },
            new IconInfo {
                Name = "DropletOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.DropletOutlined),
                Creator = () => new AtomUI.Icons.Gravity.DropletOutlined()
            },
            new IconInfo {
                Name = "FlameOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.FlameOutlined),
                Creator = () => new AtomUI.Icons.Gravity.FlameOutlined()
            },
            new IconInfo {
                Name = "MoonOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.MoonOutlined),
                Creator = () => new AtomUI.Icons.Gravity.MoonOutlined()
            },
            new IconInfo {
                Name = "SnailOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SnailOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SnailOutlined()
            },
            new IconInfo {
                Name = "SnowflakeOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SnowflakeOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SnowflakeOutlined()
            },
            new IconInfo {
                Name = "SunOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.SunOutlined),
                Creator = () => new AtomUI.Icons.Gravity.SunOutlined()
            },
            new IconInfo {
                Name = "UmbrellaOutlined",
                Category = "Weather",
                ThemeType = IconThemeType.Outlined,
                IconType = typeof(AtomUI.Icons.Gravity.UmbrellaOutlined),
                Creator = () => new AtomUI.Icons.Gravity.UmbrellaOutlined()
            },
        ];
    }
}
