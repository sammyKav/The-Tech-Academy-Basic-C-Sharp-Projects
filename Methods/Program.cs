using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int param = Convert.ToInt32(Console.ReadLine());
            ReturnInt number = new ReturnInt();
            number.Add(param); //calling the methods to create instances of objects 
            number.Multiply(param);
            number.Division(param);

            Console.WriteLine("Add " + number.Addition + " divide " + number.Quotient + " multiply " + number.Product);
            Console.ReadLine();
        
        }
       
        
    }
}
