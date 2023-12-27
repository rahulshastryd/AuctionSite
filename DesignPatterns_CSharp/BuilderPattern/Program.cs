using BuilderMethods.Builders;
using BuilderMethods.Director;
using BuilderMethods.Models;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputerDirector director = new ComputerDirector();

            //Build standard computer
            IComputerBuilder standardBuilder = new StandardComputerBuilder();
            director.Construct(standardBuilder);
            Computer standardComputer = standardBuilder.GetComputer();
            Console.WriteLine("Standard Computer: " + standardComputer);

            //Build a gaming Computer
            IComputerBuilder gamingBuilder = new GamingComputerBuilder();
            director.Construct(gamingBuilder);
            Computer gamingComputer = gamingBuilder.GetComputer();
            Console.WriteLine("Gaming Computer: " + gamingComputer);
        }
    }
}