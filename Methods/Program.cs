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
             //calling the methods to create instances of objects 
            
            Console.WriteLine("Add " + ReturnInt.Division(param) + " divide " + ReturnInt.Add(param) + " multiply " + ReturnInt.Multiply(param));
            
            Console.ReadLine();
        
        }
       
        
    }
}
