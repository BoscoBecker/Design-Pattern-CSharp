using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ConcreteScreenSmartTVCreator : ScreenCreator
{
    public override Screen CreateScreen()
    {
        throw new NotImplementedException();
    }
}