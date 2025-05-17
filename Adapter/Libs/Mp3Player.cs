namespace Adapter.Libs;

public class Mp3Player(string file)
{
    public void Run()
    {
        Console.WriteLine($"Playing mp3 file: {file}");
    }

}