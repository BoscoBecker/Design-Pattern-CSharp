using Adapter.Adapter;

namespace Adapter;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Send an mp3 file to the mp3 player");
        var file = Console.ReadLine();
        if (file == null) return;
        
        var fileType = file.Split('.').Last();
        switch (fileType)
        {
            case "mp3":
            {
                var mp3 = new Mp3PlayerAdapter();
                    mp3.Play(file);
                    Console.WriteLine("Using mp3 player");
                    break;
            }
            case "mp4":
            {
                var mp4 = new Mp4PlayerAdapter();
                    mp4.Play(file);
                    Console.WriteLine("Using mp4 player");
                    break;
            }
            default:
            {
                Console.WriteLine("File type not supported");
                break;
            }
        }
    }
}