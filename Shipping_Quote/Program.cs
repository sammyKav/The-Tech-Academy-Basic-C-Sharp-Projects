using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Crazy Joe's Insane Package Shipping");
            Console.WriteLine("Enter package weight in lbs.");
            int pckWeight = Convert.ToInt32(Console.ReadLine());
            string wghtCheck = pckWeight > 50 ? "Package is too heavey" : "Ok";
            if(wghtCheck == "Ok")
            {
                Console.WriteLine("Enter package height (inches)");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter package length (inches)");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter package width (inches)");
                int width = Convert.ToInt32(Console.ReadLine());
                
                int total = length + height + width;
                string dimChk = total > 50 ? "Dim violation" : "Ok";
                if(dimChk == "Ok")
                {
                   double cost = Convert.ToDouble(((length*height*width)*pckWeight)/100);
                    Console.WriteLine("Your estimated shipping cost is " + cost);
                    Console.ReadLine();
                }
                else { Console.WriteLine(dimChk);
                    Console.ReadLine();
                }
            }
            else { Console.WriteLine("Too Heavy Try Again!");
                Console.ReadLine();
            }


      

















        }
    }
}
