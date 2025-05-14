using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ScreenWebCreator : ScreenCreator
{
    public override Screen CreateScreen()
    {
        return new ScreenWeb();
    }
}