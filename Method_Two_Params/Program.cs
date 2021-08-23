using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Two_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Bacteria population = new Bacteria(); //create an object of the class
            Console.WriteLine("You have a bacterial infection and you need antibiotics. Enter hours that have past" +
                "since you ate a donut out of the garbage to calculate the bacteria's population. Optional: enter the mg of antibiotic" +
                "dose to see if it'll get rid of all the bacteria. Minimize the dose to avoid complications. Negative #s represent lost" +
                "beneficial micro-organisms");
            Console.WriteLine("How many hours have past since consuming contaiminated food?");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What dose in mg do you need");
            int mgDose = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(population.bacteriaGrowth(t)); // testing it out with one parameter. 
            Console.WriteLine(population.bacteriaGrowth(t,mgDose));//testing out with two parameters. 
            Console.ReadLine();
        }
    }
}
