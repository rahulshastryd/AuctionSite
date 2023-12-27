using BuilderMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethods.Builders
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer;
        public GamingComputerBuilder()
        {
            this.computer = new Computer();
        }
        public void BuildCPU()
        {
            computer.CPU = "Intel Core i7";
        }

        public void BuildGPU()
        {
            computer.GPU = "NVIDIA GeForce RTX 3080";
        }

        public void BuildRAM()
        {
            computer.RAM = "16GB DDR4";
        }

        public void BuildStorage()
        {
            computer.Storage = "1TB HDD + 512GB SSD";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
