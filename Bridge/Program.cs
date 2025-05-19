namespace Bridge;

internal static class Program
{
    private static void Main()
    {
        var windows = new DialogWindow(new WindowWindows());
        windows.Draw();
        windows.DrawWindow("Dialog");
        windows.DrawButton("OK");
        
        var linux = new DialogWindow(new WindowLinux());
        linux.Draw();
        linux.DrawWindow("Dialog");
        linux.DrawButton("OK");
        Console.ReadKey();
    }
}