using FactoryMethods.Enemies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods.Enemies.ConcreteEnimies
{
    public class Troll : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Troll attacks with brute force!");
        }
    }
}
