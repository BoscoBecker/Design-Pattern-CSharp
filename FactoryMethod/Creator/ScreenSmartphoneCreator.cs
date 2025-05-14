using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ScreenSmartphoneCreator : ScreenCreator
{
    public override Screen CreateScreen()
    {
        return new ScreenSmartphone();
    }
}