using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    public class Converter
    {
     
        
    public int Addition(int param)
        {
            int value = param + 10;
            return value;
        }
    
    public int Addition(decimal param)
        {
          int value = Convert.ToInt32((param)+94);
          return value;  
        }
    public int Addition(string param)
        {
            int num = Convert.ToInt32(param);
            int value = num + 5 ; 
            return value;
        }
    
    }



}
