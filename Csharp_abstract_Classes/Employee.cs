using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_abstract_Classes
{
    class Employee : Person
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Employee " + Id + ": " + FirstName + " " + LastName);
            base.SayName();
        }
    }
}
