namespace Adapter.Adapter;

public class Mp3PlayerAdapter :IPlayer
{
    public void Play(string file)
    {
        var mp3Player = new Libs.Mp3Player(file);
            mp3Player.Run();
        Console.WriteLine("Using mp3 player adapter");
    }
}