using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ConcreteScreenSmartwatchCreator : ScreenCreator
{
    public override Screen CreateScreen()
    {
        throw new NotImplementedException();
    }
}