
using AbstractFactory.Factory;

namespace AbstractFactory;

internal abstract class Program()
{
    private static void Main()
    {
        IGUIFactory factory = new WindowsFactory();
        
        factory.CreateButton().Paint();
        factory.CreateCheckbox().Paint();
        
        factory = new MacFactory();
        factory.CreateButton().Paint();
        factory.CreateCheckbox().Paint();

    }
}