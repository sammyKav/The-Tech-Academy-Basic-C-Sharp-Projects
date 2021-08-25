using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_parsing_enum_Assignment
{

    class Day
    {
        public DayofWeek DayofWeek { get; set; } //make a property of class DayofWeek. 
    }
        public enum DayofWeek //create class enum named DayofWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    
}
