using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string song = "Sing out Loud";
            string artist = "Kenny Rogers";
            string album = "Pig Farm";
            string combine = song + " " + artist + " " + album; //concatenates strings together
            combine.ToUpper(); //creates uppercase. 

            StringBuilder sb = new StringBuilder(); //create a object of the class StringBuilder. 



            sb.Append("Sentence 1");
            sb.Append(" Sentence 2");
            sb.Append(" Sentence 3");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
