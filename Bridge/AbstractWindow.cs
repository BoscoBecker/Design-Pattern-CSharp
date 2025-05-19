using Bridge.Interfaces;

namespace Bridge;

public abstract class AbstractWindow(IWindowBridge window)
{
    private readonly IWindowBridge _window = window;
    
    public void DrawWindow(string title)
    {
        _window.DrawWindow(title);
    }
    
    public void DrawButton(string title)
    {
        _window.DrawButton(title);
    }
    
    public abstract void Draw();
    
    
}