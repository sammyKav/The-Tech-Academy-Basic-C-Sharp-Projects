using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int num = 5; //constant variable. It will not change after program has been compiled. 
            Console.WriteLine("The magic # is " + num);

             

            Console.WriteLine("Enter your dog breed");
            var breed = Console.ReadLine();//implicitly defining a variable.
            Dog dog = new Dog(breed); //create an instance of Dog class. 
            Console.WriteLine("Your dog has a default size of " + dog.Size + " Please go to the back of the line immediately");//this is example of linking a constructor. 
            Console.ReadLine();
        }
    }
}
