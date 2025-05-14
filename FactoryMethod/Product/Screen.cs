using FactoryMethod.Creator;

namespace FactoryMethod.Product;

public abstract class Screen(string backgroundColor, string messageText)
{
    protected string BackgroundColor { get; } = backgroundColor;

    public string GetMessagetext() => messageText;


}