using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class ReturnInt
    {
        
        public static int Multiply(int param) //this method creates an Prodcut object
        {
            Random random = new Random();
            int num = random.Next(0, 10);
            int value = num * param;
            return value;
        }

        public static int Add(int param) //this method creates an Addition object
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            int value = param / num;
            return value;
        }



        public static int Division(int param) //this method creates an Division object
        {
            Random random = new Random();
            int num = random.Next(1, 10);
            int value= param + num;
            
            return value ;
    
        }
     
    }

}
