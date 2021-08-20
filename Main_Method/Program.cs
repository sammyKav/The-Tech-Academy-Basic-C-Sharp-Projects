using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your lucky #. Must be an integer. If you're lucky number is not an int you suck!\n");
            //Console.WriteLine("What will the input parameter type by 1: int, 2:double, 3:string");
            Converter intreturn = new Converter();
          
            int param = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Returning Int: " + intreturn.Addition(param));
            Console.WriteLine("Enter a decimal");
            decimal param1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Returning a decimal:" + intreturn.Addition(param1));
            Console.WriteLine("Enter a number");
            string param2 = Console.ReadLine();
            Console.WriteLine(intreturn.Addition(param2));
            
            


            Console.ReadLine();
            
            
            
        }

    }
}