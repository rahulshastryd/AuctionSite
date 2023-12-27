using FactoryMethods.Enemies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods.Enemies.ConcreteEnimies
{
    public class Goblin : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Goblin Attacks with a club!");
        }
    }
}
