using Bridge.Interfaces;

namespace Bridge;

public class WindowWindows : IWindowBridge
{
    public void DrawWindow(string title)
    {
        Console.WriteLine($"Drawing {title} window in Windows style");
    }

    public void DrawButton(string title)
    {
        Console.WriteLine($"Drawing {title} button in Windows style");
    }
}