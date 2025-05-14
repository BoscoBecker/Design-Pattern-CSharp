using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ScreenSmartTvCreator : ScreenCreator
{
    public override Screen CreateScreen()
    {
        return new ScreenSmartTV();
    }
}