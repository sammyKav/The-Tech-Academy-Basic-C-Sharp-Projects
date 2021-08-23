using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Two_Params
{
    class Bacteria
    {
        public int bacteriaGrowth(int t) { 
           
            int bact_pop = Convert.ToInt32(Math.Pow(2, t));//growth rate of bacteria
            return bact_pop;
        } 
        
        public int bacteriaGrowth(int t, int mgDose = 0)// add antibiotics to remove bacteria
        {
            int bact_pop = bacteriaGrowth(t);
            int bact_decline = Convert.ToInt32(Math.Pow(mgDose * 100, 2));
            int bact_remain = bact_pop - bact_decline;
            
            return bact_remain;
        }
    
    }
}
