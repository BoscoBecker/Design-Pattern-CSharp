using Prototype.Entity;

namespace Prototype;

internal abstract class Program
{
    private static void Main()
    {
        var playEnemyA = new EnemyA
        {
            Color = "Red",
            Name = "Player1",
            Weapon = new Weapon("AK-47")
        };
        var playEnemyB = playEnemyA.Clone() as EnemyA;
        playEnemyB!.Name = "Player2";
        playEnemyB.Weapon = new Weapon("M4A1");

        Console.WriteLine($"EnemyA: {playEnemyA.Name} - {playEnemyA.Color} - {playEnemyA.Weapon.Name}");
        Console.WriteLine($"EnemyB: {playEnemyB.Name} - {playEnemyB.Color} - {playEnemyB.Weapon.Name}");
    }
}