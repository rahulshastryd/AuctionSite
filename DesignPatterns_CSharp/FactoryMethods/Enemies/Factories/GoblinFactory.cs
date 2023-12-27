using FactoryMethods.Enemies.ConcreteEnimies;
using FactoryMethods.Enemies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods.Enemies.Factories
{
    public class GoblinFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Goblin();
        }
    }
}
