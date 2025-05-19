using Bridge.Interfaces;

namespace Bridge;

public class DialogWindow(IWindowBridge window) : AbstractWindow(window)
{
    public override void Draw()
    {
        DrawWindow("Dialog");
    }
}