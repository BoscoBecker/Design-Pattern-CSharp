namespace Adapter.Adapter;

public class Mp4PlayerAdapter : IPlayer
{
    public void Play(string file)
    {
        Libs.Mp4Player.Execute(file);
        Console.WriteLine("Using mp4 player adapter");
    }
}