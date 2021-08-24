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
            Employee employee = new Employee() { Id = 0, FirstName = "Uncle", LastName = "Randy" };
            Employee employee2 = new Employee() { Id = 1, FirstName = "Bill", LastName = "Toothache" };
           

            Console.WriteLine(employee.Id == employee2.Id);
            Console.ReadLine();

        }
    }
}
