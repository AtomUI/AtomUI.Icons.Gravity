// This code is auto generated. Do not modify.
using System;
using System.Diagnostics.CodeAnalysis;
using AtomUI.Controls;

namespace AtomUI.Icons.Gravity;

public partial class GravityIconProvider
{
    private const int IconFactoryIconCount = 816;
    private const int IconFactoryChunkSize = 64;

    private static int GetIconIndex(GravityIconKind kind)
    {
        var index = (int)kind - 1;
        if ((uint)index >= IconFactoryIconCount)
        {
            throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }

        return index;
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconType(GravityIconKind kind)
    {
        var index = GetIconIndex(kind);
        return GetIconTypeChunk(index / IconFactoryChunkSize, kind);
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk(int chunkIndex, GravityIconKind kind)
    {
        return chunkIndex switch
        {
            0 => GetIconTypeChunk0(kind),
            1 => GetIconTypeChunk1(kind),
            2 => GetIconTypeChunk2(kind),
            3 => GetIconTypeChunk3(kind),
            4 => GetIconTypeChunk4(kind),
            5 => GetIconTypeChunk5(kind),
            6 => GetIconTypeChunk6(kind),
            7 => GetIconTypeChunk7(kind),
            8 => GetIconTypeChunk8(kind),
            9 => GetIconTypeChunk9(kind),
            10 => GetIconTypeChunk10(kind),
            11 => GetIconTypeChunk11(kind),
            12 => GetIconTypeChunk12(kind),
            _ => throw new ArgumentOutOfRangeException(nameof(chunkIndex))
        };
    }

    private static Icon CreateIcon(GravityIconKind kind)
    {
        var index = GetIconIndex(kind);
        return CreateIconChunk(index / IconFactoryChunkSize, kind);
    }

    private static Icon CreateIconChunk(int chunkIndex, GravityIconKind kind)
    {
        return chunkIndex switch
        {
            0 => CreateIconChunk0(kind),
            1 => CreateIconChunk1(kind),
            2 => CreateIconChunk2(kind),
            3 => CreateIconChunk3(kind),
            4 => CreateIconChunk4(kind),
            5 => CreateIconChunk5(kind),
            6 => CreateIconChunk6(kind),
            7 => CreateIconChunk7(kind),
            8 => CreateIconChunk8(kind),
            9 => CreateIconChunk9(kind),
            10 => CreateIconChunk10(kind),
            11 => CreateIconChunk11(kind),
            12 => CreateIconChunk12(kind),
            _ => throw new ArgumentOutOfRangeException(nameof(chunkIndex))
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk0(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.AbbrApiOutlined: return typeof(AbbrApiOutlined);
            case GravityIconKind.AbbrMlOutlined: return typeof(AbbrMlOutlined);
            case GravityIconKind.AbbrQlOutlined: return typeof(AbbrQlOutlined);
            case GravityIconKind.AbbrSqlOutlined: return typeof(AbbrSqlOutlined);
            case GravityIconKind.AbbrZipOutlined: return typeof(AbbrZipOutlined);
            case GravityIconKind.AlarmOutlined: return typeof(AlarmOutlined);
            case GravityIconKind.AlarmFilled: return typeof(AlarmFilled);
            case GravityIconKind.AlmostEqualOutlined: return typeof(AlmostEqualOutlined);
            case GravityIconKind.AntennaSignalOutlined: return typeof(AntennaSignalOutlined);
            case GravityIconKind.ApertureOutlined: return typeof(ApertureOutlined);
            case GravityIconKind.ArchiveOutlined: return typeof(ArchiveOutlined);
            case GravityIconKind.ArrowChevronDownOutlined: return typeof(ArrowChevronDownOutlined);
            case GravityIconKind.ArrowChevronLeftOutlined: return typeof(ArrowChevronLeftOutlined);
            case GravityIconKind.ArrowChevronRightOutlined: return typeof(ArrowChevronRightOutlined);
            case GravityIconKind.ArrowChevronUpOutlined: return typeof(ArrowChevronUpOutlined);
            case GravityIconKind.ArrowDownOutlined: return typeof(ArrowDownOutlined);
            case GravityIconKind.ArrowDownFromLineOutlined: return typeof(ArrowDownFromLineOutlined);
            case GravityIconKind.ArrowDownLeftOutlined: return typeof(ArrowDownLeftOutlined);
            case GravityIconKind.ArrowDownRightOutlined: return typeof(ArrowDownRightOutlined);
            case GravityIconKind.ArrowDownToLineOutlined: return typeof(ArrowDownToLineOutlined);
            case GravityIconKind.ArrowDownToSquareOutlined: return typeof(ArrowDownToSquareOutlined);
            case GravityIconKind.ArrowLeftOutlined: return typeof(ArrowLeftOutlined);
            case GravityIconKind.ArrowLeftFromLineOutlined: return typeof(ArrowLeftFromLineOutlined);
            case GravityIconKind.ArrowLeftToLineOutlined: return typeof(ArrowLeftToLineOutlined);
            case GravityIconKind.ArrowRightOutlined: return typeof(ArrowRightOutlined);
            case GravityIconKind.ArrowRightArrowLeftOutlined: return typeof(ArrowRightArrowLeftOutlined);
            case GravityIconKind.ArrowRightFromLineOutlined: return typeof(ArrowRightFromLineOutlined);
            case GravityIconKind.ArrowRightFromSquareOutlined: return typeof(ArrowRightFromSquareOutlined);
            case GravityIconKind.ArrowRightToLineOutlined: return typeof(ArrowRightToLineOutlined);
            case GravityIconKind.ArrowRightToSquareOutlined: return typeof(ArrowRightToSquareOutlined);
            case GravityIconKind.ArrowRotateLeftOutlined: return typeof(ArrowRotateLeftOutlined);
            case GravityIconKind.ArrowRotateLeftNumber5Outlined: return typeof(ArrowRotateLeftNumber5Outlined);
            case GravityIconKind.ArrowRotateRightOutlined: return typeof(ArrowRotateRightOutlined);
            case GravityIconKind.ArrowRotateRightNumber5Outlined: return typeof(ArrowRotateRightNumber5Outlined);
            case GravityIconKind.ArrowShapeDownOutlined: return typeof(ArrowShapeDownOutlined);
            case GravityIconKind.ArrowShapeDownFromLineOutlined: return typeof(ArrowShapeDownFromLineOutlined);
            case GravityIconKind.ArrowShapeDownToLineOutlined: return typeof(ArrowShapeDownToLineOutlined);
            case GravityIconKind.ArrowShapeLeftOutlined: return typeof(ArrowShapeLeftOutlined);
            case GravityIconKind.ArrowShapeLeftFromLineOutlined: return typeof(ArrowShapeLeftFromLineOutlined);
            case GravityIconKind.ArrowShapeLeftToLineOutlined: return typeof(ArrowShapeLeftToLineOutlined);
            case GravityIconKind.ArrowShapeRightOutlined: return typeof(ArrowShapeRightOutlined);
            case GravityIconKind.ArrowShapeRightFromLineOutlined: return typeof(ArrowShapeRightFromLineOutlined);
            case GravityIconKind.ArrowShapeRightToLineOutlined: return typeof(ArrowShapeRightToLineOutlined);
            case GravityIconKind.ArrowShapeTurnUpLeftOutlined: return typeof(ArrowShapeTurnUpLeftOutlined);
            case GravityIconKind.ArrowShapeTurnUpRightOutlined: return typeof(ArrowShapeTurnUpRightOutlined);
            case GravityIconKind.ArrowShapeUpOutlined: return typeof(ArrowShapeUpOutlined);
            case GravityIconKind.ArrowShapeUpFromLineOutlined: return typeof(ArrowShapeUpFromLineOutlined);
            case GravityIconKind.ArrowShapeUpToLineOutlined: return typeof(ArrowShapeUpToLineOutlined);
            case GravityIconKind.ArrowUpOutlined: return typeof(ArrowUpOutlined);
            case GravityIconKind.ArrowUpArrowDownOutlined: return typeof(ArrowUpArrowDownOutlined);
            case GravityIconKind.ArrowUpFromLineOutlined: return typeof(ArrowUpFromLineOutlined);
            case GravityIconKind.ArrowUpFromSquareOutlined: return typeof(ArrowUpFromSquareOutlined);
            case GravityIconKind.ArrowUpFromSquareSlashOutlined: return typeof(ArrowUpFromSquareSlashOutlined);
            case GravityIconKind.ArrowUpLeftOutlined: return typeof(ArrowUpLeftOutlined);
            case GravityIconKind.ArrowUpRightOutlined: return typeof(ArrowUpRightOutlined);
            case GravityIconKind.ArrowUpRightFromSquareOutlined: return typeof(ArrowUpRightFromSquareOutlined);
            case GravityIconKind.ArrowUpToLineOutlined: return typeof(ArrowUpToLineOutlined);
            case GravityIconKind.ArrowUturnCcwDownOutlined: return typeof(ArrowUturnCcwDownOutlined);
            case GravityIconKind.ArrowUturnCcwLeftOutlined: return typeof(ArrowUturnCcwLeftOutlined);
            case GravityIconKind.ArrowUturnCcwRightOutlined: return typeof(ArrowUturnCcwRightOutlined);
            case GravityIconKind.ArrowUturnCwDownOutlined: return typeof(ArrowUturnCwDownOutlined);
            case GravityIconKind.ArrowUturnCwLeftOutlined: return typeof(ArrowUturnCwLeftOutlined);
            case GravityIconKind.ArrowUturnCwRightOutlined: return typeof(ArrowUturnCwRightOutlined);
            case GravityIconKind.Arrows3RotateLeftOutlined: return typeof(Arrows3RotateLeftOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk0(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.AbbrApiOutlined => new AbbrApiOutlined(),
            GravityIconKind.AbbrMlOutlined => new AbbrMlOutlined(),
            GravityIconKind.AbbrQlOutlined => new AbbrQlOutlined(),
            GravityIconKind.AbbrSqlOutlined => new AbbrSqlOutlined(),
            GravityIconKind.AbbrZipOutlined => new AbbrZipOutlined(),
            GravityIconKind.AlarmOutlined => new AlarmOutlined(),
            GravityIconKind.AlarmFilled => new AlarmFilled(),
            GravityIconKind.AlmostEqualOutlined => new AlmostEqualOutlined(),
            GravityIconKind.AntennaSignalOutlined => new AntennaSignalOutlined(),
            GravityIconKind.ApertureOutlined => new ApertureOutlined(),
            GravityIconKind.ArchiveOutlined => new ArchiveOutlined(),
            GravityIconKind.ArrowChevronDownOutlined => new ArrowChevronDownOutlined(),
            GravityIconKind.ArrowChevronLeftOutlined => new ArrowChevronLeftOutlined(),
            GravityIconKind.ArrowChevronRightOutlined => new ArrowChevronRightOutlined(),
            GravityIconKind.ArrowChevronUpOutlined => new ArrowChevronUpOutlined(),
            GravityIconKind.ArrowDownOutlined => new ArrowDownOutlined(),
            GravityIconKind.ArrowDownFromLineOutlined => new ArrowDownFromLineOutlined(),
            GravityIconKind.ArrowDownLeftOutlined => new ArrowDownLeftOutlined(),
            GravityIconKind.ArrowDownRightOutlined => new ArrowDownRightOutlined(),
            GravityIconKind.ArrowDownToLineOutlined => new ArrowDownToLineOutlined(),
            GravityIconKind.ArrowDownToSquareOutlined => new ArrowDownToSquareOutlined(),
            GravityIconKind.ArrowLeftOutlined => new ArrowLeftOutlined(),
            GravityIconKind.ArrowLeftFromLineOutlined => new ArrowLeftFromLineOutlined(),
            GravityIconKind.ArrowLeftToLineOutlined => new ArrowLeftToLineOutlined(),
            GravityIconKind.ArrowRightOutlined => new ArrowRightOutlined(),
            GravityIconKind.ArrowRightArrowLeftOutlined => new ArrowRightArrowLeftOutlined(),
            GravityIconKind.ArrowRightFromLineOutlined => new ArrowRightFromLineOutlined(),
            GravityIconKind.ArrowRightFromSquareOutlined => new ArrowRightFromSquareOutlined(),
            GravityIconKind.ArrowRightToLineOutlined => new ArrowRightToLineOutlined(),
            GravityIconKind.ArrowRightToSquareOutlined => new ArrowRightToSquareOutlined(),
            GravityIconKind.ArrowRotateLeftOutlined => new ArrowRotateLeftOutlined(),
            GravityIconKind.ArrowRotateLeftNumber5Outlined => new ArrowRotateLeftNumber5Outlined(),
            GravityIconKind.ArrowRotateRightOutlined => new ArrowRotateRightOutlined(),
            GravityIconKind.ArrowRotateRightNumber5Outlined => new ArrowRotateRightNumber5Outlined(),
            GravityIconKind.ArrowShapeDownOutlined => new ArrowShapeDownOutlined(),
            GravityIconKind.ArrowShapeDownFromLineOutlined => new ArrowShapeDownFromLineOutlined(),
            GravityIconKind.ArrowShapeDownToLineOutlined => new ArrowShapeDownToLineOutlined(),
            GravityIconKind.ArrowShapeLeftOutlined => new ArrowShapeLeftOutlined(),
            GravityIconKind.ArrowShapeLeftFromLineOutlined => new ArrowShapeLeftFromLineOutlined(),
            GravityIconKind.ArrowShapeLeftToLineOutlined => new ArrowShapeLeftToLineOutlined(),
            GravityIconKind.ArrowShapeRightOutlined => new ArrowShapeRightOutlined(),
            GravityIconKind.ArrowShapeRightFromLineOutlined => new ArrowShapeRightFromLineOutlined(),
            GravityIconKind.ArrowShapeRightToLineOutlined => new ArrowShapeRightToLineOutlined(),
            GravityIconKind.ArrowShapeTurnUpLeftOutlined => new ArrowShapeTurnUpLeftOutlined(),
            GravityIconKind.ArrowShapeTurnUpRightOutlined => new ArrowShapeTurnUpRightOutlined(),
            GravityIconKind.ArrowShapeUpOutlined => new ArrowShapeUpOutlined(),
            GravityIconKind.ArrowShapeUpFromLineOutlined => new ArrowShapeUpFromLineOutlined(),
            GravityIconKind.ArrowShapeUpToLineOutlined => new ArrowShapeUpToLineOutlined(),
            GravityIconKind.ArrowUpOutlined => new ArrowUpOutlined(),
            GravityIconKind.ArrowUpArrowDownOutlined => new ArrowUpArrowDownOutlined(),
            GravityIconKind.ArrowUpFromLineOutlined => new ArrowUpFromLineOutlined(),
            GravityIconKind.ArrowUpFromSquareOutlined => new ArrowUpFromSquareOutlined(),
            GravityIconKind.ArrowUpFromSquareSlashOutlined => new ArrowUpFromSquareSlashOutlined(),
            GravityIconKind.ArrowUpLeftOutlined => new ArrowUpLeftOutlined(),
            GravityIconKind.ArrowUpRightOutlined => new ArrowUpRightOutlined(),
            GravityIconKind.ArrowUpRightFromSquareOutlined => new ArrowUpRightFromSquareOutlined(),
            GravityIconKind.ArrowUpToLineOutlined => new ArrowUpToLineOutlined(),
            GravityIconKind.ArrowUturnCcwDownOutlined => new ArrowUturnCcwDownOutlined(),
            GravityIconKind.ArrowUturnCcwLeftOutlined => new ArrowUturnCcwLeftOutlined(),
            GravityIconKind.ArrowUturnCcwRightOutlined => new ArrowUturnCcwRightOutlined(),
            GravityIconKind.ArrowUturnCwDownOutlined => new ArrowUturnCwDownOutlined(),
            GravityIconKind.ArrowUturnCwLeftOutlined => new ArrowUturnCwLeftOutlined(),
            GravityIconKind.ArrowUturnCwRightOutlined => new ArrowUturnCwRightOutlined(),
            GravityIconKind.Arrows3RotateLeftOutlined => new Arrows3RotateLeftOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk1(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.Arrows3RotateLeftLetterAOutlined: return typeof(Arrows3RotateLeftLetterAOutlined);
            case GravityIconKind.Arrows3RotateRightOutlined: return typeof(Arrows3RotateRightOutlined);
            case GravityIconKind.ArrowsExpandOutlined: return typeof(ArrowsExpandOutlined);
            case GravityIconKind.ArrowsExpandHorizontalOutlined: return typeof(ArrowsExpandHorizontalOutlined);
            case GravityIconKind.ArrowsExpandVerticalOutlined: return typeof(ArrowsExpandVerticalOutlined);
            case GravityIconKind.ArrowsOppositeToDotsOutlined: return typeof(ArrowsOppositeToDotsOutlined);
            case GravityIconKind.ArrowsRotateLeftOutlined: return typeof(ArrowsRotateLeftOutlined);
            case GravityIconKind.ArrowsRotateLeftSlashOutlined: return typeof(ArrowsRotateLeftSlashOutlined);
            case GravityIconKind.ArrowsRotateRightOutlined: return typeof(ArrowsRotateRightOutlined);
            case GravityIconKind.ArrowsRotateRightSlashOutlined: return typeof(ArrowsRotateRightSlashOutlined);
            case GravityIconKind.AtOutlined: return typeof(AtOutlined);
            case GravityIconKind.BackwardStepOutlined: return typeof(BackwardStepOutlined);
            case GravityIconKind.BackwardStepFilled: return typeof(BackwardStepFilled);
            case GravityIconKind.BanOutlined: return typeof(BanOutlined);
            case GravityIconKind.BanDashedOutlined: return typeof(BanDashedOutlined);
            case GravityIconKind.BarsOutlined: return typeof(BarsOutlined);
            case GravityIconKind.BarsAscendingAlignCenterOutlined: return typeof(BarsAscendingAlignCenterOutlined);
            case GravityIconKind.BarsAscendingAlignLeftOutlined: return typeof(BarsAscendingAlignLeftOutlined);
            case GravityIconKind.BarsAscendingAlignLeftArrowDownOutlined: return typeof(BarsAscendingAlignLeftArrowDownOutlined);
            case GravityIconKind.BarsAscendingAlignLeftArrowUpOutlined: return typeof(BarsAscendingAlignLeftArrowUpOutlined);
            case GravityIconKind.BarsAscendingAlignRightOutlined: return typeof(BarsAscendingAlignRightOutlined);
            case GravityIconKind.BarsDescendingAlignCenterOutlined: return typeof(BarsDescendingAlignCenterOutlined);
            case GravityIconKind.BarsDescendingAlignLeftOutlined: return typeof(BarsDescendingAlignLeftOutlined);
            case GravityIconKind.BarsDescendingAlignLeftArrowDownOutlined: return typeof(BarsDescendingAlignLeftArrowDownOutlined);
            case GravityIconKind.BarsDescendingAlignLeftArrowUpOutlined: return typeof(BarsDescendingAlignLeftArrowUpOutlined);
            case GravityIconKind.BarsDescendingAlignRightOutlined: return typeof(BarsDescendingAlignRightOutlined);
            case GravityIconKind.BarsPlayOutlined: return typeof(BarsPlayOutlined);
            case GravityIconKind.BarsUnalignedOutlined: return typeof(BarsUnalignedOutlined);
            case GravityIconKind.BellOutlined: return typeof(BellOutlined);
            case GravityIconKind.BellFilled: return typeof(BellFilled);
            case GravityIconKind.BellDotOutlined: return typeof(BellDotOutlined);
            case GravityIconKind.BellSlashOutlined: return typeof(BellSlashOutlined);
            case GravityIconKind.BinocularsOutlined: return typeof(BinocularsOutlined);
            case GravityIconKind.BoldOutlined: return typeof(BoldOutlined);
            case GravityIconKind.BookOutlined: return typeof(BookOutlined);
            case GravityIconKind.BookOpenOutlined: return typeof(BookOpenOutlined);
            case GravityIconKind.BookmarkOutlined: return typeof(BookmarkOutlined);
            case GravityIconKind.BookmarkFilled: return typeof(BookmarkFilled);
            case GravityIconKind.BooksOutlined: return typeof(BooksOutlined);
            case GravityIconKind.BoxOutlined: return typeof(BoxOutlined);
            case GravityIconKind.Boxes3Outlined: return typeof(Boxes3Outlined);
            case GravityIconKind.BranchesDownOutlined: return typeof(BranchesDownOutlined);
            case GravityIconKind.BranchesRightOutlined: return typeof(BranchesRightOutlined);
            case GravityIconKind.BranchesRightArrowRightOutlined: return typeof(BranchesRightArrowRightOutlined);
            case GravityIconKind.BriefcaseOutlined: return typeof(BriefcaseOutlined);
            case GravityIconKind.BriefcaseFilled: return typeof(BriefcaseFilled);
            case GravityIconKind.BroadcastSignalOutlined: return typeof(BroadcastSignalOutlined);
            case GravityIconKind.BroomMotionOutlined: return typeof(BroomMotionOutlined);
            case GravityIconKind.BroomMotionFilled: return typeof(BroomMotionFilled);
            case GravityIconKind.BrushOutlined: return typeof(BrushOutlined);
            case GravityIconKind.BucketOutlined: return typeof(BucketOutlined);
            case GravityIconKind.BucketPaintOutlined: return typeof(BucketPaintOutlined);
            case GravityIconKind.BugOutlined: return typeof(BugOutlined);
            case GravityIconKind.BulbOutlined: return typeof(BulbOutlined);
            case GravityIconKind.CalculatorOutlined: return typeof(CalculatorOutlined);
            case GravityIconKind.CalendarOutlined: return typeof(CalendarOutlined);
            case GravityIconKind.CalendarXmarkOutlined: return typeof(CalendarXmarkOutlined);
            case GravityIconKind.CameraOutlined: return typeof(CameraOutlined);
            case GravityIconKind.CarOutlined: return typeof(CarOutlined);
            case GravityIconKind.CardClubOutlined: return typeof(CardClubOutlined);
            case GravityIconKind.CardDiamondOutlined: return typeof(CardDiamondOutlined);
            case GravityIconKind.CardHeartOutlined: return typeof(CardHeartOutlined);
            case GravityIconKind.CardSpadeOutlined: return typeof(CardSpadeOutlined);
            case GravityIconKind.CaretDownOutlined: return typeof(CaretDownOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk1(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.Arrows3RotateLeftLetterAOutlined => new Arrows3RotateLeftLetterAOutlined(),
            GravityIconKind.Arrows3RotateRightOutlined => new Arrows3RotateRightOutlined(),
            GravityIconKind.ArrowsExpandOutlined => new ArrowsExpandOutlined(),
            GravityIconKind.ArrowsExpandHorizontalOutlined => new ArrowsExpandHorizontalOutlined(),
            GravityIconKind.ArrowsExpandVerticalOutlined => new ArrowsExpandVerticalOutlined(),
            GravityIconKind.ArrowsOppositeToDotsOutlined => new ArrowsOppositeToDotsOutlined(),
            GravityIconKind.ArrowsRotateLeftOutlined => new ArrowsRotateLeftOutlined(),
            GravityIconKind.ArrowsRotateLeftSlashOutlined => new ArrowsRotateLeftSlashOutlined(),
            GravityIconKind.ArrowsRotateRightOutlined => new ArrowsRotateRightOutlined(),
            GravityIconKind.ArrowsRotateRightSlashOutlined => new ArrowsRotateRightSlashOutlined(),
            GravityIconKind.AtOutlined => new AtOutlined(),
            GravityIconKind.BackwardStepOutlined => new BackwardStepOutlined(),
            GravityIconKind.BackwardStepFilled => new BackwardStepFilled(),
            GravityIconKind.BanOutlined => new BanOutlined(),
            GravityIconKind.BanDashedOutlined => new BanDashedOutlined(),
            GravityIconKind.BarsOutlined => new BarsOutlined(),
            GravityIconKind.BarsAscendingAlignCenterOutlined => new BarsAscendingAlignCenterOutlined(),
            GravityIconKind.BarsAscendingAlignLeftOutlined => new BarsAscendingAlignLeftOutlined(),
            GravityIconKind.BarsAscendingAlignLeftArrowDownOutlined => new BarsAscendingAlignLeftArrowDownOutlined(),
            GravityIconKind.BarsAscendingAlignLeftArrowUpOutlined => new BarsAscendingAlignLeftArrowUpOutlined(),
            GravityIconKind.BarsAscendingAlignRightOutlined => new BarsAscendingAlignRightOutlined(),
            GravityIconKind.BarsDescendingAlignCenterOutlined => new BarsDescendingAlignCenterOutlined(),
            GravityIconKind.BarsDescendingAlignLeftOutlined => new BarsDescendingAlignLeftOutlined(),
            GravityIconKind.BarsDescendingAlignLeftArrowDownOutlined => new BarsDescendingAlignLeftArrowDownOutlined(),
            GravityIconKind.BarsDescendingAlignLeftArrowUpOutlined => new BarsDescendingAlignLeftArrowUpOutlined(),
            GravityIconKind.BarsDescendingAlignRightOutlined => new BarsDescendingAlignRightOutlined(),
            GravityIconKind.BarsPlayOutlined => new BarsPlayOutlined(),
            GravityIconKind.BarsUnalignedOutlined => new BarsUnalignedOutlined(),
            GravityIconKind.BellOutlined => new BellOutlined(),
            GravityIconKind.BellFilled => new BellFilled(),
            GravityIconKind.BellDotOutlined => new BellDotOutlined(),
            GravityIconKind.BellSlashOutlined => new BellSlashOutlined(),
            GravityIconKind.BinocularsOutlined => new BinocularsOutlined(),
            GravityIconKind.BoldOutlined => new BoldOutlined(),
            GravityIconKind.BookOutlined => new BookOutlined(),
            GravityIconKind.BookOpenOutlined => new BookOpenOutlined(),
            GravityIconKind.BookmarkOutlined => new BookmarkOutlined(),
            GravityIconKind.BookmarkFilled => new BookmarkFilled(),
            GravityIconKind.BooksOutlined => new BooksOutlined(),
            GravityIconKind.BoxOutlined => new BoxOutlined(),
            GravityIconKind.Boxes3Outlined => new Boxes3Outlined(),
            GravityIconKind.BranchesDownOutlined => new BranchesDownOutlined(),
            GravityIconKind.BranchesRightOutlined => new BranchesRightOutlined(),
            GravityIconKind.BranchesRightArrowRightOutlined => new BranchesRightArrowRightOutlined(),
            GravityIconKind.BriefcaseOutlined => new BriefcaseOutlined(),
            GravityIconKind.BriefcaseFilled => new BriefcaseFilled(),
            GravityIconKind.BroadcastSignalOutlined => new BroadcastSignalOutlined(),
            GravityIconKind.BroomMotionOutlined => new BroomMotionOutlined(),
            GravityIconKind.BroomMotionFilled => new BroomMotionFilled(),
            GravityIconKind.BrushOutlined => new BrushOutlined(),
            GravityIconKind.BucketOutlined => new BucketOutlined(),
            GravityIconKind.BucketPaintOutlined => new BucketPaintOutlined(),
            GravityIconKind.BugOutlined => new BugOutlined(),
            GravityIconKind.BulbOutlined => new BulbOutlined(),
            GravityIconKind.CalculatorOutlined => new CalculatorOutlined(),
            GravityIconKind.CalendarOutlined => new CalendarOutlined(),
            GravityIconKind.CalendarXmarkOutlined => new CalendarXmarkOutlined(),
            GravityIconKind.CameraOutlined => new CameraOutlined(),
            GravityIconKind.CarOutlined => new CarOutlined(),
            GravityIconKind.CardClubOutlined => new CardClubOutlined(),
            GravityIconKind.CardDiamondOutlined => new CardDiamondOutlined(),
            GravityIconKind.CardHeartOutlined => new CardHeartOutlined(),
            GravityIconKind.CardSpadeOutlined => new CardSpadeOutlined(),
            GravityIconKind.CaretDownOutlined => new CaretDownOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk2(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.CaretLeftOutlined: return typeof(CaretLeftOutlined);
            case GravityIconKind.CaretRightOutlined: return typeof(CaretRightOutlined);
            case GravityIconKind.CaretUpOutlined: return typeof(CaretUpOutlined);
            case GravityIconKind.CaretsExpandVerticalOutlined: return typeof(CaretsExpandVerticalOutlined);
            case GravityIconKind.ChartAreaStackedOutlined: return typeof(ChartAreaStackedOutlined);
            case GravityIconKind.ChartAreaStackedNormalizedOutlined: return typeof(ChartAreaStackedNormalizedOutlined);
            case GravityIconKind.ChartBarOutlined: return typeof(ChartBarOutlined);
            case GravityIconKind.ChartBarStackedOutlined: return typeof(ChartBarStackedOutlined);
            case GravityIconKind.ChartColumnOutlined: return typeof(ChartColumnOutlined);
            case GravityIconKind.ChartColumnStackedOutlined: return typeof(ChartColumnStackedOutlined);
            case GravityIconKind.ChartDonutOutlined: return typeof(ChartDonutOutlined);
            case GravityIconKind.ChartLineOutlined: return typeof(ChartLineOutlined);
            case GravityIconKind.ChartLineArrowUpOutlined: return typeof(ChartLineArrowUpOutlined);
            case GravityIconKind.ChartLineLabelOutlined: return typeof(ChartLineLabelOutlined);
            case GravityIconKind.ChartLinePointsOutlined: return typeof(ChartLinePointsOutlined);
            case GravityIconKind.ChartMixedOutlined: return typeof(ChartMixedOutlined);
            case GravityIconKind.ChartPieOutlined: return typeof(ChartPieOutlined);
            case GravityIconKind.ChartTreemapOutlined: return typeof(ChartTreemapOutlined);
            case GravityIconKind.CheckOutlined: return typeof(CheckOutlined);
            case GravityIconKind.CheckDoubleOutlined: return typeof(CheckDoubleOutlined);
            case GravityIconKind.CheckShapeOutlined: return typeof(CheckShapeOutlined);
            case GravityIconKind.CheckShapeFilled: return typeof(CheckShapeFilled);
            case GravityIconKind.CherryOutlined: return typeof(CherryOutlined);
            case GravityIconKind.ChevronDownOutlined: return typeof(ChevronDownOutlined);
            case GravityIconKind.ChevronDownWideOutlined: return typeof(ChevronDownWideOutlined);
            case GravityIconKind.ChevronLeftOutlined: return typeof(ChevronLeftOutlined);
            case GravityIconKind.ChevronRightOutlined: return typeof(ChevronRightOutlined);
            case GravityIconKind.ChevronUpOutlined: return typeof(ChevronUpOutlined);
            case GravityIconKind.ChevronUpWideOutlined: return typeof(ChevronUpWideOutlined);
            case GravityIconKind.ChevronsCollapseFromLinesOutlined: return typeof(ChevronsCollapseFromLinesOutlined);
            case GravityIconKind.ChevronsCollapseHorizontalOutlined: return typeof(ChevronsCollapseHorizontalOutlined);
            case GravityIconKind.ChevronsCollapseToLineOutlined: return typeof(ChevronsCollapseToLineOutlined);
            case GravityIconKind.ChevronsCollapseUpRightOutlined: return typeof(ChevronsCollapseUpRightOutlined);
            case GravityIconKind.ChevronsCollapseVerticalOutlined: return typeof(ChevronsCollapseVerticalOutlined);
            case GravityIconKind.ChevronsCollapseVerticalFromLinesOutlined: return typeof(ChevronsCollapseVerticalFromLinesOutlined);
            case GravityIconKind.ChevronsCollapseVerticalToLineOutlined: return typeof(ChevronsCollapseVerticalToLineOutlined);
            case GravityIconKind.ChevronsDownOutlined: return typeof(ChevronsDownOutlined);
            case GravityIconKind.ChevronsDownWideOutlined: return typeof(ChevronsDownWideOutlined);
            case GravityIconKind.ChevronsExpandFromLineOutlined: return typeof(ChevronsExpandFromLineOutlined);
            case GravityIconKind.ChevronsExpandHorizontalOutlined: return typeof(ChevronsExpandHorizontalOutlined);
            case GravityIconKind.ChevronsExpandToLinesOutlined: return typeof(ChevronsExpandToLinesOutlined);
            case GravityIconKind.ChevronsExpandUpRightOutlined: return typeof(ChevronsExpandUpRightOutlined);
            case GravityIconKind.ChevronsExpandVerticalOutlined: return typeof(ChevronsExpandVerticalOutlined);
            case GravityIconKind.ChevronsExpandVerticalFromLineOutlined: return typeof(ChevronsExpandVerticalFromLineOutlined);
            case GravityIconKind.ChevronsExpandVerticalToLinesOutlined: return typeof(ChevronsExpandVerticalToLinesOutlined);
            case GravityIconKind.ChevronsLeftOutlined: return typeof(ChevronsLeftOutlined);
            case GravityIconKind.ChevronsRightOutlined: return typeof(ChevronsRightOutlined);
            case GravityIconKind.ChevronsUpOutlined: return typeof(ChevronsUpOutlined);
            case GravityIconKind.ChevronsUpWideOutlined: return typeof(ChevronsUpWideOutlined);
            case GravityIconKind.CircleOutlined: return typeof(CircleOutlined);
            case GravityIconKind.CircleFilled: return typeof(CircleFilled);
            case GravityIconKind.CircleArrowDownOutlined: return typeof(CircleArrowDownOutlined);
            case GravityIconKind.CircleArrowDownFilled: return typeof(CircleArrowDownFilled);
            case GravityIconKind.CircleArrowLeftOutlined: return typeof(CircleArrowLeftOutlined);
            case GravityIconKind.CircleArrowLeftFilled: return typeof(CircleArrowLeftFilled);
            case GravityIconKind.CircleArrowRightOutlined: return typeof(CircleArrowRightOutlined);
            case GravityIconKind.CircleArrowRightFilled: return typeof(CircleArrowRightFilled);
            case GravityIconKind.CircleArrowUpOutlined: return typeof(CircleArrowUpOutlined);
            case GravityIconKind.CircleArrowUpFilled: return typeof(CircleArrowUpFilled);
            case GravityIconKind.CircleCheckOutlined: return typeof(CircleCheckOutlined);
            case GravityIconKind.CircleCheckFilled: return typeof(CircleCheckFilled);
            case GravityIconKind.CircleChevronDownOutlined: return typeof(CircleChevronDownOutlined);
            case GravityIconKind.CircleChevronDownFilled: return typeof(CircleChevronDownFilled);
            case GravityIconKind.CircleChevronLeftOutlined: return typeof(CircleChevronLeftOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk2(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.CaretLeftOutlined => new CaretLeftOutlined(),
            GravityIconKind.CaretRightOutlined => new CaretRightOutlined(),
            GravityIconKind.CaretUpOutlined => new CaretUpOutlined(),
            GravityIconKind.CaretsExpandVerticalOutlined => new CaretsExpandVerticalOutlined(),
            GravityIconKind.ChartAreaStackedOutlined => new ChartAreaStackedOutlined(),
            GravityIconKind.ChartAreaStackedNormalizedOutlined => new ChartAreaStackedNormalizedOutlined(),
            GravityIconKind.ChartBarOutlined => new ChartBarOutlined(),
            GravityIconKind.ChartBarStackedOutlined => new ChartBarStackedOutlined(),
            GravityIconKind.ChartColumnOutlined => new ChartColumnOutlined(),
            GravityIconKind.ChartColumnStackedOutlined => new ChartColumnStackedOutlined(),
            GravityIconKind.ChartDonutOutlined => new ChartDonutOutlined(),
            GravityIconKind.ChartLineOutlined => new ChartLineOutlined(),
            GravityIconKind.ChartLineArrowUpOutlined => new ChartLineArrowUpOutlined(),
            GravityIconKind.ChartLineLabelOutlined => new ChartLineLabelOutlined(),
            GravityIconKind.ChartLinePointsOutlined => new ChartLinePointsOutlined(),
            GravityIconKind.ChartMixedOutlined => new ChartMixedOutlined(),
            GravityIconKind.ChartPieOutlined => new ChartPieOutlined(),
            GravityIconKind.ChartTreemapOutlined => new ChartTreemapOutlined(),
            GravityIconKind.CheckOutlined => new CheckOutlined(),
            GravityIconKind.CheckDoubleOutlined => new CheckDoubleOutlined(),
            GravityIconKind.CheckShapeOutlined => new CheckShapeOutlined(),
            GravityIconKind.CheckShapeFilled => new CheckShapeFilled(),
            GravityIconKind.CherryOutlined => new CherryOutlined(),
            GravityIconKind.ChevronDownOutlined => new ChevronDownOutlined(),
            GravityIconKind.ChevronDownWideOutlined => new ChevronDownWideOutlined(),
            GravityIconKind.ChevronLeftOutlined => new ChevronLeftOutlined(),
            GravityIconKind.ChevronRightOutlined => new ChevronRightOutlined(),
            GravityIconKind.ChevronUpOutlined => new ChevronUpOutlined(),
            GravityIconKind.ChevronUpWideOutlined => new ChevronUpWideOutlined(),
            GravityIconKind.ChevronsCollapseFromLinesOutlined => new ChevronsCollapseFromLinesOutlined(),
            GravityIconKind.ChevronsCollapseHorizontalOutlined => new ChevronsCollapseHorizontalOutlined(),
            GravityIconKind.ChevronsCollapseToLineOutlined => new ChevronsCollapseToLineOutlined(),
            GravityIconKind.ChevronsCollapseUpRightOutlined => new ChevronsCollapseUpRightOutlined(),
            GravityIconKind.ChevronsCollapseVerticalOutlined => new ChevronsCollapseVerticalOutlined(),
            GravityIconKind.ChevronsCollapseVerticalFromLinesOutlined => new ChevronsCollapseVerticalFromLinesOutlined(),
            GravityIconKind.ChevronsCollapseVerticalToLineOutlined => new ChevronsCollapseVerticalToLineOutlined(),
            GravityIconKind.ChevronsDownOutlined => new ChevronsDownOutlined(),
            GravityIconKind.ChevronsDownWideOutlined => new ChevronsDownWideOutlined(),
            GravityIconKind.ChevronsExpandFromLineOutlined => new ChevronsExpandFromLineOutlined(),
            GravityIconKind.ChevronsExpandHorizontalOutlined => new ChevronsExpandHorizontalOutlined(),
            GravityIconKind.ChevronsExpandToLinesOutlined => new ChevronsExpandToLinesOutlined(),
            GravityIconKind.ChevronsExpandUpRightOutlined => new ChevronsExpandUpRightOutlined(),
            GravityIconKind.ChevronsExpandVerticalOutlined => new ChevronsExpandVerticalOutlined(),
            GravityIconKind.ChevronsExpandVerticalFromLineOutlined => new ChevronsExpandVerticalFromLineOutlined(),
            GravityIconKind.ChevronsExpandVerticalToLinesOutlined => new ChevronsExpandVerticalToLinesOutlined(),
            GravityIconKind.ChevronsLeftOutlined => new ChevronsLeftOutlined(),
            GravityIconKind.ChevronsRightOutlined => new ChevronsRightOutlined(),
            GravityIconKind.ChevronsUpOutlined => new ChevronsUpOutlined(),
            GravityIconKind.ChevronsUpWideOutlined => new ChevronsUpWideOutlined(),
            GravityIconKind.CircleOutlined => new CircleOutlined(),
            GravityIconKind.CircleFilled => new CircleFilled(),
            GravityIconKind.CircleArrowDownOutlined => new CircleArrowDownOutlined(),
            GravityIconKind.CircleArrowDownFilled => new CircleArrowDownFilled(),
            GravityIconKind.CircleArrowLeftOutlined => new CircleArrowLeftOutlined(),
            GravityIconKind.CircleArrowLeftFilled => new CircleArrowLeftFilled(),
            GravityIconKind.CircleArrowRightOutlined => new CircleArrowRightOutlined(),
            GravityIconKind.CircleArrowRightFilled => new CircleArrowRightFilled(),
            GravityIconKind.CircleArrowUpOutlined => new CircleArrowUpOutlined(),
            GravityIconKind.CircleArrowUpFilled => new CircleArrowUpFilled(),
            GravityIconKind.CircleCheckOutlined => new CircleCheckOutlined(),
            GravityIconKind.CircleCheckFilled => new CircleCheckFilled(),
            GravityIconKind.CircleChevronDownOutlined => new CircleChevronDownOutlined(),
            GravityIconKind.CircleChevronDownFilled => new CircleChevronDownFilled(),
            GravityIconKind.CircleChevronLeftOutlined => new CircleChevronLeftOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk3(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.CircleChevronLeftFilled: return typeof(CircleChevronLeftFilled);
            case GravityIconKind.CircleChevronRightOutlined: return typeof(CircleChevronRightOutlined);
            case GravityIconKind.CircleChevronRightFilled: return typeof(CircleChevronRightFilled);
            case GravityIconKind.CircleChevronUpOutlined: return typeof(CircleChevronUpOutlined);
            case GravityIconKind.CircleChevronUpFilled: return typeof(CircleChevronUpFilled);
            case GravityIconKind.CircleChevronsDownOutlined: return typeof(CircleChevronsDownOutlined);
            case GravityIconKind.CircleChevronsLeftOutlined: return typeof(CircleChevronsLeftOutlined);
            case GravityIconKind.CircleChevronsRightOutlined: return typeof(CircleChevronsRightOutlined);
            case GravityIconKind.CircleChevronsUpOutlined: return typeof(CircleChevronsUpOutlined);
            case GravityIconKind.CircleDashedOutlined: return typeof(CircleDashedOutlined);
            case GravityIconKind.CircleDollarOutlined: return typeof(CircleDollarOutlined);
            case GravityIconKind.CircleExclamationOutlined: return typeof(CircleExclamationOutlined);
            case GravityIconKind.CircleExclamationFilled: return typeof(CircleExclamationFilled);
            case GravityIconKind.CircleInfoOutlined: return typeof(CircleInfoOutlined);
            case GravityIconKind.CircleInfoFilled: return typeof(CircleInfoFilled);
            case GravityIconKind.CircleLetterAOutlined: return typeof(CircleLetterAOutlined);
            case GravityIconKind.CircleLetterBOutlined: return typeof(CircleLetterBOutlined);
            case GravityIconKind.CircleLetterCOutlined: return typeof(CircleLetterCOutlined);
            case GravityIconKind.CircleLetterDOutlined: return typeof(CircleLetterDOutlined);
            case GravityIconKind.CircleLetterEOutlined: return typeof(CircleLetterEOutlined);
            case GravityIconKind.CircleLetterFOutlined: return typeof(CircleLetterFOutlined);
            case GravityIconKind.CircleLetterGOutlined: return typeof(CircleLetterGOutlined);
            case GravityIconKind.CircleLetterHOutlined: return typeof(CircleLetterHOutlined);
            case GravityIconKind.CircleLetterIOutlined: return typeof(CircleLetterIOutlined);
            case GravityIconKind.CircleLetterJOutlined: return typeof(CircleLetterJOutlined);
            case GravityIconKind.CircleLetterKOutlined: return typeof(CircleLetterKOutlined);
            case GravityIconKind.CircleLetterLOutlined: return typeof(CircleLetterLOutlined);
            case GravityIconKind.CircleLetterMOutlined: return typeof(CircleLetterMOutlined);
            case GravityIconKind.CircleLetterNOutlined: return typeof(CircleLetterNOutlined);
            case GravityIconKind.CircleLetterOOutlined: return typeof(CircleLetterOOutlined);
            case GravityIconKind.CircleLetterPOutlined: return typeof(CircleLetterPOutlined);
            case GravityIconKind.CircleLetterQOutlined: return typeof(CircleLetterQOutlined);
            case GravityIconKind.CircleLetterROutlined: return typeof(CircleLetterROutlined);
            case GravityIconKind.CircleLetterSOutlined: return typeof(CircleLetterSOutlined);
            case GravityIconKind.CircleLetterTOutlined: return typeof(CircleLetterTOutlined);
            case GravityIconKind.CircleLetterUOutlined: return typeof(CircleLetterUOutlined);
            case GravityIconKind.CircleLetterVOutlined: return typeof(CircleLetterVOutlined);
            case GravityIconKind.CircleLetterWOutlined: return typeof(CircleLetterWOutlined);
            case GravityIconKind.CircleLetterXOutlined: return typeof(CircleLetterXOutlined);
            case GravityIconKind.CircleLetterYOutlined: return typeof(CircleLetterYOutlined);
            case GravityIconKind.CircleLetterZOutlined: return typeof(CircleLetterZOutlined);
            case GravityIconKind.CircleLinkOutlined: return typeof(CircleLinkOutlined);
            case GravityIconKind.CircleMinusOutlined: return typeof(CircleMinusOutlined);
            case GravityIconKind.CircleMinusFilled: return typeof(CircleMinusFilled);
            case GravityIconKind.CircleNumber0Outlined: return typeof(CircleNumber0Outlined);
            case GravityIconKind.CircleNumber0Filled: return typeof(CircleNumber0Filled);
            case GravityIconKind.CircleNumber1Outlined: return typeof(CircleNumber1Outlined);
            case GravityIconKind.CircleNumber1Filled: return typeof(CircleNumber1Filled);
            case GravityIconKind.CircleNumber2Outlined: return typeof(CircleNumber2Outlined);
            case GravityIconKind.CircleNumber2Filled: return typeof(CircleNumber2Filled);
            case GravityIconKind.CircleNumber3Outlined: return typeof(CircleNumber3Outlined);
            case GravityIconKind.CircleNumber3Filled: return typeof(CircleNumber3Filled);
            case GravityIconKind.CircleNumber4Outlined: return typeof(CircleNumber4Outlined);
            case GravityIconKind.CircleNumber4Filled: return typeof(CircleNumber4Filled);
            case GravityIconKind.CircleNumber5Outlined: return typeof(CircleNumber5Outlined);
            case GravityIconKind.CircleNumber5Filled: return typeof(CircleNumber5Filled);
            case GravityIconKind.CircleNumber6Outlined: return typeof(CircleNumber6Outlined);
            case GravityIconKind.CircleNumber6Filled: return typeof(CircleNumber6Filled);
            case GravityIconKind.CircleNumber7Outlined: return typeof(CircleNumber7Outlined);
            case GravityIconKind.CircleNumber7Filled: return typeof(CircleNumber7Filled);
            case GravityIconKind.CircleNumber8Outlined: return typeof(CircleNumber8Outlined);
            case GravityIconKind.CircleNumber8Filled: return typeof(CircleNumber8Filled);
            case GravityIconKind.CircleNumber9Outlined: return typeof(CircleNumber9Outlined);
            case GravityIconKind.CircleNumber9Filled: return typeof(CircleNumber9Filled);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk3(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.CircleChevronLeftFilled => new CircleChevronLeftFilled(),
            GravityIconKind.CircleChevronRightOutlined => new CircleChevronRightOutlined(),
            GravityIconKind.CircleChevronRightFilled => new CircleChevronRightFilled(),
            GravityIconKind.CircleChevronUpOutlined => new CircleChevronUpOutlined(),
            GravityIconKind.CircleChevronUpFilled => new CircleChevronUpFilled(),
            GravityIconKind.CircleChevronsDownOutlined => new CircleChevronsDownOutlined(),
            GravityIconKind.CircleChevronsLeftOutlined => new CircleChevronsLeftOutlined(),
            GravityIconKind.CircleChevronsRightOutlined => new CircleChevronsRightOutlined(),
            GravityIconKind.CircleChevronsUpOutlined => new CircleChevronsUpOutlined(),
            GravityIconKind.CircleDashedOutlined => new CircleDashedOutlined(),
            GravityIconKind.CircleDollarOutlined => new CircleDollarOutlined(),
            GravityIconKind.CircleExclamationOutlined => new CircleExclamationOutlined(),
            GravityIconKind.CircleExclamationFilled => new CircleExclamationFilled(),
            GravityIconKind.CircleInfoOutlined => new CircleInfoOutlined(),
            GravityIconKind.CircleInfoFilled => new CircleInfoFilled(),
            GravityIconKind.CircleLetterAOutlined => new CircleLetterAOutlined(),
            GravityIconKind.CircleLetterBOutlined => new CircleLetterBOutlined(),
            GravityIconKind.CircleLetterCOutlined => new CircleLetterCOutlined(),
            GravityIconKind.CircleLetterDOutlined => new CircleLetterDOutlined(),
            GravityIconKind.CircleLetterEOutlined => new CircleLetterEOutlined(),
            GravityIconKind.CircleLetterFOutlined => new CircleLetterFOutlined(),
            GravityIconKind.CircleLetterGOutlined => new CircleLetterGOutlined(),
            GravityIconKind.CircleLetterHOutlined => new CircleLetterHOutlined(),
            GravityIconKind.CircleLetterIOutlined => new CircleLetterIOutlined(),
            GravityIconKind.CircleLetterJOutlined => new CircleLetterJOutlined(),
            GravityIconKind.CircleLetterKOutlined => new CircleLetterKOutlined(),
            GravityIconKind.CircleLetterLOutlined => new CircleLetterLOutlined(),
            GravityIconKind.CircleLetterMOutlined => new CircleLetterMOutlined(),
            GravityIconKind.CircleLetterNOutlined => new CircleLetterNOutlined(),
            GravityIconKind.CircleLetterOOutlined => new CircleLetterOOutlined(),
            GravityIconKind.CircleLetterPOutlined => new CircleLetterPOutlined(),
            GravityIconKind.CircleLetterQOutlined => new CircleLetterQOutlined(),
            GravityIconKind.CircleLetterROutlined => new CircleLetterROutlined(),
            GravityIconKind.CircleLetterSOutlined => new CircleLetterSOutlined(),
            GravityIconKind.CircleLetterTOutlined => new CircleLetterTOutlined(),
            GravityIconKind.CircleLetterUOutlined => new CircleLetterUOutlined(),
            GravityIconKind.CircleLetterVOutlined => new CircleLetterVOutlined(),
            GravityIconKind.CircleLetterWOutlined => new CircleLetterWOutlined(),
            GravityIconKind.CircleLetterXOutlined => new CircleLetterXOutlined(),
            GravityIconKind.CircleLetterYOutlined => new CircleLetterYOutlined(),
            GravityIconKind.CircleLetterZOutlined => new CircleLetterZOutlined(),
            GravityIconKind.CircleLinkOutlined => new CircleLinkOutlined(),
            GravityIconKind.CircleMinusOutlined => new CircleMinusOutlined(),
            GravityIconKind.CircleMinusFilled => new CircleMinusFilled(),
            GravityIconKind.CircleNumber0Outlined => new CircleNumber0Outlined(),
            GravityIconKind.CircleNumber0Filled => new CircleNumber0Filled(),
            GravityIconKind.CircleNumber1Outlined => new CircleNumber1Outlined(),
            GravityIconKind.CircleNumber1Filled => new CircleNumber1Filled(),
            GravityIconKind.CircleNumber2Outlined => new CircleNumber2Outlined(),
            GravityIconKind.CircleNumber2Filled => new CircleNumber2Filled(),
            GravityIconKind.CircleNumber3Outlined => new CircleNumber3Outlined(),
            GravityIconKind.CircleNumber3Filled => new CircleNumber3Filled(),
            GravityIconKind.CircleNumber4Outlined => new CircleNumber4Outlined(),
            GravityIconKind.CircleNumber4Filled => new CircleNumber4Filled(),
            GravityIconKind.CircleNumber5Outlined => new CircleNumber5Outlined(),
            GravityIconKind.CircleNumber5Filled => new CircleNumber5Filled(),
            GravityIconKind.CircleNumber6Outlined => new CircleNumber6Outlined(),
            GravityIconKind.CircleNumber6Filled => new CircleNumber6Filled(),
            GravityIconKind.CircleNumber7Outlined => new CircleNumber7Outlined(),
            GravityIconKind.CircleNumber7Filled => new CircleNumber7Filled(),
            GravityIconKind.CircleNumber8Outlined => new CircleNumber8Outlined(),
            GravityIconKind.CircleNumber8Filled => new CircleNumber8Filled(),
            GravityIconKind.CircleNumber9Outlined => new CircleNumber9Outlined(),
            GravityIconKind.CircleNumber9Filled => new CircleNumber9Filled(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk4(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.CirclePauseOutlined: return typeof(CirclePauseOutlined);
            case GravityIconKind.CirclePauseFilled: return typeof(CirclePauseFilled);
            case GravityIconKind.CirclePlayOutlined: return typeof(CirclePlayOutlined);
            case GravityIconKind.CirclePlayFilled: return typeof(CirclePlayFilled);
            case GravityIconKind.CirclePlusOutlined: return typeof(CirclePlusOutlined);
            case GravityIconKind.CirclePlusFilled: return typeof(CirclePlusFilled);
            case GravityIconKind.CircleQuestionOutlined: return typeof(CircleQuestionOutlined);
            case GravityIconKind.CircleQuestionFilled: return typeof(CircleQuestionFilled);
            case GravityIconKind.CircleQuestionDotOutlined: return typeof(CircleQuestionDotOutlined);
            case GravityIconKind.CircleRubleOutlined: return typeof(CircleRubleOutlined);
            case GravityIconKind.CircleStopOutlined: return typeof(CircleStopOutlined);
            case GravityIconKind.CircleStopFilled: return typeof(CircleStopFilled);
            case GravityIconKind.CircleTreeOutlined: return typeof(CircleTreeOutlined);
            case GravityIconKind.CircleXmarkOutlined: return typeof(CircleXmarkOutlined);
            case GravityIconKind.CircleXmarkFilled: return typeof(CircleXmarkFilled);
            case GravityIconKind.Circles3PlusOutlined: return typeof(Circles3PlusOutlined);
            case GravityIconKind.Circles4DiamondOutlined: return typeof(Circles4DiamondOutlined);
            case GravityIconKind.Circles4SquareOutlined: return typeof(Circles4SquareOutlined);
            case GravityIconKind.Circles5RandomOutlined: return typeof(Circles5RandomOutlined);
            case GravityIconKind.CirclesConcentricOutlined: return typeof(CirclesConcentricOutlined);
            case GravityIconKind.CirclesIntersectionOutlined: return typeof(CirclesIntersectionOutlined);
            case GravityIconKind.ClockOutlined: return typeof(ClockOutlined);
            case GravityIconKind.ClockFilled: return typeof(ClockFilled);
            case GravityIconKind.ClockArrowRotateLeftOutlined: return typeof(ClockArrowRotateLeftOutlined);
            case GravityIconKind.CloudOutlined: return typeof(CloudOutlined);
            case GravityIconKind.CloudArrowUpInOutlined: return typeof(CloudArrowUpInOutlined);
            case GravityIconKind.CloudCheckOutlined: return typeof(CloudCheckOutlined);
            case GravityIconKind.CloudGearOutlined: return typeof(CloudGearOutlined);
            case GravityIconKind.CloudNutHexOutlined: return typeof(CloudNutHexOutlined);
            case GravityIconKind.CloudSlashOutlined: return typeof(CloudSlashOutlined);
            case GravityIconKind.CloudsOutlined: return typeof(CloudsOutlined);
            case GravityIconKind.CodeOutlined: return typeof(CodeOutlined);
            case GravityIconKind.CodeCommitOutlined: return typeof(CodeCommitOutlined);
            case GravityIconKind.CodeCommitHorizontalOutlined: return typeof(CodeCommitHorizontalOutlined);
            case GravityIconKind.CodeCommitsOutlined: return typeof(CodeCommitsOutlined);
            case GravityIconKind.CodeCompareOutlined: return typeof(CodeCompareOutlined);
            case GravityIconKind.CodeForkOutlined: return typeof(CodeForkOutlined);
            case GravityIconKind.CodeMergeOutlined: return typeof(CodeMergeOutlined);
            case GravityIconKind.CodePullRequestOutlined: return typeof(CodePullRequestOutlined);
            case GravityIconKind.CodePullRequestArrowLeftOutlined: return typeof(CodePullRequestArrowLeftOutlined);
            case GravityIconKind.CodePullRequestArrowRightOutlined: return typeof(CodePullRequestArrowRightOutlined);
            case GravityIconKind.CodePullRequestCheckOutlined: return typeof(CodePullRequestCheckOutlined);
            case GravityIconKind.CodePullRequestXmarkOutlined: return typeof(CodePullRequestXmarkOutlined);
            case GravityIconKind.CodeTrunkOutlined: return typeof(CodeTrunkOutlined);
            case GravityIconKind.CommentOutlined: return typeof(CommentOutlined);
            case GravityIconKind.CommentFilled: return typeof(CommentFilled);
            case GravityIconKind.CommentDotOutlined: return typeof(CommentDotOutlined);
            case GravityIconKind.CommentPlusOutlined: return typeof(CommentPlusOutlined);
            case GravityIconKind.CommentSlashOutlined: return typeof(CommentSlashOutlined);
            case GravityIconKind.CommentsOutlined: return typeof(CommentsOutlined);
            case GravityIconKind.CommentsDotOutlined: return typeof(CommentsDotOutlined);
            case GravityIconKind.CompassOutlined: return typeof(CompassOutlined);
            case GravityIconKind.CookieOutlined: return typeof(CookieOutlined);
            case GravityIconKind.CopyOutlined: return typeof(CopyOutlined);
            case GravityIconKind.CopyArrowRightOutlined: return typeof(CopyArrowRightOutlined);
            case GravityIconKind.CopyCheckOutlined: return typeof(CopyCheckOutlined);
            case GravityIconKind.CopyCheckXmarkOutlined: return typeof(CopyCheckXmarkOutlined);
            case GravityIconKind.CopyChevronRightOutlined: return typeof(CopyChevronRightOutlined);
            case GravityIconKind.CopyMinusOutlined: return typeof(CopyMinusOutlined);
            case GravityIconKind.CopyPictureOutlined: return typeof(CopyPictureOutlined);
            case GravityIconKind.CopyPlusOutlined: return typeof(CopyPlusOutlined);
            case GravityIconKind.CopyTransparentOutlined: return typeof(CopyTransparentOutlined);
            case GravityIconKind.CopyXmarkOutlined: return typeof(CopyXmarkOutlined);
            case GravityIconKind.CpuOutlined: return typeof(CpuOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk4(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.CirclePauseOutlined => new CirclePauseOutlined(),
            GravityIconKind.CirclePauseFilled => new CirclePauseFilled(),
            GravityIconKind.CirclePlayOutlined => new CirclePlayOutlined(),
            GravityIconKind.CirclePlayFilled => new CirclePlayFilled(),
            GravityIconKind.CirclePlusOutlined => new CirclePlusOutlined(),
            GravityIconKind.CirclePlusFilled => new CirclePlusFilled(),
            GravityIconKind.CircleQuestionOutlined => new CircleQuestionOutlined(),
            GravityIconKind.CircleQuestionFilled => new CircleQuestionFilled(),
            GravityIconKind.CircleQuestionDotOutlined => new CircleQuestionDotOutlined(),
            GravityIconKind.CircleRubleOutlined => new CircleRubleOutlined(),
            GravityIconKind.CircleStopOutlined => new CircleStopOutlined(),
            GravityIconKind.CircleStopFilled => new CircleStopFilled(),
            GravityIconKind.CircleTreeOutlined => new CircleTreeOutlined(),
            GravityIconKind.CircleXmarkOutlined => new CircleXmarkOutlined(),
            GravityIconKind.CircleXmarkFilled => new CircleXmarkFilled(),
            GravityIconKind.Circles3PlusOutlined => new Circles3PlusOutlined(),
            GravityIconKind.Circles4DiamondOutlined => new Circles4DiamondOutlined(),
            GravityIconKind.Circles4SquareOutlined => new Circles4SquareOutlined(),
            GravityIconKind.Circles5RandomOutlined => new Circles5RandomOutlined(),
            GravityIconKind.CirclesConcentricOutlined => new CirclesConcentricOutlined(),
            GravityIconKind.CirclesIntersectionOutlined => new CirclesIntersectionOutlined(),
            GravityIconKind.ClockOutlined => new ClockOutlined(),
            GravityIconKind.ClockFilled => new ClockFilled(),
            GravityIconKind.ClockArrowRotateLeftOutlined => new ClockArrowRotateLeftOutlined(),
            GravityIconKind.CloudOutlined => new CloudOutlined(),
            GravityIconKind.CloudArrowUpInOutlined => new CloudArrowUpInOutlined(),
            GravityIconKind.CloudCheckOutlined => new CloudCheckOutlined(),
            GravityIconKind.CloudGearOutlined => new CloudGearOutlined(),
            GravityIconKind.CloudNutHexOutlined => new CloudNutHexOutlined(),
            GravityIconKind.CloudSlashOutlined => new CloudSlashOutlined(),
            GravityIconKind.CloudsOutlined => new CloudsOutlined(),
            GravityIconKind.CodeOutlined => new CodeOutlined(),
            GravityIconKind.CodeCommitOutlined => new CodeCommitOutlined(),
            GravityIconKind.CodeCommitHorizontalOutlined => new CodeCommitHorizontalOutlined(),
            GravityIconKind.CodeCommitsOutlined => new CodeCommitsOutlined(),
            GravityIconKind.CodeCompareOutlined => new CodeCompareOutlined(),
            GravityIconKind.CodeForkOutlined => new CodeForkOutlined(),
            GravityIconKind.CodeMergeOutlined => new CodeMergeOutlined(),
            GravityIconKind.CodePullRequestOutlined => new CodePullRequestOutlined(),
            GravityIconKind.CodePullRequestArrowLeftOutlined => new CodePullRequestArrowLeftOutlined(),
            GravityIconKind.CodePullRequestArrowRightOutlined => new CodePullRequestArrowRightOutlined(),
            GravityIconKind.CodePullRequestCheckOutlined => new CodePullRequestCheckOutlined(),
            GravityIconKind.CodePullRequestXmarkOutlined => new CodePullRequestXmarkOutlined(),
            GravityIconKind.CodeTrunkOutlined => new CodeTrunkOutlined(),
            GravityIconKind.CommentOutlined => new CommentOutlined(),
            GravityIconKind.CommentFilled => new CommentFilled(),
            GravityIconKind.CommentDotOutlined => new CommentDotOutlined(),
            GravityIconKind.CommentPlusOutlined => new CommentPlusOutlined(),
            GravityIconKind.CommentSlashOutlined => new CommentSlashOutlined(),
            GravityIconKind.CommentsOutlined => new CommentsOutlined(),
            GravityIconKind.CommentsDotOutlined => new CommentsDotOutlined(),
            GravityIconKind.CompassOutlined => new CompassOutlined(),
            GravityIconKind.CookieOutlined => new CookieOutlined(),
            GravityIconKind.CopyOutlined => new CopyOutlined(),
            GravityIconKind.CopyArrowRightOutlined => new CopyArrowRightOutlined(),
            GravityIconKind.CopyCheckOutlined => new CopyCheckOutlined(),
            GravityIconKind.CopyCheckXmarkOutlined => new CopyCheckXmarkOutlined(),
            GravityIconKind.CopyChevronRightOutlined => new CopyChevronRightOutlined(),
            GravityIconKind.CopyMinusOutlined => new CopyMinusOutlined(),
            GravityIconKind.CopyPictureOutlined => new CopyPictureOutlined(),
            GravityIconKind.CopyPlusOutlined => new CopyPlusOutlined(),
            GravityIconKind.CopyTransparentOutlined => new CopyTransparentOutlined(),
            GravityIconKind.CopyXmarkOutlined => new CopyXmarkOutlined(),
            GravityIconKind.CpuOutlined => new CpuOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk5(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.CpusOutlined: return typeof(CpusOutlined);
            case GravityIconKind.CreditCardOutlined: return typeof(CreditCardOutlined);
            case GravityIconKind.CropOutlined: return typeof(CropOutlined);
            case GravityIconKind.CrownDiamondOutlined: return typeof(CrownDiamondOutlined);
            case GravityIconKind.CubeOutlined: return typeof(CubeOutlined);
            case GravityIconKind.Cubes3Outlined: return typeof(Cubes3Outlined);
            case GravityIconKind.Cubes3OverlapOutlined: return typeof(Cubes3OverlapOutlined);
            case GravityIconKind.CupOutlined: return typeof(CupOutlined);
            case GravityIconKind.CurlyBracketsOutlined: return typeof(CurlyBracketsOutlined);
            case GravityIconKind.CurlyBracketsFunctionOutlined: return typeof(CurlyBracketsFunctionOutlined);
            case GravityIconKind.CurlyBracketsLockOutlined: return typeof(CurlyBracketsLockOutlined);
            case GravityIconKind.DatabaseOutlined: return typeof(DatabaseOutlined);
            case GravityIconKind.DatabaseFilled: return typeof(DatabaseFilled);
            case GravityIconKind.DatabaseArrowRightOutlined: return typeof(DatabaseArrowRightOutlined);
            case GravityIconKind.DatabaseMagnifierOutlined: return typeof(DatabaseMagnifierOutlined);
            case GravityIconKind.DatabaseNutHexOutlined: return typeof(DatabaseNutHexOutlined);
            case GravityIconKind.DatabasePlusOutlined: return typeof(DatabasePlusOutlined);
            case GravityIconKind.DatabasesOutlined: return typeof(DatabasesOutlined);
            case GravityIconKind.DatabasesFilled: return typeof(DatabasesFilled);
            case GravityIconKind.DeleteOutlined: return typeof(DeleteOutlined);
            case GravityIconKind.DiamondOutlined: return typeof(DiamondOutlined);
            case GravityIconKind.DiamondFilled: return typeof(DiamondFilled);
            case GravityIconKind.DiamondExclamationOutlined: return typeof(DiamondExclamationOutlined);
            case GravityIconKind.DiamondExclamationFilled: return typeof(DiamondExclamationFilled);
            case GravityIconKind.Dice1Outlined: return typeof(Dice1Outlined);
            case GravityIconKind.Dice2Outlined: return typeof(Dice2Outlined);
            case GravityIconKind.Dice3Outlined: return typeof(Dice3Outlined);
            case GravityIconKind.Dice4Outlined: return typeof(Dice4Outlined);
            case GravityIconKind.Dice5Outlined: return typeof(Dice5Outlined);
            case GravityIconKind.Dice6Outlined: return typeof(Dice6Outlined);
            case GravityIconKind.DisplayOutlined: return typeof(DisplayOutlined);
            case GravityIconKind.DisplayPulseOutlined: return typeof(DisplayPulseOutlined);
            case GravityIconKind.Dots9Outlined: return typeof(Dots9Outlined);
            case GravityIconKind.DropletOutlined: return typeof(DropletOutlined);
            case GravityIconKind.EarOutlined: return typeof(EarOutlined);
            case GravityIconKind.EllipsisOutlined: return typeof(EllipsisOutlined);
            case GravityIconKind.EllipsisVerticalOutlined: return typeof(EllipsisVerticalOutlined);
            case GravityIconKind.EnvelopeOutlined: return typeof(EnvelopeOutlined);
            case GravityIconKind.EnvelopeOpenOutlined: return typeof(EnvelopeOpenOutlined);
            case GravityIconKind.EnvelopeOpenXmarkOutlined: return typeof(EnvelopeOpenXmarkOutlined);
            case GravityIconKind.EqualOutlined: return typeof(EqualOutlined);
            case GravityIconKind.EraserOutlined: return typeof(EraserOutlined);
            case GravityIconKind.ExclamationShapeOutlined: return typeof(ExclamationShapeOutlined);
            case GravityIconKind.ExclamationShapeFilled: return typeof(ExclamationShapeFilled);
            case GravityIconKind.EyeOutlined: return typeof(EyeOutlined);
            case GravityIconKind.EyeClosedOutlined: return typeof(EyeClosedOutlined);
            case GravityIconKind.EyeDashedOutlined: return typeof(EyeDashedOutlined);
            case GravityIconKind.EyeSlashOutlined: return typeof(EyeSlashOutlined);
            case GravityIconKind.EyesLookLeftOutlined: return typeof(EyesLookLeftOutlined);
            case GravityIconKind.EyesLookRightOutlined: return typeof(EyesLookRightOutlined);
            case GravityIconKind.FaceAlienOutlined: return typeof(FaceAlienOutlined);
            case GravityIconKind.FaceAngryOutlined: return typeof(FaceAngryOutlined);
            case GravityIconKind.FaceFunOutlined: return typeof(FaceFunOutlined);
            case GravityIconKind.FaceNeutralOutlined: return typeof(FaceNeutralOutlined);
            case GravityIconKind.FaceNeutralDashedOutlined: return typeof(FaceNeutralDashedOutlined);
            case GravityIconKind.FaceRobotOutlined: return typeof(FaceRobotOutlined);
            case GravityIconKind.FaceRobotSmileOutlined: return typeof(FaceRobotSmileOutlined);
            case GravityIconKind.FaceSadOutlined: return typeof(FaceSadOutlined);
            case GravityIconKind.FaceSmileOutlined: return typeof(FaceSmileOutlined);
            case GravityIconKind.FaceSurpriseOutlined: return typeof(FaceSurpriseOutlined);
            case GravityIconKind.FactoryOutlined: return typeof(FactoryOutlined);
            case GravityIconKind.FileOutlined: return typeof(FileOutlined);
            case GravityIconKind.FileArrowDownOutlined: return typeof(FileArrowDownOutlined);
            case GravityIconKind.FileArrowLeftOutlined: return typeof(FileArrowLeftOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk5(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.CpusOutlined => new CpusOutlined(),
            GravityIconKind.CreditCardOutlined => new CreditCardOutlined(),
            GravityIconKind.CropOutlined => new CropOutlined(),
            GravityIconKind.CrownDiamondOutlined => new CrownDiamondOutlined(),
            GravityIconKind.CubeOutlined => new CubeOutlined(),
            GravityIconKind.Cubes3Outlined => new Cubes3Outlined(),
            GravityIconKind.Cubes3OverlapOutlined => new Cubes3OverlapOutlined(),
            GravityIconKind.CupOutlined => new CupOutlined(),
            GravityIconKind.CurlyBracketsOutlined => new CurlyBracketsOutlined(),
            GravityIconKind.CurlyBracketsFunctionOutlined => new CurlyBracketsFunctionOutlined(),
            GravityIconKind.CurlyBracketsLockOutlined => new CurlyBracketsLockOutlined(),
            GravityIconKind.DatabaseOutlined => new DatabaseOutlined(),
            GravityIconKind.DatabaseFilled => new DatabaseFilled(),
            GravityIconKind.DatabaseArrowRightOutlined => new DatabaseArrowRightOutlined(),
            GravityIconKind.DatabaseMagnifierOutlined => new DatabaseMagnifierOutlined(),
            GravityIconKind.DatabaseNutHexOutlined => new DatabaseNutHexOutlined(),
            GravityIconKind.DatabasePlusOutlined => new DatabasePlusOutlined(),
            GravityIconKind.DatabasesOutlined => new DatabasesOutlined(),
            GravityIconKind.DatabasesFilled => new DatabasesFilled(),
            GravityIconKind.DeleteOutlined => new DeleteOutlined(),
            GravityIconKind.DiamondOutlined => new DiamondOutlined(),
            GravityIconKind.DiamondFilled => new DiamondFilled(),
            GravityIconKind.DiamondExclamationOutlined => new DiamondExclamationOutlined(),
            GravityIconKind.DiamondExclamationFilled => new DiamondExclamationFilled(),
            GravityIconKind.Dice1Outlined => new Dice1Outlined(),
            GravityIconKind.Dice2Outlined => new Dice2Outlined(),
            GravityIconKind.Dice3Outlined => new Dice3Outlined(),
            GravityIconKind.Dice4Outlined => new Dice4Outlined(),
            GravityIconKind.Dice5Outlined => new Dice5Outlined(),
            GravityIconKind.Dice6Outlined => new Dice6Outlined(),
            GravityIconKind.DisplayOutlined => new DisplayOutlined(),
            GravityIconKind.DisplayPulseOutlined => new DisplayPulseOutlined(),
            GravityIconKind.Dots9Outlined => new Dots9Outlined(),
            GravityIconKind.DropletOutlined => new DropletOutlined(),
            GravityIconKind.EarOutlined => new EarOutlined(),
            GravityIconKind.EllipsisOutlined => new EllipsisOutlined(),
            GravityIconKind.EllipsisVerticalOutlined => new EllipsisVerticalOutlined(),
            GravityIconKind.EnvelopeOutlined => new EnvelopeOutlined(),
            GravityIconKind.EnvelopeOpenOutlined => new EnvelopeOpenOutlined(),
            GravityIconKind.EnvelopeOpenXmarkOutlined => new EnvelopeOpenXmarkOutlined(),
            GravityIconKind.EqualOutlined => new EqualOutlined(),
            GravityIconKind.EraserOutlined => new EraserOutlined(),
            GravityIconKind.ExclamationShapeOutlined => new ExclamationShapeOutlined(),
            GravityIconKind.ExclamationShapeFilled => new ExclamationShapeFilled(),
            GravityIconKind.EyeOutlined => new EyeOutlined(),
            GravityIconKind.EyeClosedOutlined => new EyeClosedOutlined(),
            GravityIconKind.EyeDashedOutlined => new EyeDashedOutlined(),
            GravityIconKind.EyeSlashOutlined => new EyeSlashOutlined(),
            GravityIconKind.EyesLookLeftOutlined => new EyesLookLeftOutlined(),
            GravityIconKind.EyesLookRightOutlined => new EyesLookRightOutlined(),
            GravityIconKind.FaceAlienOutlined => new FaceAlienOutlined(),
            GravityIconKind.FaceAngryOutlined => new FaceAngryOutlined(),
            GravityIconKind.FaceFunOutlined => new FaceFunOutlined(),
            GravityIconKind.FaceNeutralOutlined => new FaceNeutralOutlined(),
            GravityIconKind.FaceNeutralDashedOutlined => new FaceNeutralDashedOutlined(),
            GravityIconKind.FaceRobotOutlined => new FaceRobotOutlined(),
            GravityIconKind.FaceRobotSmileOutlined => new FaceRobotSmileOutlined(),
            GravityIconKind.FaceSadOutlined => new FaceSadOutlined(),
            GravityIconKind.FaceSmileOutlined => new FaceSmileOutlined(),
            GravityIconKind.FaceSurpriseOutlined => new FaceSurpriseOutlined(),
            GravityIconKind.FactoryOutlined => new FactoryOutlined(),
            GravityIconKind.FileOutlined => new FileOutlined(),
            GravityIconKind.FileArrowDownOutlined => new FileArrowDownOutlined(),
            GravityIconKind.FileArrowLeftOutlined => new FileArrowLeftOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk6(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.FileArrowRightOutlined: return typeof(FileArrowRightOutlined);
            case GravityIconKind.FileArrowRightOutOutlined: return typeof(FileArrowRightOutOutlined);
            case GravityIconKind.FileArrowUpOutlined: return typeof(FileArrowUpOutlined);
            case GravityIconKind.FileCheckOutlined: return typeof(FileCheckOutlined);
            case GravityIconKind.FileCodeOutlined: return typeof(FileCodeOutlined);
            case GravityIconKind.FileDollarOutlined: return typeof(FileDollarOutlined);
            case GravityIconKind.FileExclamationOutlined: return typeof(FileExclamationOutlined);
            case GravityIconKind.FileLetterPOutlined: return typeof(FileLetterPOutlined);
            case GravityIconKind.FileLetterWOutlined: return typeof(FileLetterWOutlined);
            case GravityIconKind.FileLetterXOutlined: return typeof(FileLetterXOutlined);
            case GravityIconKind.FileMagnifierOutlined: return typeof(FileMagnifierOutlined);
            case GravityIconKind.FileMinusOutlined: return typeof(FileMinusOutlined);
            case GravityIconKind.FilePlusOutlined: return typeof(FilePlusOutlined);
            case GravityIconKind.FileQuestionOutlined: return typeof(FileQuestionOutlined);
            case GravityIconKind.FileRubleOutlined: return typeof(FileRubleOutlined);
            case GravityIconKind.FileTextOutlined: return typeof(FileTextOutlined);
            case GravityIconKind.FileXmarkOutlined: return typeof(FileXmarkOutlined);
            case GravityIconKind.FileZipperOutlined: return typeof(FileZipperOutlined);
            case GravityIconKind.FilesOutlined: return typeof(FilesOutlined);
            case GravityIconKind.FilmstripOutlined: return typeof(FilmstripOutlined);
            case GravityIconKind.FingerprintOutlined: return typeof(FingerprintOutlined);
            case GravityIconKind.FirewallOutlined: return typeof(FirewallOutlined);
            case GravityIconKind.FlagOutlined: return typeof(FlagOutlined);
            case GravityIconKind.FlameOutlined: return typeof(FlameOutlined);
            case GravityIconKind.FlaskOutlined: return typeof(FlaskOutlined);
            case GravityIconKind.FloppyDiskOutlined: return typeof(FloppyDiskOutlined);
            case GravityIconKind.FolderOutlined: return typeof(FolderOutlined);
            case GravityIconKind.FolderFilled: return typeof(FolderFilled);
            case GravityIconKind.FolderArrowDownOutlined: return typeof(FolderArrowDownOutlined);
            case GravityIconKind.FolderArrowLeftOutlined: return typeof(FolderArrowLeftOutlined);
            case GravityIconKind.FolderArrowRightOutlined: return typeof(FolderArrowRightOutlined);
            case GravityIconKind.FolderArrowUpOutlined: return typeof(FolderArrowUpOutlined);
            case GravityIconKind.FolderArrowUpInOutlined: return typeof(FolderArrowUpInOutlined);
            case GravityIconKind.FolderCheckOutlined: return typeof(FolderCheckOutlined);
            case GravityIconKind.FolderCodeOutlined: return typeof(FolderCodeOutlined);
            case GravityIconKind.FolderExclamationOutlined: return typeof(FolderExclamationOutlined);
            case GravityIconKind.FolderFlowsOutlined: return typeof(FolderFlowsOutlined);
            case GravityIconKind.FolderHouseOutlined: return typeof(FolderHouseOutlined);
            case GravityIconKind.FolderKeyholeOutlined: return typeof(FolderKeyholeOutlined);
            case GravityIconKind.FolderLockOutlined: return typeof(FolderLockOutlined);
            case GravityIconKind.FolderMagnifierOutlined: return typeof(FolderMagnifierOutlined);
            case GravityIconKind.FolderOpenOutlined: return typeof(FolderOpenOutlined);
            case GravityIconKind.FolderOpenFilled: return typeof(FolderOpenFilled);
            case GravityIconKind.FolderPlusOutlined: return typeof(FolderPlusOutlined);
            case GravityIconKind.FolderTreeOutlined: return typeof(FolderTreeOutlined);
            case GravityIconKind.FoldersOutlined: return typeof(FoldersOutlined);
            case GravityIconKind.FontOutlined: return typeof(FontOutlined);
            case GravityIconKind.FontCaseOutlined: return typeof(FontCaseOutlined);
            case GravityIconKind.FontCursorOutlined: return typeof(FontCursorOutlined);
            case GravityIconKind.ForwardStepOutlined: return typeof(ForwardStepOutlined);
            case GravityIconKind.ForwardStepFilled: return typeof(ForwardStepFilled);
            case GravityIconKind.FrameOutlined: return typeof(FrameOutlined);
            case GravityIconKind.FramesOutlined: return typeof(FramesOutlined);
            case GravityIconKind.FunctionOutlined: return typeof(FunctionOutlined);
            case GravityIconKind.FunnelOutlined: return typeof(FunnelOutlined);
            case GravityIconKind.FunnelXmarkOutlined: return typeof(FunnelXmarkOutlined);
            case GravityIconKind.GearOutlined: return typeof(GearOutlined);
            case GravityIconKind.GearBranchesOutlined: return typeof(GearBranchesOutlined);
            case GravityIconKind.GearDotOutlined: return typeof(GearDotOutlined);
            case GravityIconKind.GearPlayOutlined: return typeof(GearPlayOutlined);
            case GravityIconKind.GemOutlined: return typeof(GemOutlined);
            case GravityIconKind.GeoOutlined: return typeof(GeoOutlined);
            case GravityIconKind.GeoFilled: return typeof(GeoFilled);
            case GravityIconKind.GeoDotsOutlined: return typeof(GeoDotsOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk6(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.FileArrowRightOutlined => new FileArrowRightOutlined(),
            GravityIconKind.FileArrowRightOutOutlined => new FileArrowRightOutOutlined(),
            GravityIconKind.FileArrowUpOutlined => new FileArrowUpOutlined(),
            GravityIconKind.FileCheckOutlined => new FileCheckOutlined(),
            GravityIconKind.FileCodeOutlined => new FileCodeOutlined(),
            GravityIconKind.FileDollarOutlined => new FileDollarOutlined(),
            GravityIconKind.FileExclamationOutlined => new FileExclamationOutlined(),
            GravityIconKind.FileLetterPOutlined => new FileLetterPOutlined(),
            GravityIconKind.FileLetterWOutlined => new FileLetterWOutlined(),
            GravityIconKind.FileLetterXOutlined => new FileLetterXOutlined(),
            GravityIconKind.FileMagnifierOutlined => new FileMagnifierOutlined(),
            GravityIconKind.FileMinusOutlined => new FileMinusOutlined(),
            GravityIconKind.FilePlusOutlined => new FilePlusOutlined(),
            GravityIconKind.FileQuestionOutlined => new FileQuestionOutlined(),
            GravityIconKind.FileRubleOutlined => new FileRubleOutlined(),
            GravityIconKind.FileTextOutlined => new FileTextOutlined(),
            GravityIconKind.FileXmarkOutlined => new FileXmarkOutlined(),
            GravityIconKind.FileZipperOutlined => new FileZipperOutlined(),
            GravityIconKind.FilesOutlined => new FilesOutlined(),
            GravityIconKind.FilmstripOutlined => new FilmstripOutlined(),
            GravityIconKind.FingerprintOutlined => new FingerprintOutlined(),
            GravityIconKind.FirewallOutlined => new FirewallOutlined(),
            GravityIconKind.FlagOutlined => new FlagOutlined(),
            GravityIconKind.FlameOutlined => new FlameOutlined(),
            GravityIconKind.FlaskOutlined => new FlaskOutlined(),
            GravityIconKind.FloppyDiskOutlined => new FloppyDiskOutlined(),
            GravityIconKind.FolderOutlined => new FolderOutlined(),
            GravityIconKind.FolderFilled => new FolderFilled(),
            GravityIconKind.FolderArrowDownOutlined => new FolderArrowDownOutlined(),
            GravityIconKind.FolderArrowLeftOutlined => new FolderArrowLeftOutlined(),
            GravityIconKind.FolderArrowRightOutlined => new FolderArrowRightOutlined(),
            GravityIconKind.FolderArrowUpOutlined => new FolderArrowUpOutlined(),
            GravityIconKind.FolderArrowUpInOutlined => new FolderArrowUpInOutlined(),
            GravityIconKind.FolderCheckOutlined => new FolderCheckOutlined(),
            GravityIconKind.FolderCodeOutlined => new FolderCodeOutlined(),
            GravityIconKind.FolderExclamationOutlined => new FolderExclamationOutlined(),
            GravityIconKind.FolderFlowsOutlined => new FolderFlowsOutlined(),
            GravityIconKind.FolderHouseOutlined => new FolderHouseOutlined(),
            GravityIconKind.FolderKeyholeOutlined => new FolderKeyholeOutlined(),
            GravityIconKind.FolderLockOutlined => new FolderLockOutlined(),
            GravityIconKind.FolderMagnifierOutlined => new FolderMagnifierOutlined(),
            GravityIconKind.FolderOpenOutlined => new FolderOpenOutlined(),
            GravityIconKind.FolderOpenFilled => new FolderOpenFilled(),
            GravityIconKind.FolderPlusOutlined => new FolderPlusOutlined(),
            GravityIconKind.FolderTreeOutlined => new FolderTreeOutlined(),
            GravityIconKind.FoldersOutlined => new FoldersOutlined(),
            GravityIconKind.FontOutlined => new FontOutlined(),
            GravityIconKind.FontCaseOutlined => new FontCaseOutlined(),
            GravityIconKind.FontCursorOutlined => new FontCursorOutlined(),
            GravityIconKind.ForwardStepOutlined => new ForwardStepOutlined(),
            GravityIconKind.ForwardStepFilled => new ForwardStepFilled(),
            GravityIconKind.FrameOutlined => new FrameOutlined(),
            GravityIconKind.FramesOutlined => new FramesOutlined(),
            GravityIconKind.FunctionOutlined => new FunctionOutlined(),
            GravityIconKind.FunnelOutlined => new FunnelOutlined(),
            GravityIconKind.FunnelXmarkOutlined => new FunnelXmarkOutlined(),
            GravityIconKind.GearOutlined => new GearOutlined(),
            GravityIconKind.GearBranchesOutlined => new GearBranchesOutlined(),
            GravityIconKind.GearDotOutlined => new GearDotOutlined(),
            GravityIconKind.GearPlayOutlined => new GearPlayOutlined(),
            GravityIconKind.GemOutlined => new GemOutlined(),
            GravityIconKind.GeoOutlined => new GeoOutlined(),
            GravityIconKind.GeoFilled => new GeoFilled(),
            GravityIconKind.GeoDotsOutlined => new GeoDotsOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk7(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.GeoPinOutlined: return typeof(GeoPinOutlined);
            case GravityIconKind.GeoPolygonsOutlined: return typeof(GeoPolygonsOutlined);
            case GravityIconKind.GhostOutlined: return typeof(GhostOutlined);
            case GravityIconKind.GiftOutlined: return typeof(GiftOutlined);
            case GravityIconKind.GlobeOutlined: return typeof(GlobeOutlined);
            case GravityIconKind.GpuOutlined: return typeof(GpuOutlined);
            case GravityIconKind.GraduationCapOutlined: return typeof(GraduationCapOutlined);
            case GravityIconKind.GraphNodeOutlined: return typeof(GraphNodeOutlined);
            case GravityIconKind.GripOutlined: return typeof(GripOutlined);
            case GravityIconKind.GripHorizontalOutlined: return typeof(GripHorizontalOutlined);
            case GravityIconKind.HammerOutlined: return typeof(HammerOutlined);
            case GravityIconKind.HandOutlined: return typeof(HandOutlined);
            case GravityIconKind.HandOkOutlined: return typeof(HandOkOutlined);
            case GravityIconKind.HandPointDownOutlined: return typeof(HandPointDownOutlined);
            case GravityIconKind.HandPointLeftOutlined: return typeof(HandPointLeftOutlined);
            case GravityIconKind.HandPointRightOutlined: return typeof(HandPointRightOutlined);
            case GravityIconKind.HandPointUpOutlined: return typeof(HandPointUpOutlined);
            case GravityIconKind.HandStopOutlined: return typeof(HandStopOutlined);
            case GravityIconKind.HandsetOutlined: return typeof(HandsetOutlined);
            case GravityIconKind.HandsetArrowInOutlined: return typeof(HandsetArrowInOutlined);
            case GravityIconKind.HandsetArrowOutOutlined: return typeof(HandsetArrowOutOutlined);
            case GravityIconKind.HardDriveOutlined: return typeof(HardDriveOutlined);
            case GravityIconKind.HashtagOutlined: return typeof(HashtagOutlined);
            case GravityIconKind.HeadingOutlined: return typeof(HeadingOutlined);
            case GravityIconKind.Heading1Outlined: return typeof(Heading1Outlined);
            case GravityIconKind.Heading2Outlined: return typeof(Heading2Outlined);
            case GravityIconKind.Heading3Outlined: return typeof(Heading3Outlined);
            case GravityIconKind.Heading4Outlined: return typeof(Heading4Outlined);
            case GravityIconKind.Heading5Outlined: return typeof(Heading5Outlined);
            case GravityIconKind.Heading6Outlined: return typeof(Heading6Outlined);
            case GravityIconKind.HeadphonesOutlined: return typeof(HeadphonesOutlined);
            case GravityIconKind.HeartOutlined: return typeof(HeartOutlined);
            case GravityIconKind.HeartFilled: return typeof(HeartFilled);
            case GravityIconKind.HeartCrackOutlined: return typeof(HeartCrackOutlined);
            case GravityIconKind.HeartPulseOutlined: return typeof(HeartPulseOutlined);
            case GravityIconKind.HierarchyOutlined: return typeof(HierarchyOutlined);
            case GravityIconKind.HourglassOutlined: return typeof(HourglassOutlined);
            case GravityIconKind.HourglassEndOutlined: return typeof(HourglassEndOutlined);
            case GravityIconKind.HourglassStartOutlined: return typeof(HourglassStartOutlined);
            case GravityIconKind.HouseOutlined: return typeof(HouseOutlined);
            case GravityIconKind.HouseFilled: return typeof(HouseFilled);
            case GravityIconKind.IncognitoOutlined: return typeof(IncognitoOutlined);
            case GravityIconKind.ItalicOutlined: return typeof(ItalicOutlined);
            case GravityIconKind.KeyOutlined: return typeof(KeyOutlined);
            case GravityIconKind.KeyboardOutlined: return typeof(KeyboardOutlined);
            case GravityIconKind.LayersOutlined: return typeof(LayersOutlined);
            case GravityIconKind.Layers3DiagonalOutlined: return typeof(Layers3DiagonalOutlined);
            case GravityIconKind.LayersVerticalOutlined: return typeof(LayersVerticalOutlined);
            case GravityIconKind.LayoutCellsOutlined: return typeof(LayoutCellsOutlined);
            case GravityIconKind.LayoutCellsLargeOutlined: return typeof(LayoutCellsLargeOutlined);
            case GravityIconKind.LayoutColumnsOutlined: return typeof(LayoutColumnsOutlined);
            case GravityIconKind.LayoutColumns3Outlined: return typeof(LayoutColumns3Outlined);
            case GravityIconKind.LayoutFooterOutlined: return typeof(LayoutFooterOutlined);
            case GravityIconKind.LayoutHeaderOutlined: return typeof(LayoutHeaderOutlined);
            case GravityIconKind.LayoutHeaderCellsOutlined: return typeof(LayoutHeaderCellsOutlined);
            case GravityIconKind.LayoutHeaderCellsLargeOutlined: return typeof(LayoutHeaderCellsLargeOutlined);
            case GravityIconKind.LayoutHeaderCellsLargeFilled: return typeof(LayoutHeaderCellsLargeFilled);
            case GravityIconKind.LayoutHeaderCellsLargeLetterDOutlined: return typeof(LayoutHeaderCellsLargeLetterDOutlined);
            case GravityIconKind.LayoutHeaderCellsLargeThunderboltOutlined: return typeof(LayoutHeaderCellsLargeThunderboltOutlined);
            case GravityIconKind.LayoutHeaderColumnsOutlined: return typeof(LayoutHeaderColumnsOutlined);
            case GravityIconKind.LayoutHeaderCursorOutlined: return typeof(LayoutHeaderCursorOutlined);
            case GravityIconKind.LayoutHeaderSideContentOutlined: return typeof(LayoutHeaderSideContentOutlined);
            case GravityIconKind.LayoutListOutlined: return typeof(LayoutListOutlined);
            case GravityIconKind.LayoutRowsOutlined: return typeof(LayoutRowsOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk7(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.GeoPinOutlined => new GeoPinOutlined(),
            GravityIconKind.GeoPolygonsOutlined => new GeoPolygonsOutlined(),
            GravityIconKind.GhostOutlined => new GhostOutlined(),
            GravityIconKind.GiftOutlined => new GiftOutlined(),
            GravityIconKind.GlobeOutlined => new GlobeOutlined(),
            GravityIconKind.GpuOutlined => new GpuOutlined(),
            GravityIconKind.GraduationCapOutlined => new GraduationCapOutlined(),
            GravityIconKind.GraphNodeOutlined => new GraphNodeOutlined(),
            GravityIconKind.GripOutlined => new GripOutlined(),
            GravityIconKind.GripHorizontalOutlined => new GripHorizontalOutlined(),
            GravityIconKind.HammerOutlined => new HammerOutlined(),
            GravityIconKind.HandOutlined => new HandOutlined(),
            GravityIconKind.HandOkOutlined => new HandOkOutlined(),
            GravityIconKind.HandPointDownOutlined => new HandPointDownOutlined(),
            GravityIconKind.HandPointLeftOutlined => new HandPointLeftOutlined(),
            GravityIconKind.HandPointRightOutlined => new HandPointRightOutlined(),
            GravityIconKind.HandPointUpOutlined => new HandPointUpOutlined(),
            GravityIconKind.HandStopOutlined => new HandStopOutlined(),
            GravityIconKind.HandsetOutlined => new HandsetOutlined(),
            GravityIconKind.HandsetArrowInOutlined => new HandsetArrowInOutlined(),
            GravityIconKind.HandsetArrowOutOutlined => new HandsetArrowOutOutlined(),
            GravityIconKind.HardDriveOutlined => new HardDriveOutlined(),
            GravityIconKind.HashtagOutlined => new HashtagOutlined(),
            GravityIconKind.HeadingOutlined => new HeadingOutlined(),
            GravityIconKind.Heading1Outlined => new Heading1Outlined(),
            GravityIconKind.Heading2Outlined => new Heading2Outlined(),
            GravityIconKind.Heading3Outlined => new Heading3Outlined(),
            GravityIconKind.Heading4Outlined => new Heading4Outlined(),
            GravityIconKind.Heading5Outlined => new Heading5Outlined(),
            GravityIconKind.Heading6Outlined => new Heading6Outlined(),
            GravityIconKind.HeadphonesOutlined => new HeadphonesOutlined(),
            GravityIconKind.HeartOutlined => new HeartOutlined(),
            GravityIconKind.HeartFilled => new HeartFilled(),
            GravityIconKind.HeartCrackOutlined => new HeartCrackOutlined(),
            GravityIconKind.HeartPulseOutlined => new HeartPulseOutlined(),
            GravityIconKind.HierarchyOutlined => new HierarchyOutlined(),
            GravityIconKind.HourglassOutlined => new HourglassOutlined(),
            GravityIconKind.HourglassEndOutlined => new HourglassEndOutlined(),
            GravityIconKind.HourglassStartOutlined => new HourglassStartOutlined(),
            GravityIconKind.HouseOutlined => new HouseOutlined(),
            GravityIconKind.HouseFilled => new HouseFilled(),
            GravityIconKind.IncognitoOutlined => new IncognitoOutlined(),
            GravityIconKind.ItalicOutlined => new ItalicOutlined(),
            GravityIconKind.KeyOutlined => new KeyOutlined(),
            GravityIconKind.KeyboardOutlined => new KeyboardOutlined(),
            GravityIconKind.LayersOutlined => new LayersOutlined(),
            GravityIconKind.Layers3DiagonalOutlined => new Layers3DiagonalOutlined(),
            GravityIconKind.LayersVerticalOutlined => new LayersVerticalOutlined(),
            GravityIconKind.LayoutCellsOutlined => new LayoutCellsOutlined(),
            GravityIconKind.LayoutCellsLargeOutlined => new LayoutCellsLargeOutlined(),
            GravityIconKind.LayoutColumnsOutlined => new LayoutColumnsOutlined(),
            GravityIconKind.LayoutColumns3Outlined => new LayoutColumns3Outlined(),
            GravityIconKind.LayoutFooterOutlined => new LayoutFooterOutlined(),
            GravityIconKind.LayoutHeaderOutlined => new LayoutHeaderOutlined(),
            GravityIconKind.LayoutHeaderCellsOutlined => new LayoutHeaderCellsOutlined(),
            GravityIconKind.LayoutHeaderCellsLargeOutlined => new LayoutHeaderCellsLargeOutlined(),
            GravityIconKind.LayoutHeaderCellsLargeFilled => new LayoutHeaderCellsLargeFilled(),
            GravityIconKind.LayoutHeaderCellsLargeLetterDOutlined => new LayoutHeaderCellsLargeLetterDOutlined(),
            GravityIconKind.LayoutHeaderCellsLargeThunderboltOutlined => new LayoutHeaderCellsLargeThunderboltOutlined(),
            GravityIconKind.LayoutHeaderColumnsOutlined => new LayoutHeaderColumnsOutlined(),
            GravityIconKind.LayoutHeaderCursorOutlined => new LayoutHeaderCursorOutlined(),
            GravityIconKind.LayoutHeaderSideContentOutlined => new LayoutHeaderSideContentOutlined(),
            GravityIconKind.LayoutListOutlined => new LayoutListOutlined(),
            GravityIconKind.LayoutRowsOutlined => new LayoutRowsOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk8(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.LayoutRows3Outlined: return typeof(LayoutRows3Outlined);
            case GravityIconKind.LayoutSideContentOutlined: return typeof(LayoutSideContentOutlined);
            case GravityIconKind.LayoutSideContentLeftOutlined: return typeof(LayoutSideContentLeftOutlined);
            case GravityIconKind.LayoutSideContentRightOutlined: return typeof(LayoutSideContentRightOutlined);
            case GravityIconKind.LayoutSplitColumnsOutlined: return typeof(LayoutSplitColumnsOutlined);
            case GravityIconKind.LayoutSplitColumns3Outlined: return typeof(LayoutSplitColumns3Outlined);
            case GravityIconKind.LayoutSplitRowsOutlined: return typeof(LayoutSplitRowsOutlined);
            case GravityIconKind.LayoutSplitSideContentLeftOutlined: return typeof(LayoutSplitSideContentLeftOutlined);
            case GravityIconKind.LayoutSplitSideContentRightOutlined: return typeof(LayoutSplitSideContentRightOutlined);
            case GravityIconKind.LayoutTabsOutlined: return typeof(LayoutTabsOutlined);
            case GravityIconKind.LetterAUnderlineOutlined: return typeof(LetterAUnderlineOutlined);
            case GravityIconKind.LetterGroupOutlined: return typeof(LetterGroupOutlined);
            case GravityIconKind.LetterMOutlined: return typeof(LetterMOutlined);
            case GravityIconKind.LifeRingOutlined: return typeof(LifeRingOutlined);
            case GravityIconKind.LinkOutlined: return typeof(LinkOutlined);
            case GravityIconKind.LinkSlashOutlined: return typeof(LinkSlashOutlined);
            case GravityIconKind.ListCheckOutlined: return typeof(ListCheckOutlined);
            case GravityIconKind.ListCheckLockOutlined: return typeof(ListCheckLockOutlined);
            case GravityIconKind.ListOlOutlined: return typeof(ListOlOutlined);
            case GravityIconKind.ListTimelineOutlined: return typeof(ListTimelineOutlined);
            case GravityIconKind.ListUlOutlined: return typeof(ListUlOutlined);
            case GravityIconKind.LocationArrowOutlined: return typeof(LocationArrowOutlined);
            case GravityIconKind.LocationArrowFilled: return typeof(LocationArrowFilled);
            case GravityIconKind.LockOutlined: return typeof(LockOutlined);
            case GravityIconKind.LockFilled: return typeof(LockFilled);
            case GravityIconKind.LockOpenOutlined: return typeof(LockOpenOutlined);
            case GravityIconKind.LockOpenFilled: return typeof(LockOpenFilled);
            case GravityIconKind.LogoAcrobatOutlined: return typeof(LogoAcrobatOutlined);
            case GravityIconKind.LogoAndroidOutlined: return typeof(LogoAndroidOutlined);
            case GravityIconKind.LogoAppStoreOutlined: return typeof(LogoAppStoreOutlined);
            case GravityIconKind.LogoAppleOutlined: return typeof(LogoAppleOutlined);
            case GravityIconKind.LogoDebianOutlined: return typeof(LogoDebianOutlined);
            case GravityIconKind.LogoDockerOutlined: return typeof(LogoDockerOutlined);
            case GravityIconKind.LogoDrawIoOutlined: return typeof(LogoDrawIoOutlined);
            case GravityIconKind.LogoFacebookOutlined: return typeof(LogoFacebookOutlined);
            case GravityIconKind.LogoFigmaOutlined: return typeof(LogoFigmaOutlined);
            case GravityIconKind.LogoGithubOutlined: return typeof(LogoGithubOutlined);
            case GravityIconKind.LogoGitlabOutlined: return typeof(LogoGitlabOutlined);
            case GravityIconKind.LogoGooglePlayOutlined: return typeof(LogoGooglePlayOutlined);
            case GravityIconKind.LogoHuaweiAppgalleryOutlined: return typeof(LogoHuaweiAppgalleryOutlined);
            case GravityIconKind.LogoLinkedinOutlined: return typeof(LogoLinkedinOutlined);
            case GravityIconKind.LogoLinuxOutlined: return typeof(LogoLinuxOutlined);
            case GravityIconKind.LogoMacosOutlined: return typeof(LogoMacosOutlined);
            case GravityIconKind.LogoMarkdownOutlined: return typeof(LogoMarkdownOutlined);
            case GravityIconKind.LogoMcpOutlined: return typeof(LogoMcpOutlined);
            case GravityIconKind.LogoMermaidOutlined: return typeof(LogoMermaidOutlined);
            case GravityIconKind.LogoMicrosoftOfficeOutlined: return typeof(LogoMicrosoftOfficeOutlined);
            case GravityIconKind.LogoNodejsOutlined: return typeof(LogoNodejsOutlined);
            case GravityIconKind.LogoNotionOutlined: return typeof(LogoNotionOutlined);
            case GravityIconKind.LogoOsiOutlined: return typeof(LogoOsiOutlined);
            case GravityIconKind.LogoPythonOutlined: return typeof(LogoPythonOutlined);
            case GravityIconKind.LogoRustoreOutlined: return typeof(LogoRustoreOutlined);
            case GravityIconKind.LogoSlackOutlined: return typeof(LogoSlackOutlined);
            case GravityIconKind.LogoStackOverflowOutlined: return typeof(LogoStackOverflowOutlined);
            case GravityIconKind.LogoTelegramOutlined: return typeof(LogoTelegramOutlined);
            case GravityIconKind.LogoUbuntuOutlined: return typeof(LogoUbuntuOutlined);
            case GravityIconKind.LogoWebhookOutlined: return typeof(LogoWebhookOutlined);
            case GravityIconKind.LogoWindowsOutlined: return typeof(LogoWindowsOutlined);
            case GravityIconKind.LogoYandexOutlined: return typeof(LogoYandexOutlined);
            case GravityIconKind.LogoYandexAiStudioOutlined: return typeof(LogoYandexAiStudioOutlined);
            case GravityIconKind.LogoYandexCloudOutlined: return typeof(LogoYandexCloudOutlined);
            case GravityIconKind.LogoYandexIdOutlined: return typeof(LogoYandexIdOutlined);
            case GravityIconKind.LogoYandexMessengerOutlined: return typeof(LogoYandexMessengerOutlined);
            case GravityIconKind.LogoYandexTrackerOutlined: return typeof(LogoYandexTrackerOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk8(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.LayoutRows3Outlined => new LayoutRows3Outlined(),
            GravityIconKind.LayoutSideContentOutlined => new LayoutSideContentOutlined(),
            GravityIconKind.LayoutSideContentLeftOutlined => new LayoutSideContentLeftOutlined(),
            GravityIconKind.LayoutSideContentRightOutlined => new LayoutSideContentRightOutlined(),
            GravityIconKind.LayoutSplitColumnsOutlined => new LayoutSplitColumnsOutlined(),
            GravityIconKind.LayoutSplitColumns3Outlined => new LayoutSplitColumns3Outlined(),
            GravityIconKind.LayoutSplitRowsOutlined => new LayoutSplitRowsOutlined(),
            GravityIconKind.LayoutSplitSideContentLeftOutlined => new LayoutSplitSideContentLeftOutlined(),
            GravityIconKind.LayoutSplitSideContentRightOutlined => new LayoutSplitSideContentRightOutlined(),
            GravityIconKind.LayoutTabsOutlined => new LayoutTabsOutlined(),
            GravityIconKind.LetterAUnderlineOutlined => new LetterAUnderlineOutlined(),
            GravityIconKind.LetterGroupOutlined => new LetterGroupOutlined(),
            GravityIconKind.LetterMOutlined => new LetterMOutlined(),
            GravityIconKind.LifeRingOutlined => new LifeRingOutlined(),
            GravityIconKind.LinkOutlined => new LinkOutlined(),
            GravityIconKind.LinkSlashOutlined => new LinkSlashOutlined(),
            GravityIconKind.ListCheckOutlined => new ListCheckOutlined(),
            GravityIconKind.ListCheckLockOutlined => new ListCheckLockOutlined(),
            GravityIconKind.ListOlOutlined => new ListOlOutlined(),
            GravityIconKind.ListTimelineOutlined => new ListTimelineOutlined(),
            GravityIconKind.ListUlOutlined => new ListUlOutlined(),
            GravityIconKind.LocationArrowOutlined => new LocationArrowOutlined(),
            GravityIconKind.LocationArrowFilled => new LocationArrowFilled(),
            GravityIconKind.LockOutlined => new LockOutlined(),
            GravityIconKind.LockFilled => new LockFilled(),
            GravityIconKind.LockOpenOutlined => new LockOpenOutlined(),
            GravityIconKind.LockOpenFilled => new LockOpenFilled(),
            GravityIconKind.LogoAcrobatOutlined => new LogoAcrobatOutlined(),
            GravityIconKind.LogoAndroidOutlined => new LogoAndroidOutlined(),
            GravityIconKind.LogoAppStoreOutlined => new LogoAppStoreOutlined(),
            GravityIconKind.LogoAppleOutlined => new LogoAppleOutlined(),
            GravityIconKind.LogoDebianOutlined => new LogoDebianOutlined(),
            GravityIconKind.LogoDockerOutlined => new LogoDockerOutlined(),
            GravityIconKind.LogoDrawIoOutlined => new LogoDrawIoOutlined(),
            GravityIconKind.LogoFacebookOutlined => new LogoFacebookOutlined(),
            GravityIconKind.LogoFigmaOutlined => new LogoFigmaOutlined(),
            GravityIconKind.LogoGithubOutlined => new LogoGithubOutlined(),
            GravityIconKind.LogoGitlabOutlined => new LogoGitlabOutlined(),
            GravityIconKind.LogoGooglePlayOutlined => new LogoGooglePlayOutlined(),
            GravityIconKind.LogoHuaweiAppgalleryOutlined => new LogoHuaweiAppgalleryOutlined(),
            GravityIconKind.LogoLinkedinOutlined => new LogoLinkedinOutlined(),
            GravityIconKind.LogoLinuxOutlined => new LogoLinuxOutlined(),
            GravityIconKind.LogoMacosOutlined => new LogoMacosOutlined(),
            GravityIconKind.LogoMarkdownOutlined => new LogoMarkdownOutlined(),
            GravityIconKind.LogoMcpOutlined => new LogoMcpOutlined(),
            GravityIconKind.LogoMermaidOutlined => new LogoMermaidOutlined(),
            GravityIconKind.LogoMicrosoftOfficeOutlined => new LogoMicrosoftOfficeOutlined(),
            GravityIconKind.LogoNodejsOutlined => new LogoNodejsOutlined(),
            GravityIconKind.LogoNotionOutlined => new LogoNotionOutlined(),
            GravityIconKind.LogoOsiOutlined => new LogoOsiOutlined(),
            GravityIconKind.LogoPythonOutlined => new LogoPythonOutlined(),
            GravityIconKind.LogoRustoreOutlined => new LogoRustoreOutlined(),
            GravityIconKind.LogoSlackOutlined => new LogoSlackOutlined(),
            GravityIconKind.LogoStackOverflowOutlined => new LogoStackOverflowOutlined(),
            GravityIconKind.LogoTelegramOutlined => new LogoTelegramOutlined(),
            GravityIconKind.LogoUbuntuOutlined => new LogoUbuntuOutlined(),
            GravityIconKind.LogoWebhookOutlined => new LogoWebhookOutlined(),
            GravityIconKind.LogoWindowsOutlined => new LogoWindowsOutlined(),
            GravityIconKind.LogoYandexOutlined => new LogoYandexOutlined(),
            GravityIconKind.LogoYandexAiStudioOutlined => new LogoYandexAiStudioOutlined(),
            GravityIconKind.LogoYandexCloudOutlined => new LogoYandexCloudOutlined(),
            GravityIconKind.LogoYandexIdOutlined => new LogoYandexIdOutlined(),
            GravityIconKind.LogoYandexMessengerOutlined => new LogoYandexMessengerOutlined(),
            GravityIconKind.LogoYandexTrackerOutlined => new LogoYandexTrackerOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk9(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.MagicWandOutlined: return typeof(MagicWandOutlined);
            case GravityIconKind.MagnetOutlined: return typeof(MagnetOutlined);
            case GravityIconKind.MagnifierOutlined: return typeof(MagnifierOutlined);
            case GravityIconKind.MagnifierMinusOutlined: return typeof(MagnifierMinusOutlined);
            case GravityIconKind.MagnifierPlusOutlined: return typeof(MagnifierPlusOutlined);
            case GravityIconKind.MapPinOutlined: return typeof(MapPinOutlined);
            case GravityIconKind.MapPinMinusOutlined: return typeof(MapPinMinusOutlined);
            case GravityIconKind.MapPinPlusOutlined: return typeof(MapPinPlusOutlined);
            case GravityIconKind.MathIntersectionShapeOutlined: return typeof(MathIntersectionShapeOutlined);
            case GravityIconKind.MathOperationsOutlined: return typeof(MathOperationsOutlined);
            case GravityIconKind.MathUnionShapeOutlined: return typeof(MathUnionShapeOutlined);
            case GravityIconKind.MedalOutlined: return typeof(MedalOutlined);
            case GravityIconKind.MegaphoneOutlined: return typeof(MegaphoneOutlined);
            case GravityIconKind.MicrophoneOutlined: return typeof(MicrophoneOutlined);
            case GravityIconKind.MicrophoneSlashOutlined: return typeof(MicrophoneSlashOutlined);
            case GravityIconKind.MicroscopeOutlined: return typeof(MicroscopeOutlined);
            case GravityIconKind.MinusOutlined: return typeof(MinusOutlined);
            case GravityIconKind.MinusShapeOutlined: return typeof(MinusShapeOutlined);
            case GravityIconKind.MinusShapeFilled: return typeof(MinusShapeFilled);
            case GravityIconKind.MoleculeOutlined: return typeof(MoleculeOutlined);
            case GravityIconKind.MoonOutlined: return typeof(MoonOutlined);
            case GravityIconKind.MugOutlined: return typeof(MugOutlined);
            case GravityIconKind.MusicNoteOutlined: return typeof(MusicNoteOutlined);
            case GravityIconKind.NodesDownOutlined: return typeof(NodesDownOutlined);
            case GravityIconKind.NodesLeftOutlined: return typeof(NodesLeftOutlined);
            case GravityIconKind.NodesRightOutlined: return typeof(NodesRightOutlined);
            case GravityIconKind.NodesUpOutlined: return typeof(NodesUpOutlined);
            case GravityIconKind.NutHexOutlined: return typeof(NutHexOutlined);
            case GravityIconKind.ObjectAlignBottomOutlined: return typeof(ObjectAlignBottomOutlined);
            case GravityIconKind.ObjectAlignCenterHorizontalOutlined: return typeof(ObjectAlignCenterHorizontalOutlined);
            case GravityIconKind.ObjectAlignCenterVerticalOutlined: return typeof(ObjectAlignCenterVerticalOutlined);
            case GravityIconKind.ObjectAlignJustifyHorizontalOutlined: return typeof(ObjectAlignJustifyHorizontalOutlined);
            case GravityIconKind.ObjectAlignJustifyVerticalOutlined: return typeof(ObjectAlignJustifyVerticalOutlined);
            case GravityIconKind.ObjectAlignLeftOutlined: return typeof(ObjectAlignLeftOutlined);
            case GravityIconKind.ObjectAlignRightOutlined: return typeof(ObjectAlignRightOutlined);
            case GravityIconKind.ObjectAlignTopOutlined: return typeof(ObjectAlignTopOutlined);
            case GravityIconKind.ObjectsAlignBottomOutlined: return typeof(ObjectsAlignBottomOutlined);
            case GravityIconKind.ObjectsAlignCenterHorizontalOutlined: return typeof(ObjectsAlignCenterHorizontalOutlined);
            case GravityIconKind.ObjectsAlignCenterVerticalOutlined: return typeof(ObjectsAlignCenterVerticalOutlined);
            case GravityIconKind.ObjectsAlignJustifyHorizontalOutlined: return typeof(ObjectsAlignJustifyHorizontalOutlined);
            case GravityIconKind.ObjectsAlignJustifyVerticalOutlined: return typeof(ObjectsAlignJustifyVerticalOutlined);
            case GravityIconKind.ObjectsAlignLeftOutlined: return typeof(ObjectsAlignLeftOutlined);
            case GravityIconKind.ObjectsAlignRightOutlined: return typeof(ObjectsAlignRightOutlined);
            case GravityIconKind.ObjectsAlignTopOutlined: return typeof(ObjectsAlignTopOutlined);
            case GravityIconKind.OctagonXmarkOutlined: return typeof(OctagonXmarkOutlined);
            case GravityIconKind.OfficeBadgeOutlined: return typeof(OfficeBadgeOutlined);
            case GravityIconKind.PaintbrushOutlined: return typeof(PaintbrushOutlined);
            case GravityIconKind.PaletteOutlined: return typeof(PaletteOutlined);
            case GravityIconKind.PaperPlaneOutlined: return typeof(PaperPlaneOutlined);
            case GravityIconKind.PaperclipOutlined: return typeof(PaperclipOutlined);
            case GravityIconKind.PassportOutlined: return typeof(PassportOutlined);
            case GravityIconKind.PauseOutlined: return typeof(PauseOutlined);
            case GravityIconKind.PauseFilled: return typeof(PauseFilled);
            case GravityIconKind.PencilOutlined: return typeof(PencilOutlined);
            case GravityIconKind.PencilToLineOutlined: return typeof(PencilToLineOutlined);
            case GravityIconKind.PencilToSquareOutlined: return typeof(PencilToSquareOutlined);
            case GravityIconKind.PercentOutlined: return typeof(PercentOutlined);
            case GravityIconKind.PersonOutlined: return typeof(PersonOutlined);
            case GravityIconKind.PersonFilled: return typeof(PersonFilled);
            case GravityIconKind.PersonGearOutlined: return typeof(PersonGearOutlined);
            case GravityIconKind.PersonMagnifierOutlined: return typeof(PersonMagnifierOutlined);
            case GravityIconKind.PersonNutHexOutlined: return typeof(PersonNutHexOutlined);
            case GravityIconKind.PersonPencilOutlined: return typeof(PersonPencilOutlined);
            case GravityIconKind.PersonPlanetEarthOutlined: return typeof(PersonPlanetEarthOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk9(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.MagicWandOutlined => new MagicWandOutlined(),
            GravityIconKind.MagnetOutlined => new MagnetOutlined(),
            GravityIconKind.MagnifierOutlined => new MagnifierOutlined(),
            GravityIconKind.MagnifierMinusOutlined => new MagnifierMinusOutlined(),
            GravityIconKind.MagnifierPlusOutlined => new MagnifierPlusOutlined(),
            GravityIconKind.MapPinOutlined => new MapPinOutlined(),
            GravityIconKind.MapPinMinusOutlined => new MapPinMinusOutlined(),
            GravityIconKind.MapPinPlusOutlined => new MapPinPlusOutlined(),
            GravityIconKind.MathIntersectionShapeOutlined => new MathIntersectionShapeOutlined(),
            GravityIconKind.MathOperationsOutlined => new MathOperationsOutlined(),
            GravityIconKind.MathUnionShapeOutlined => new MathUnionShapeOutlined(),
            GravityIconKind.MedalOutlined => new MedalOutlined(),
            GravityIconKind.MegaphoneOutlined => new MegaphoneOutlined(),
            GravityIconKind.MicrophoneOutlined => new MicrophoneOutlined(),
            GravityIconKind.MicrophoneSlashOutlined => new MicrophoneSlashOutlined(),
            GravityIconKind.MicroscopeOutlined => new MicroscopeOutlined(),
            GravityIconKind.MinusOutlined => new MinusOutlined(),
            GravityIconKind.MinusShapeOutlined => new MinusShapeOutlined(),
            GravityIconKind.MinusShapeFilled => new MinusShapeFilled(),
            GravityIconKind.MoleculeOutlined => new MoleculeOutlined(),
            GravityIconKind.MoonOutlined => new MoonOutlined(),
            GravityIconKind.MugOutlined => new MugOutlined(),
            GravityIconKind.MusicNoteOutlined => new MusicNoteOutlined(),
            GravityIconKind.NodesDownOutlined => new NodesDownOutlined(),
            GravityIconKind.NodesLeftOutlined => new NodesLeftOutlined(),
            GravityIconKind.NodesRightOutlined => new NodesRightOutlined(),
            GravityIconKind.NodesUpOutlined => new NodesUpOutlined(),
            GravityIconKind.NutHexOutlined => new NutHexOutlined(),
            GravityIconKind.ObjectAlignBottomOutlined => new ObjectAlignBottomOutlined(),
            GravityIconKind.ObjectAlignCenterHorizontalOutlined => new ObjectAlignCenterHorizontalOutlined(),
            GravityIconKind.ObjectAlignCenterVerticalOutlined => new ObjectAlignCenterVerticalOutlined(),
            GravityIconKind.ObjectAlignJustifyHorizontalOutlined => new ObjectAlignJustifyHorizontalOutlined(),
            GravityIconKind.ObjectAlignJustifyVerticalOutlined => new ObjectAlignJustifyVerticalOutlined(),
            GravityIconKind.ObjectAlignLeftOutlined => new ObjectAlignLeftOutlined(),
            GravityIconKind.ObjectAlignRightOutlined => new ObjectAlignRightOutlined(),
            GravityIconKind.ObjectAlignTopOutlined => new ObjectAlignTopOutlined(),
            GravityIconKind.ObjectsAlignBottomOutlined => new ObjectsAlignBottomOutlined(),
            GravityIconKind.ObjectsAlignCenterHorizontalOutlined => new ObjectsAlignCenterHorizontalOutlined(),
            GravityIconKind.ObjectsAlignCenterVerticalOutlined => new ObjectsAlignCenterVerticalOutlined(),
            GravityIconKind.ObjectsAlignJustifyHorizontalOutlined => new ObjectsAlignJustifyHorizontalOutlined(),
            GravityIconKind.ObjectsAlignJustifyVerticalOutlined => new ObjectsAlignJustifyVerticalOutlined(),
            GravityIconKind.ObjectsAlignLeftOutlined => new ObjectsAlignLeftOutlined(),
            GravityIconKind.ObjectsAlignRightOutlined => new ObjectsAlignRightOutlined(),
            GravityIconKind.ObjectsAlignTopOutlined => new ObjectsAlignTopOutlined(),
            GravityIconKind.OctagonXmarkOutlined => new OctagonXmarkOutlined(),
            GravityIconKind.OfficeBadgeOutlined => new OfficeBadgeOutlined(),
            GravityIconKind.PaintbrushOutlined => new PaintbrushOutlined(),
            GravityIconKind.PaletteOutlined => new PaletteOutlined(),
            GravityIconKind.PaperPlaneOutlined => new PaperPlaneOutlined(),
            GravityIconKind.PaperclipOutlined => new PaperclipOutlined(),
            GravityIconKind.PassportOutlined => new PassportOutlined(),
            GravityIconKind.PauseOutlined => new PauseOutlined(),
            GravityIconKind.PauseFilled => new PauseFilled(),
            GravityIconKind.PencilOutlined => new PencilOutlined(),
            GravityIconKind.PencilToLineOutlined => new PencilToLineOutlined(),
            GravityIconKind.PencilToSquareOutlined => new PencilToSquareOutlined(),
            GravityIconKind.PercentOutlined => new PercentOutlined(),
            GravityIconKind.PersonOutlined => new PersonOutlined(),
            GravityIconKind.PersonFilled => new PersonFilled(),
            GravityIconKind.PersonGearOutlined => new PersonGearOutlined(),
            GravityIconKind.PersonMagnifierOutlined => new PersonMagnifierOutlined(),
            GravityIconKind.PersonNutHexOutlined => new PersonNutHexOutlined(),
            GravityIconKind.PersonPencilOutlined => new PersonPencilOutlined(),
            GravityIconKind.PersonPlanetEarthOutlined => new PersonPlanetEarthOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk10(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.PersonPlusOutlined: return typeof(PersonPlusOutlined);
            case GravityIconKind.PersonSpeakerOutlined: return typeof(PersonSpeakerOutlined);
            case GravityIconKind.PersonWorkerOutlined: return typeof(PersonWorkerOutlined);
            case GravityIconKind.PersonXmarkOutlined: return typeof(PersonXmarkOutlined);
            case GravityIconKind.PersonsOutlined: return typeof(PersonsOutlined);
            case GravityIconKind.PersonsLockOutlined: return typeof(PersonsLockOutlined);
            case GravityIconKind.PictureOutlined: return typeof(PictureOutlined);
            case GravityIconKind.PillOutlined: return typeof(PillOutlined);
            case GravityIconKind.PinOutlined: return typeof(PinOutlined);
            case GravityIconKind.PinFilled: return typeof(PinFilled);
            case GravityIconKind.PinSlashOutlined: return typeof(PinSlashOutlined);
            case GravityIconKind.PinSlashFilled: return typeof(PinSlashFilled);
            case GravityIconKind.PipelineOutlined: return typeof(PipelineOutlined);
            case GravityIconKind.PlaneOutlined: return typeof(PlaneOutlined);
            case GravityIconKind.PlaneFilled: return typeof(PlaneFilled);
            case GravityIconKind.PlanetEarthOutlined: return typeof(PlanetEarthOutlined);
            case GravityIconKind.PlayOutlined: return typeof(PlayOutlined);
            case GravityIconKind.PlayFilled: return typeof(PlayFilled);
            case GravityIconKind.PlugConnectionOutlined: return typeof(PlugConnectionOutlined);
            case GravityIconKind.PlugWireOutlined: return typeof(PlugWireOutlined);
            case GravityIconKind.PlusOutlined: return typeof(PlusOutlined);
            case GravityIconKind.PlusShapeOutlined: return typeof(PlusShapeOutlined);
            case GravityIconKind.PlusShapeFilled: return typeof(PlusShapeFilled);
            case GravityIconKind.PowerOutlined: return typeof(PowerOutlined);
            case GravityIconKind.PrinterOutlined: return typeof(PrinterOutlined);
            case GravityIconKind.PulseOutlined: return typeof(PulseOutlined);
            case GravityIconKind.PuzzleOutlined: return typeof(PuzzleOutlined);
            case GravityIconKind.QrCodeOutlined: return typeof(QrCodeOutlined);
            case GravityIconKind.QuoteCloseOutlined: return typeof(QuoteCloseOutlined);
            case GravityIconKind.QuoteOpenOutlined: return typeof(QuoteOpenOutlined);
            case GravityIconKind.ReceiptOutlined: return typeof(ReceiptOutlined);
            case GravityIconKind.RectanglePulseOutlined: return typeof(RectanglePulseOutlined);
            case GravityIconKind.Rectangles4Outlined: return typeof(Rectangles4Outlined);
            case GravityIconKind.RocketOutlined: return typeof(RocketOutlined);
            case GravityIconKind.RoundBracketsOutlined: return typeof(RoundBracketsOutlined);
            case GravityIconKind.RouteOutlined: return typeof(RouteOutlined);
            case GravityIconKind.SackOutlined: return typeof(SackOutlined);
            case GravityIconKind.ScalesBalancedOutlined: return typeof(ScalesBalancedOutlined);
            case GravityIconKind.ScalesUnbalancedOutlined: return typeof(ScalesUnbalancedOutlined);
            case GravityIconKind.ScissorsOutlined: return typeof(ScissorsOutlined);
            case GravityIconKind.SealCheckOutlined: return typeof(SealCheckOutlined);
            case GravityIconKind.SealPercentOutlined: return typeof(SealPercentOutlined);
            case GravityIconKind.ServerOutlined: return typeof(ServerOutlined);
            case GravityIconKind.ServerPlusOutlined: return typeof(ServerPlusOutlined);
            case GravityIconKind.Shapes3Outlined: return typeof(Shapes3Outlined);
            case GravityIconKind.Shapes4Outlined: return typeof(Shapes4Outlined);
            case GravityIconKind.ShieldOutlined: return typeof(ShieldOutlined);
            case GravityIconKind.ShieldCheckOutlined: return typeof(ShieldCheckOutlined);
            case GravityIconKind.ShieldExclamationOutlined: return typeof(ShieldExclamationOutlined);
            case GravityIconKind.ShieldKeyholeOutlined: return typeof(ShieldKeyholeOutlined);
            case GravityIconKind.ShoppingBagOutlined: return typeof(ShoppingBagOutlined);
            case GravityIconKind.ShoppingBasketOutlined: return typeof(ShoppingBasketOutlined);
            case GravityIconKind.ShoppingCartOutlined: return typeof(ShoppingCartOutlined);
            case GravityIconKind.ShuffleOutlined: return typeof(ShuffleOutlined);
            case GravityIconKind.SignalOutlined: return typeof(SignalOutlined);
            case GravityIconKind.SkullOutlined: return typeof(SkullOutlined);
            case GravityIconKind.SlidersOutlined: return typeof(SlidersOutlined);
            case GravityIconKind.SlidersVerticalOutlined: return typeof(SlidersVerticalOutlined);
            case GravityIconKind.SmartphoneOutlined: return typeof(SmartphoneOutlined);
            case GravityIconKind.SnailOutlined: return typeof(SnailOutlined);
            case GravityIconKind.SnowflakeOutlined: return typeof(SnowflakeOutlined);
            case GravityIconKind.SparklesOutlined: return typeof(SparklesOutlined);
            case GravityIconKind.SparklesFilled: return typeof(SparklesFilled);
            case GravityIconKind.SpeedometerOutlined: return typeof(SpeedometerOutlined);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk10(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.PersonPlusOutlined => new PersonPlusOutlined(),
            GravityIconKind.PersonSpeakerOutlined => new PersonSpeakerOutlined(),
            GravityIconKind.PersonWorkerOutlined => new PersonWorkerOutlined(),
            GravityIconKind.PersonXmarkOutlined => new PersonXmarkOutlined(),
            GravityIconKind.PersonsOutlined => new PersonsOutlined(),
            GravityIconKind.PersonsLockOutlined => new PersonsLockOutlined(),
            GravityIconKind.PictureOutlined => new PictureOutlined(),
            GravityIconKind.PillOutlined => new PillOutlined(),
            GravityIconKind.PinOutlined => new PinOutlined(),
            GravityIconKind.PinFilled => new PinFilled(),
            GravityIconKind.PinSlashOutlined => new PinSlashOutlined(),
            GravityIconKind.PinSlashFilled => new PinSlashFilled(),
            GravityIconKind.PipelineOutlined => new PipelineOutlined(),
            GravityIconKind.PlaneOutlined => new PlaneOutlined(),
            GravityIconKind.PlaneFilled => new PlaneFilled(),
            GravityIconKind.PlanetEarthOutlined => new PlanetEarthOutlined(),
            GravityIconKind.PlayOutlined => new PlayOutlined(),
            GravityIconKind.PlayFilled => new PlayFilled(),
            GravityIconKind.PlugConnectionOutlined => new PlugConnectionOutlined(),
            GravityIconKind.PlugWireOutlined => new PlugWireOutlined(),
            GravityIconKind.PlusOutlined => new PlusOutlined(),
            GravityIconKind.PlusShapeOutlined => new PlusShapeOutlined(),
            GravityIconKind.PlusShapeFilled => new PlusShapeFilled(),
            GravityIconKind.PowerOutlined => new PowerOutlined(),
            GravityIconKind.PrinterOutlined => new PrinterOutlined(),
            GravityIconKind.PulseOutlined => new PulseOutlined(),
            GravityIconKind.PuzzleOutlined => new PuzzleOutlined(),
            GravityIconKind.QrCodeOutlined => new QrCodeOutlined(),
            GravityIconKind.QuoteCloseOutlined => new QuoteCloseOutlined(),
            GravityIconKind.QuoteOpenOutlined => new QuoteOpenOutlined(),
            GravityIconKind.ReceiptOutlined => new ReceiptOutlined(),
            GravityIconKind.RectanglePulseOutlined => new RectanglePulseOutlined(),
            GravityIconKind.Rectangles4Outlined => new Rectangles4Outlined(),
            GravityIconKind.RocketOutlined => new RocketOutlined(),
            GravityIconKind.RoundBracketsOutlined => new RoundBracketsOutlined(),
            GravityIconKind.RouteOutlined => new RouteOutlined(),
            GravityIconKind.SackOutlined => new SackOutlined(),
            GravityIconKind.ScalesBalancedOutlined => new ScalesBalancedOutlined(),
            GravityIconKind.ScalesUnbalancedOutlined => new ScalesUnbalancedOutlined(),
            GravityIconKind.ScissorsOutlined => new ScissorsOutlined(),
            GravityIconKind.SealCheckOutlined => new SealCheckOutlined(),
            GravityIconKind.SealPercentOutlined => new SealPercentOutlined(),
            GravityIconKind.ServerOutlined => new ServerOutlined(),
            GravityIconKind.ServerPlusOutlined => new ServerPlusOutlined(),
            GravityIconKind.Shapes3Outlined => new Shapes3Outlined(),
            GravityIconKind.Shapes4Outlined => new Shapes4Outlined(),
            GravityIconKind.ShieldOutlined => new ShieldOutlined(),
            GravityIconKind.ShieldCheckOutlined => new ShieldCheckOutlined(),
            GravityIconKind.ShieldExclamationOutlined => new ShieldExclamationOutlined(),
            GravityIconKind.ShieldKeyholeOutlined => new ShieldKeyholeOutlined(),
            GravityIconKind.ShoppingBagOutlined => new ShoppingBagOutlined(),
            GravityIconKind.ShoppingBasketOutlined => new ShoppingBasketOutlined(),
            GravityIconKind.ShoppingCartOutlined => new ShoppingCartOutlined(),
            GravityIconKind.ShuffleOutlined => new ShuffleOutlined(),
            GravityIconKind.SignalOutlined => new SignalOutlined(),
            GravityIconKind.SkullOutlined => new SkullOutlined(),
            GravityIconKind.SlidersOutlined => new SlidersOutlined(),
            GravityIconKind.SlidersVerticalOutlined => new SlidersVerticalOutlined(),
            GravityIconKind.SmartphoneOutlined => new SmartphoneOutlined(),
            GravityIconKind.SnailOutlined => new SnailOutlined(),
            GravityIconKind.SnowflakeOutlined => new SnowflakeOutlined(),
            GravityIconKind.SparklesOutlined => new SparklesOutlined(),
            GravityIconKind.SparklesFilled => new SparklesFilled(),
            GravityIconKind.SpeedometerOutlined => new SpeedometerOutlined(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk11(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.SphereOutlined: return typeof(SphereOutlined);
            case GravityIconKind.SquareOutlined: return typeof(SquareOutlined);
            case GravityIconKind.SquareFilled: return typeof(SquareFilled);
            case GravityIconKind.SquareArticleOutlined: return typeof(SquareArticleOutlined);
            case GravityIconKind.SquareBarsOutlined: return typeof(SquareBarsOutlined);
            case GravityIconKind.SquareBarsVerticalOutlined: return typeof(SquareBarsVerticalOutlined);
            case GravityIconKind.SquareBracketsOutlined: return typeof(SquareBracketsOutlined);
            case GravityIconKind.SquareBracketsBarsVerticalOutlined: return typeof(SquareBracketsBarsVerticalOutlined);
            case GravityIconKind.SquareBracketsLetterAOutlined: return typeof(SquareBracketsLetterAOutlined);
            case GravityIconKind.SquareChartBarOutlined: return typeof(SquareChartBarOutlined);
            case GravityIconKind.SquareChartColumnOutlined: return typeof(SquareChartColumnOutlined);
            case GravityIconKind.SquareCheckOutlined: return typeof(SquareCheckOutlined);
            case GravityIconKind.SquareDashedOutlined: return typeof(SquareDashedOutlined);
            case GravityIconKind.SquareDashedCircleOutlined: return typeof(SquareDashedCircleOutlined);
            case GravityIconKind.SquareDashedLetterAOutlined: return typeof(SquareDashedLetterAOutlined);
            case GravityIconKind.SquareDashedLetterTOutlined: return typeof(SquareDashedLetterTOutlined);
            case GravityIconKind.SquareDashedTextOutlined: return typeof(SquareDashedTextOutlined);
            case GravityIconKind.SquareDotOutlined: return typeof(SquareDotOutlined);
            case GravityIconKind.SquareExclamationOutlined: return typeof(SquareExclamationOutlined);
            case GravityIconKind.SquareHashtagOutlined: return typeof(SquareHashtagOutlined);
            case GravityIconKind.SquareLetterPOutlined: return typeof(SquareLetterPOutlined);
            case GravityIconKind.SquareLetterTOutlined: return typeof(SquareLetterTOutlined);
            case GravityIconKind.SquareLineHorizontalOutlined: return typeof(SquareLineHorizontalOutlined);
            case GravityIconKind.SquareLineVerticalOutlined: return typeof(SquareLineVerticalOutlined);
            case GravityIconKind.SquareListUlOutlined: return typeof(SquareListUlOutlined);
            case GravityIconKind.SquareMinusOutlined: return typeof(SquareMinusOutlined);
            case GravityIconKind.SquarePlusOutlined: return typeof(SquarePlusOutlined);
            case GravityIconKind.SquareXmarkOutlined: return typeof(SquareXmarkOutlined);
            case GravityIconKind.StarOutlined: return typeof(StarOutlined);
            case GravityIconKind.StarFilled: return typeof(StarFilled);
            case GravityIconKind.StethoscopeOutlined: return typeof(StethoscopeOutlined);
            case GravityIconKind.StickerOutlined: return typeof(StickerOutlined);
            case GravityIconKind.StopOutlined: return typeof(StopOutlined);
            case GravityIconKind.StopFilled: return typeof(StopFilled);
            case GravityIconKind.StopwatchOutlined: return typeof(StopwatchOutlined);
            case GravityIconKind.StrikethroughOutlined: return typeof(StrikethroughOutlined);
            case GravityIconKind.SubscriptOutlined: return typeof(SubscriptOutlined);
            case GravityIconKind.SuitcaseOutlined: return typeof(SuitcaseOutlined);
            case GravityIconKind.SunOutlined: return typeof(SunOutlined);
            case GravityIconKind.SuperscriptOutlined: return typeof(SuperscriptOutlined);
            case GravityIconKind.TShirtOutlined: return typeof(TShirtOutlined);
            case GravityIconKind.TachometerOutlined: return typeof(TachometerOutlined);
            case GravityIconKind.TagOutlined: return typeof(TagOutlined);
            case GravityIconKind.TagDollarOutlined: return typeof(TagDollarOutlined);
            case GravityIconKind.TagRubleOutlined: return typeof(TagRubleOutlined);
            case GravityIconKind.TagsOutlined: return typeof(TagsOutlined);
            case GravityIconKind.TargetOutlined: return typeof(TargetOutlined);
            case GravityIconKind.TargetDartOutlined: return typeof(TargetDartOutlined);
            case GravityIconKind.TerminalOutlined: return typeof(TerminalOutlined);
            case GravityIconKind.TerminalLineOutlined: return typeof(TerminalLineOutlined);
            case GravityIconKind.TextOutlined: return typeof(TextOutlined);
            case GravityIconKind.TextAlignCenterOutlined: return typeof(TextAlignCenterOutlined);
            case GravityIconKind.TextAlignJustifyOutlined: return typeof(TextAlignJustifyOutlined);
            case GravityIconKind.TextAlignLeftOutlined: return typeof(TextAlignLeftOutlined);
            case GravityIconKind.TextAlignRightOutlined: return typeof(TextAlignRightOutlined);
            case GravityIconKind.TextIndentOutlined: return typeof(TextIndentOutlined);
            case GravityIconKind.TextOutdentOutlined: return typeof(TextOutdentOutlined);
            case GravityIconKind.ThumbsDownOutlined: return typeof(ThumbsDownOutlined);
            case GravityIconKind.ThumbsDownFilled: return typeof(ThumbsDownFilled);
            case GravityIconKind.ThumbsUpOutlined: return typeof(ThumbsUpOutlined);
            case GravityIconKind.ThumbsUpFilled: return typeof(ThumbsUpFilled);
            case GravityIconKind.ThumbsUp2Outlined: return typeof(ThumbsUp2Outlined);
            case GravityIconKind.ThunderboltOutlined: return typeof(ThunderboltOutlined);
            case GravityIconKind.ThunderboltFilled: return typeof(ThunderboltFilled);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk11(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.SphereOutlined => new SphereOutlined(),
            GravityIconKind.SquareOutlined => new SquareOutlined(),
            GravityIconKind.SquareFilled => new SquareFilled(),
            GravityIconKind.SquareArticleOutlined => new SquareArticleOutlined(),
            GravityIconKind.SquareBarsOutlined => new SquareBarsOutlined(),
            GravityIconKind.SquareBarsVerticalOutlined => new SquareBarsVerticalOutlined(),
            GravityIconKind.SquareBracketsOutlined => new SquareBracketsOutlined(),
            GravityIconKind.SquareBracketsBarsVerticalOutlined => new SquareBracketsBarsVerticalOutlined(),
            GravityIconKind.SquareBracketsLetterAOutlined => new SquareBracketsLetterAOutlined(),
            GravityIconKind.SquareChartBarOutlined => new SquareChartBarOutlined(),
            GravityIconKind.SquareChartColumnOutlined => new SquareChartColumnOutlined(),
            GravityIconKind.SquareCheckOutlined => new SquareCheckOutlined(),
            GravityIconKind.SquareDashedOutlined => new SquareDashedOutlined(),
            GravityIconKind.SquareDashedCircleOutlined => new SquareDashedCircleOutlined(),
            GravityIconKind.SquareDashedLetterAOutlined => new SquareDashedLetterAOutlined(),
            GravityIconKind.SquareDashedLetterTOutlined => new SquareDashedLetterTOutlined(),
            GravityIconKind.SquareDashedTextOutlined => new SquareDashedTextOutlined(),
            GravityIconKind.SquareDotOutlined => new SquareDotOutlined(),
            GravityIconKind.SquareExclamationOutlined => new SquareExclamationOutlined(),
            GravityIconKind.SquareHashtagOutlined => new SquareHashtagOutlined(),
            GravityIconKind.SquareLetterPOutlined => new SquareLetterPOutlined(),
            GravityIconKind.SquareLetterTOutlined => new SquareLetterTOutlined(),
            GravityIconKind.SquareLineHorizontalOutlined => new SquareLineHorizontalOutlined(),
            GravityIconKind.SquareLineVerticalOutlined => new SquareLineVerticalOutlined(),
            GravityIconKind.SquareListUlOutlined => new SquareListUlOutlined(),
            GravityIconKind.SquareMinusOutlined => new SquareMinusOutlined(),
            GravityIconKind.SquarePlusOutlined => new SquarePlusOutlined(),
            GravityIconKind.SquareXmarkOutlined => new SquareXmarkOutlined(),
            GravityIconKind.StarOutlined => new StarOutlined(),
            GravityIconKind.StarFilled => new StarFilled(),
            GravityIconKind.StethoscopeOutlined => new StethoscopeOutlined(),
            GravityIconKind.StickerOutlined => new StickerOutlined(),
            GravityIconKind.StopOutlined => new StopOutlined(),
            GravityIconKind.StopFilled => new StopFilled(),
            GravityIconKind.StopwatchOutlined => new StopwatchOutlined(),
            GravityIconKind.StrikethroughOutlined => new StrikethroughOutlined(),
            GravityIconKind.SubscriptOutlined => new SubscriptOutlined(),
            GravityIconKind.SuitcaseOutlined => new SuitcaseOutlined(),
            GravityIconKind.SunOutlined => new SunOutlined(),
            GravityIconKind.SuperscriptOutlined => new SuperscriptOutlined(),
            GravityIconKind.TShirtOutlined => new TShirtOutlined(),
            GravityIconKind.TachometerOutlined => new TachometerOutlined(),
            GravityIconKind.TagOutlined => new TagOutlined(),
            GravityIconKind.TagDollarOutlined => new TagDollarOutlined(),
            GravityIconKind.TagRubleOutlined => new TagRubleOutlined(),
            GravityIconKind.TagsOutlined => new TagsOutlined(),
            GravityIconKind.TargetOutlined => new TargetOutlined(),
            GravityIconKind.TargetDartOutlined => new TargetDartOutlined(),
            GravityIconKind.TerminalOutlined => new TerminalOutlined(),
            GravityIconKind.TerminalLineOutlined => new TerminalLineOutlined(),
            GravityIconKind.TextOutlined => new TextOutlined(),
            GravityIconKind.TextAlignCenterOutlined => new TextAlignCenterOutlined(),
            GravityIconKind.TextAlignJustifyOutlined => new TextAlignJustifyOutlined(),
            GravityIconKind.TextAlignLeftOutlined => new TextAlignLeftOutlined(),
            GravityIconKind.TextAlignRightOutlined => new TextAlignRightOutlined(),
            GravityIconKind.TextIndentOutlined => new TextIndentOutlined(),
            GravityIconKind.TextOutdentOutlined => new TextOutdentOutlined(),
            GravityIconKind.ThumbsDownOutlined => new ThumbsDownOutlined(),
            GravityIconKind.ThumbsDownFilled => new ThumbsDownFilled(),
            GravityIconKind.ThumbsUpOutlined => new ThumbsUpOutlined(),
            GravityIconKind.ThumbsUpFilled => new ThumbsUpFilled(),
            GravityIconKind.ThumbsUp2Outlined => new ThumbsUp2Outlined(),
            GravityIconKind.ThunderboltOutlined => new ThunderboltOutlined(),
            GravityIconKind.ThunderboltFilled => new ThunderboltFilled(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }

    [UnconditionalSuppressMessage("Trimming", "IL2063",
        Justification = "Every switch arm returns typeof(...) for a generated icon class with a public parameterless constructor.")]
    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
    private static Type GetIconTypeChunk12(GravityIconKind kind)
    {
        switch (kind)
        {
            case GravityIconKind.TicketOutlined: return typeof(TicketOutlined);
            case GravityIconKind.TimelineOutlined: return typeof(TimelineOutlined);
            case GravityIconKind.TimestampsOutlined: return typeof(TimestampsOutlined);
            case GravityIconKind.ToggleOffOutlined: return typeof(ToggleOffOutlined);
            case GravityIconKind.ToggleOnOutlined: return typeof(ToggleOnOutlined);
            case GravityIconKind.TrafficLightOutlined: return typeof(TrafficLightOutlined);
            case GravityIconKind.TrapezoidLeftLineHorizontalOutlined: return typeof(TrapezoidLeftLineHorizontalOutlined);
            case GravityIconKind.TrapezoidUpLineVerticalOutlined: return typeof(TrapezoidUpLineVerticalOutlined);
            case GravityIconKind.TrashBinOutlined: return typeof(TrashBinOutlined);
            case GravityIconKind.TrayOutlined: return typeof(TrayOutlined);
            case GravityIconKind.TriangleDownOutlined: return typeof(TriangleDownOutlined);
            case GravityIconKind.TriangleDownFilled: return typeof(TriangleDownFilled);
            case GravityIconKind.TriangleExclamationOutlined: return typeof(TriangleExclamationOutlined);
            case GravityIconKind.TriangleExclamationFilled: return typeof(TriangleExclamationFilled);
            case GravityIconKind.TriangleLeftOutlined: return typeof(TriangleLeftOutlined);
            case GravityIconKind.TriangleLeftFilled: return typeof(TriangleLeftFilled);
            case GravityIconKind.TriangleRightOutlined: return typeof(TriangleRightOutlined);
            case GravityIconKind.TriangleRightFilled: return typeof(TriangleRightFilled);
            case GravityIconKind.TriangleThunderboltOutlined: return typeof(TriangleThunderboltOutlined);
            case GravityIconKind.TriangleUpOutlined: return typeof(TriangleUpOutlined);
            case GravityIconKind.TriangleUpFilled: return typeof(TriangleUpFilled);
            case GravityIconKind.TrolleyOutlined: return typeof(TrolleyOutlined);
            case GravityIconKind.TvOutlined: return typeof(TvOutlined);
            case GravityIconKind.TvRetroOutlined: return typeof(TvRetroOutlined);
            case GravityIconKind.UmbrellaOutlined: return typeof(UmbrellaOutlined);
            case GravityIconKind.UnderlineOutlined: return typeof(UnderlineOutlined);
            case GravityIconKind.UniversalAccessOutlined: return typeof(UniversalAccessOutlined);
            case GravityIconKind.VaultOutlined: return typeof(VaultOutlined);
            case GravityIconKind.VectorCircleOutlined: return typeof(VectorCircleOutlined);
            case GravityIconKind.VectorSquareOutlined: return typeof(VectorSquareOutlined);
            case GravityIconKind.VideoOutlined: return typeof(VideoOutlined);
            case GravityIconKind.VolumeOutlined: return typeof(VolumeOutlined);
            case GravityIconKind.VolumeFilled: return typeof(VolumeFilled);
            case GravityIconKind.VolumeLowOutlined: return typeof(VolumeLowOutlined);
            case GravityIconKind.VolumeLowFilled: return typeof(VolumeLowFilled);
            case GravityIconKind.VolumeOffOutlined: return typeof(VolumeOffOutlined);
            case GravityIconKind.VolumeOffFilled: return typeof(VolumeOffFilled);
            case GravityIconKind.VolumeSlashOutlined: return typeof(VolumeSlashOutlined);
            case GravityIconKind.VolumeSlashFilled: return typeof(VolumeSlashFilled);
            case GravityIconKind.VolumeXmarkOutlined: return typeof(VolumeXmarkOutlined);
            case GravityIconKind.VolumeXmarkFilled: return typeof(VolumeXmarkFilled);
            case GravityIconKind.WalletOutlined: return typeof(WalletOutlined);
            case GravityIconKind.WalletDotOutlined: return typeof(WalletDotOutlined);
            case GravityIconKind.WeightHangingOutlined: return typeof(WeightHangingOutlined);
            case GravityIconKind.WrenchOutlined: return typeof(WrenchOutlined);
            case GravityIconKind.XmarkOutlined: return typeof(XmarkOutlined);
            case GravityIconKind.XmarkShapeOutlined: return typeof(XmarkShapeOutlined);
            case GravityIconKind.XmarkShapeFilled: return typeof(XmarkShapeFilled);
            default: throw new InvalidOperationException($"Icon kind {kind} does not exist");
        }
    }

    private static Icon CreateIconChunk12(GravityIconKind kind)
    {
        return kind switch
        {
            GravityIconKind.TicketOutlined => new TicketOutlined(),
            GravityIconKind.TimelineOutlined => new TimelineOutlined(),
            GravityIconKind.TimestampsOutlined => new TimestampsOutlined(),
            GravityIconKind.ToggleOffOutlined => new ToggleOffOutlined(),
            GravityIconKind.ToggleOnOutlined => new ToggleOnOutlined(),
            GravityIconKind.TrafficLightOutlined => new TrafficLightOutlined(),
            GravityIconKind.TrapezoidLeftLineHorizontalOutlined => new TrapezoidLeftLineHorizontalOutlined(),
            GravityIconKind.TrapezoidUpLineVerticalOutlined => new TrapezoidUpLineVerticalOutlined(),
            GravityIconKind.TrashBinOutlined => new TrashBinOutlined(),
            GravityIconKind.TrayOutlined => new TrayOutlined(),
            GravityIconKind.TriangleDownOutlined => new TriangleDownOutlined(),
            GravityIconKind.TriangleDownFilled => new TriangleDownFilled(),
            GravityIconKind.TriangleExclamationOutlined => new TriangleExclamationOutlined(),
            GravityIconKind.TriangleExclamationFilled => new TriangleExclamationFilled(),
            GravityIconKind.TriangleLeftOutlined => new TriangleLeftOutlined(),
            GravityIconKind.TriangleLeftFilled => new TriangleLeftFilled(),
            GravityIconKind.TriangleRightOutlined => new TriangleRightOutlined(),
            GravityIconKind.TriangleRightFilled => new TriangleRightFilled(),
            GravityIconKind.TriangleThunderboltOutlined => new TriangleThunderboltOutlined(),
            GravityIconKind.TriangleUpOutlined => new TriangleUpOutlined(),
            GravityIconKind.TriangleUpFilled => new TriangleUpFilled(),
            GravityIconKind.TrolleyOutlined => new TrolleyOutlined(),
            GravityIconKind.TvOutlined => new TvOutlined(),
            GravityIconKind.TvRetroOutlined => new TvRetroOutlined(),
            GravityIconKind.UmbrellaOutlined => new UmbrellaOutlined(),
            GravityIconKind.UnderlineOutlined => new UnderlineOutlined(),
            GravityIconKind.UniversalAccessOutlined => new UniversalAccessOutlined(),
            GravityIconKind.VaultOutlined => new VaultOutlined(),
            GravityIconKind.VectorCircleOutlined => new VectorCircleOutlined(),
            GravityIconKind.VectorSquareOutlined => new VectorSquareOutlined(),
            GravityIconKind.VideoOutlined => new VideoOutlined(),
            GravityIconKind.VolumeOutlined => new VolumeOutlined(),
            GravityIconKind.VolumeFilled => new VolumeFilled(),
            GravityIconKind.VolumeLowOutlined => new VolumeLowOutlined(),
            GravityIconKind.VolumeLowFilled => new VolumeLowFilled(),
            GravityIconKind.VolumeOffOutlined => new VolumeOffOutlined(),
            GravityIconKind.VolumeOffFilled => new VolumeOffFilled(),
            GravityIconKind.VolumeSlashOutlined => new VolumeSlashOutlined(),
            GravityIconKind.VolumeSlashFilled => new VolumeSlashFilled(),
            GravityIconKind.VolumeXmarkOutlined => new VolumeXmarkOutlined(),
            GravityIconKind.VolumeXmarkFilled => new VolumeXmarkFilled(),
            GravityIconKind.WalletOutlined => new WalletOutlined(),
            GravityIconKind.WalletDotOutlined => new WalletDotOutlined(),
            GravityIconKind.WeightHangingOutlined => new WeightHangingOutlined(),
            GravityIconKind.WrenchOutlined => new WrenchOutlined(),
            GravityIconKind.XmarkOutlined => new XmarkOutlined(),
            GravityIconKind.XmarkShapeOutlined => new XmarkShapeOutlined(),
            GravityIconKind.XmarkShapeFilled => new XmarkShapeFilled(),
            _ => throw new InvalidOperationException($"Icon kind {kind} does not exist")
        };
    }
}
