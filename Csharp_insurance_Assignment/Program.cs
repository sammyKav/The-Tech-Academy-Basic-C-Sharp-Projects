using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_insurance_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your age?");
            string age = Console.ReadLine();
            int ageNum = Convert.ToInt32(age);//turn it into a int so its quantity can be compared.
            Console.WriteLine("Have you ever had a DUI. Enter true or false");
            string duiStr = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiStr); //change to bool so it can be compared. 
            Console.WriteLine("How many speeding tickets have you gotten. Write an integer.");
            string speedTicket = Console.ReadLine();
            int speedTicketNum = Convert.ToInt32(speedTicket);//converts it to int so it's quant can be evaluated. 

            bool approve = (ageNum > 15 && true != dui && speedTicketNum < 3);
            string approveStr = approve.ToString();

            Console.WriteLine(approveStr);
            Console.ReadLine();

        }
    }
}
