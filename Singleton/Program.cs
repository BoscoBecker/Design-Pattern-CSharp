using Singleton.Entity;

namespace Singleton;

 internal abstract class Program
 {
     private static void Main()
     {  
         var log = LogSingleton.GetInstance;
         LogSingleton.WriteLog("Singleton pattern in C#");
         var log2 = LogSingleton.GetInstance;
         LogSingleton.WriteLog("Singleton pattern in C#");
         Console.WriteLine(log == log2); // True
         LogSingleton.WriteLog("End of program");
     }
 }