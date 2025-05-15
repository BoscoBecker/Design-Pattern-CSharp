namespace Builder;

public class HamburgerBuilder
{
    private readonly Hamburger _hamburger = new() ;

    //public HamburgerBuilder() => _hamburger = new Hamburger();
    
    public HamburgerBuilder SetTypeBread(string typeBread)
    {
        _hamburger.TypeBread = typeBread;
        return this;
    }

    public HamburgerBuilder SetTypeMeat(string typeMeat)
    {
        _hamburger.TypeMeat = typeMeat;
        return this;
    }
    
    public HamburgerBuilder HasBacon()
    {
        _hamburger.HasBacon = true;
        return this;
    }

    public HamburgerBuilder HasSalad() 
    {
        _hamburger.HasSalad = true;
        return this;
    }
    
    public HamburgerBuilder  HasPotato()
    {
        _hamburger.HasPotato = true;
        return this;
    }
    
    public HamburgerBuilder HasCheese()
    {
        _hamburger.HasCheese = true;
        return this;
    }

    public Hamburger Build() => _hamburger;

}