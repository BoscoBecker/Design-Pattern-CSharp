using Prototype.Interfaces;

namespace Prototype.Entity;

public class EnemyA : Enemy, IEnemyPrototype
{
    public Enemy Clone()
    {
        return (Enemy)this.MemberwiseClone();
    }
}