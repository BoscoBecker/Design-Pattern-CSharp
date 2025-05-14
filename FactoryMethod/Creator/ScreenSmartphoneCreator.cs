using FactoryMethod.Product;

namespace FactoryMethod.Creator;

public class ConcreteScreenSmartphoneCreator : ScreenCreator

{
    public override Screen CreateScreen()
    {
        throw new NotImplementedException();
    }
}