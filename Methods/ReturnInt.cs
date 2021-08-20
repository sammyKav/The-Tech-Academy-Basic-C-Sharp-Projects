using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class ReturnInt
    {
        
        public void Multiply(int param) //this method creates an Prodcut object
        {
            Random random = new Random();
            int num = random.Next(0, 10);
            Product = num * param;
            
        }

        public void Add(int param) //this method creates an Addition object
        {
            Random random = new Random();
            int num = random.Next(0, 10);
            Addition = param + num;
        }



        public void Division(int param) //this method creates an Division object
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            Quotient = param / num;
    
        }
     
        public int Product { get; set; } //create object for each method. 
        public int Addition { get; set; }
        public int Quotient { get; set; }
    }

}
