using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabledatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What's your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your Favorite number plus 5 =" + total);
            //Console.ReadLine();

            Console.WriteLine("The Tech Academy \n Student Daily Report"); //adding text to the console. 
            Console.WriteLine("What's your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page are you on? Print # only");
            string pageNumStr = Console.ReadLine(); //console only reads strings, so have to save variable as string.
            int pageNum = Convert.ToInt32(pageNumStr); //convert to int variable because logically pagenum should be stored as a number. 
            Console.WriteLine("Do you need help with anything? Answer true or false.");
            string helpNeededStr = Console.ReadLine(); //store variable as string from console. 
            bool helpNeeded = Convert.ToBoolean(helpNeededStr); //convert into bool. 
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide? Be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudyStr = Console.ReadLine(); //console only reads strings, so have to save variable as string.
            int hoursStudy = Convert.ToInt32(hoursStudyStr); //convert to int variable because logically hours study should be stored as a number.

        }
    }
}



