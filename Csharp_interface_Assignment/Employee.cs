using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_abstract_Classes
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Employee " + Id + ": " + FirstName + " " + LastName);
            base.SayName();
        }
        public void Quit(Employee employee) //using the interface method in the employee class. 
        {
            Console.WriteLine("Tell the boss that " + Id + " is quitting. He says he feels like he's just a number.");
        }
    }
}
