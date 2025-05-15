namespace Builder;

public class Hamburger
{
    public string? TypeBread { get; set; }
    public string? TypeMeat { get; set; }
    public bool HasBacon { get; set; }
    public bool HasPotato { get; set; }
    public bool HasCheese { get; set; }
    public bool HasSalad { get; set; }
    
    public string GetDescription()
    {
        var description = $"Hamburger with {TypeBread} bread and {TypeMeat} meat";
        if (HasBacon) description += " with bacon";
        if (HasPotato) description += " with potato";
        if (HasCheese) description += " with cheese";
        if (HasSalad) description += " with salad";
        return description;
    }
        
}