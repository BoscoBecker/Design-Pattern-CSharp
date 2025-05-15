namespace Prototype.Entity;

public abstract class Enemy
{
    public string? Name { get; set; }
    public string? Color { get; init; }
    
    public Weapon? Weapon { get; set; }
    

}