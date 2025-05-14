using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ConcreteScreenWebCreator : ScreenCreator
{
    public override Screen CreateScreen()
    {
        throw new NotImplementedException();
    }
}