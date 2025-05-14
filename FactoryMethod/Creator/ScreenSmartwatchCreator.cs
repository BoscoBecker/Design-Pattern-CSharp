using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ScreenSmartwatchCreator : ScreenCreator
{
    public override Screen CreateScreen()
    {
        return new ScreenSmartwatch();
    }
}