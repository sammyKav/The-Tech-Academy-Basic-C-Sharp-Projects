using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>(){  //create a list of objects of class Employee
                new Employee { Id = 1, FirstName ="Ben" ,LastName="Kiteman"},
                new Employee {Id = 2, FirstName="Joe", LastName="Handyman"},
                new Employee {Id = 3, FirstName= "Joe", LastName= "Nachocheese"},
                new Employee { Id= 4, FirstName = "Cowboy", LastName ="Johnson" },
                new Employee { Id= 5, FirstName = "Joe", LastName ="Johnson" },
                new Employee { Id= 6, FirstName = "Ravie", LastName ="Wonker" },
                new Employee { Id= 7, FirstName = "Toothache", LastName ="Bill" },
                new Employee { Id= 8, FirstName = "Monk", LastName ="Ballish" },
                new Employee { Id= 9, FirstName = "Joe", LastName ="O'Calculator" },
                new Employee { Id= 10, FirstName = "Lion", LastName ="Kidney" },
            };
            List<string> JoeList = new List<string>(); //create blank list to insert joes. 

            foreach(Employee joe in EmployeeList) //using for loop to loop through employees
            {
                if (joe.FirstName == "Joe")
                {
                    JoeList.Add(joe.FirstName); //if the name is joe add to the blank list
                }
            }
            Console.WriteLine(JoeList.Count());// confirm the Joe's were added. 4 was printed to console. 

            List<Employee>LambdaJoe = EmployeeList.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine(LambdaJoe.Count());//confirm the joe's were added to the list. 

            foreach(Employee j in LambdaJoe)
            {
                Console.WriteLine(j.FirstName); //printing joe's to the console. 
            }
            

            Console.ReadLine();

        }
    }
}
