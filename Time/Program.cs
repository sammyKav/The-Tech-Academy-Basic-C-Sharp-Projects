using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime =  DateTime.Now; //create datetime object. 
            Console.WriteLine("It is currently " + currentTime); // display it on the console.
            Console.WriteLine("Enter an whole number."); //prompt user for input
            int hoursForward = Convert.ToInt32(Console.ReadLine()); //convert user resonpse to screen
            Console.WriteLine(currentTime.AddHours(hoursForward)); // use AddHours method to add hours to current time and disply on screen. 
            Console.ReadLine();
        }
    }
}
