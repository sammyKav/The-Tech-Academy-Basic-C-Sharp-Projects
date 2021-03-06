using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };//instantiate
            //employee.SayName();//call function for abstract class 
            
            IQuittable quit = new Employee(); //polymorphism to the create an object of type IQuitable.
            quit.Quit(employee); //creat an object of type IQuittable. 
            
            Console.ReadLine();
        }
    }
}
