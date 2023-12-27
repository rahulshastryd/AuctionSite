using BuilderMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMethods.Builders
{
    public class StandardComputerBuilder : IComputerBuilder
    {
        private Computer computer;
        public StandardComputerBuilder()
        {
            this.computer = new Computer();
        }
        public void BuildCPU()
        {
            computer.CPU = "Intel Core i5";
        }

        public void BuildGPU()
        {
            computer.GPU = "Integrated Graphics";
        }

        public void BuildRAM()
        {
            computer.RAM = "8 GB DDR4";
        }

        public void BuildStorage()
        {
            computer.Storage = "256GB SSD";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
