using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_parsing_enum_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Structure amt;

            amt.Amount = 14.123m;
            Console.WriteLine(amt.Amount);

            try{ 
            DayofWeek day = new DayofWeek();//create new instance of day. 
            Console.WriteLine("What's the day of the week?");
            string currentDay = Console.ReadLine(); //get string value from user input 
            day = (DayofWeek)Enum.Parse(typeof(DayofWeek), currentDay); // convert string value to DayofWeek type. 
            }
            catch (ArgumentException)//error type is Argument Exception. If that is the type then run the below code. 
            {

                Console.WriteLine("Please enter one of the following to the console.");
                foreach ( string d in Enum.GetNames(typeof(DayofWeek))) //print list of acceptable inputs. 
                {
                    Console.WriteLine($" {d}");
                }
                       
            }
        Console.ReadLine();
        }
    }
}
