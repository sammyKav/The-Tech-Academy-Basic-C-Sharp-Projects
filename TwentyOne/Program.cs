using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //object oreiented programs. Objects can be represented by a computer program. they have state and behavior.
            Card cardOne = new Card(); //instantiated an object. 
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();

            
        }
    }

   
}
