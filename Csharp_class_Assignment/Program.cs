using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an number.");
            int p = Convert.ToInt32(Console.ReadLine());
            ModTwo num = new ModTwo();
            num.divTwo(p);
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            Console.WriteLine(StaticClass.strLen(word));
            Console.WriteLine("Another word");
            string word2 = Console.ReadLine();
            Console.WriteLine("The difference in length between the fist word and second is.. " + StaticClass.strLen(word, word2));
            string a;
            Console.WriteLine("Enter another word.");
            oppositeword(out a);
            Console.WriteLine(a);
            Console.ReadLine();
        }
        
        public static void oppositeword(out string opposite)
        {     
            opposite = "un" + Console.ReadLine();   
        }


    }  
    
}




