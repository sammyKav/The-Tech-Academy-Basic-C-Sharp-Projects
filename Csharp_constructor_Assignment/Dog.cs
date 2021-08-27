using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_constructor_Assignment
{
    public class Dog
    {
        public Dog(string breed) : this(breed, "medium") { }//chaining two constructors together. 
        public Dog(string breed, string size)// constructor
        {
            Breed = breed;
            Size = size;
        }
        public string Breed { get; set; } //set properties
        public string Size { get; set; }
    }
}
