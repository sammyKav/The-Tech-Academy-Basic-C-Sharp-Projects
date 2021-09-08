using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_overload_operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>() { FirstName = "Bill", LastName = "Stink" };
            employee.Thing = new List<string>() { "Drug Conviction", "Assault", "Fighting" };
            foreach (string thing in employee.Thing)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }
    }
}
