using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 12:
                        Console.WriteLine("You guessed correctly");
                        isGuessed = true;
                        break;
                    case 11:
                        Console.WriteLine("Close but no hand grenade.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.Write("Space Ships are my favorite animal. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            

            Console.WriteLine("Are you happy?");
            string howRU = Console.ReadLine().ToUpper();
            bool happy = howRU=="YES";
            while (!happy)
            {
                switch(howRU)
                {
                    case "NO":
                        Console.Write("That's not the answer I am looking for! Try again!");
                        Console.WriteLine("Are you happy?");
                        howRU = Console.ReadLine().ToUpper();
                        break;
                    case "YES":
                        Console.WriteLine("Way to go!");
                        happy = true;
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("It's a yes/no question! Try again.");
                        Console.WriteLine("Are you happy?");
                        howRU = Console.ReadLine().ToUpper();
                        break;
                        

                }
                
            }
        }
    }
}
