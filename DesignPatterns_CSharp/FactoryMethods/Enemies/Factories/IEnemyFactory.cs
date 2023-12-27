using FactoryMethods.Enemies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods.Enemies.Factories
{
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy();
    }
}
