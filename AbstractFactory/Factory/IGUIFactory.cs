using AbstractFactory.Product;

namespace AbstractFactory.Factory;

public interface IGUIFactory
{
    public IButton CreateButton();
    public ICheckbox CreateCheckbox();
    
}