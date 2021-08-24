using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_inheritance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", id = 1 };//instantiate
            employee.SayName();//call function for super class 
            Console.ReadLine();
        }
    }
}
