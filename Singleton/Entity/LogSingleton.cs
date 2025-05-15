namespace Singleton.Entity;

public class LogSingleton
{
    private static LogSingleton? _instance;
    public static LogSingleton GetInstance 
    {
        get
        {
            _instance ??= new LogSingleton(); 
            return _instance; 
        }

    }
    public static void WriteLog(string message)
    {
        Console.WriteLine(message);
    }
}