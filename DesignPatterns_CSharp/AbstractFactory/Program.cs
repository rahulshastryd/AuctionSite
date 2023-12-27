using FactoryMethods.Enemies.Factories;
using FactoryMethods.Enemies.Interfaces;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create goblin using GoblinFactory
            IEnemyFactory goblinFactory = new GoblinFactory();
            IEnemy goblin = goblinFactory.CreateEnemy();
            goblin.Attack();

            // Create troll using TrollFactory
            IEnemyFactory trollFactory = new TrollFactory();
            IEnemy troll = trollFactory.CreateEnemy();
            troll.Attack();
        }
    }
}