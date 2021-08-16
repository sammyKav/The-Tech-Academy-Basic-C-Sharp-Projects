using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_income_comparrison_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly pay rate");//prompt user to enter pay rate
            string hourRate1 = Console.ReadLine();//ask takes input as string
            int hourRate1Num = Convert.ToInt32(hourRate1);//converts user input to int
            Console.WriteLine("How many hours do you work per week"); //
            string hoursWorked1 = Console.ReadLine();
            int hoursWorkedNum1 = Convert.ToInt32(hoursWorked1);
            int annualSalary1 = hoursWorkedNum1 * 52 * hourRate1Num;

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly pay rate");//prompt user to enter pay rate
            string hourRate2 = Console.ReadLine();//ask takes input as string
            int hourRate2Num = Convert.ToInt32(hourRate2);//converts user input to int
            Console.WriteLine("How many hours do you work per week"); 
            string hoursWorked2 = Console.ReadLine();
            int hoursWorkedNum2 = Convert.ToInt32(hoursWorked2);
            int annualSalary2 = hoursWorkedNum2 * 52 * hourRate2Num;

            Console.WriteLine("Annual Salary of Person 1");
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual Salary of Person 2");
            Console.WriteLine(annualSalary2);

            bool amount = annualSalary1 > annualSalary2;
            string amountStr = amount.ToString();

            Console.WriteLine("Does Person1 make more money than Person2?");
            Console.WriteLine(amountStr);
            Console.ReadLine();
        }
    }
}
