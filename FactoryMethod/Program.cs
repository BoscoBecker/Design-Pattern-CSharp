using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod;

internal abstract class Program
{
    private static void Main()
    {
        var tv = new ScreenSmartTvCreator().CreateScreen();
        var web = new ScreenWebCreator().CreateScreen();
        var smartPhone = new ScreenSmartphoneCreator().CreateScreen();
        var smartWatch = new ScreenSmartwatchCreator().CreateScreen();

        Console.WriteLine("Screen TV "+tv.GetMessagetext());
        Console.WriteLine("Screen Web "+web.GetMessagetext());
        Console.WriteLine("Screen SmartWatch "+smartPhone.GetMessagetext());
        Console.WriteLine("Screen SmartTV"+smartWatch.GetMessagetext());
    }
}