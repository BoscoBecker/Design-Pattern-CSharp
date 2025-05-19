using Bridge.Interfaces;

namespace Bridge;

public class WindowLinux : IWindowBridge
{
    public void DrawWindow(string title)
    {
        Console.WriteLine($"Drawing {title} window in Linux style");
    }

    public void DrawButton(string title)
    {
        Console.WriteLine($"Drawing {title} button in Linux style");
    }
}