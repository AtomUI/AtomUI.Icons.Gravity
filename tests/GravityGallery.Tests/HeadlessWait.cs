using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;

namespace GravityGallery.Tests;

// AtomUI 6.3.0 起侧边栏折叠与滚动是动效：每次渲染推进一次动画时钟，再由一个 16 毫秒的定时器排下一次渲染。
// RunJobs 只处理排队的作业，不推进定时器，忙等会让动画停在半途；这里用嵌套消息循环等待，
// 定时器、渲染与异步命令的延续都按真实时序运转。
internal static class HeadlessWait
{
    public static bool Until(TopLevel topLevel, Func<bool> condition)
    {
        var reached = false;
        var frame   = new DispatcherFrame();
        var poll    = new DispatcherTimer(DispatcherPriority.Background) { Interval = TimeSpan.FromMilliseconds(10) };
        var timeout = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
        poll.Tick += (_, _) =>
        {
            topLevel.UpdateLayout();
            if (condition())
            {
                reached = true;
                frame.Continue = false;
            }
        };
        timeout.Tick += (_, _) => frame.Continue = false;
        poll.Start();
        timeout.Start();
        Dispatcher.UIThread.PushFrame(frame);
        poll.Stop();
        timeout.Stop();
        return reached;
    }
}
