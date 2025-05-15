namespace Builder;

internal abstract class Program
{
    private static void Main()
    {
        var xBacon = new HamburgerBuilder()
            .SetTypeBread("Red")
            .SetTypeMeat("beef")
            .HasCheese()
            .HasPotato()
            .HasBacon()
            .HasSalad()
            .Build();

        var xSalad = new HamburgerBuilder()
            .SetTypeBread("Red")
            .SetTypeMeat("beef")
            .HasCheese()
            .HasPotato()
            .HasSalad()
            .Build();

        Console.WriteLine("Order list");
        Console.WriteLine("===============================");
        Console.WriteLine(xBacon.GetDescription());
        Console.WriteLine("===============================");
        Console.WriteLine(xSalad.GetDescription());
        Console.WriteLine("===============================");
    }
}