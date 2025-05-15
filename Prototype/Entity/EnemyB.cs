using Prototype.Interfaces;

namespace Prototype.Entity;

public class EnemyB : Enemy, IEnemyPrototype
{
    public Enemy Clone()
    {
        return (Enemy)this.MemberwiseClone();
    }
}