using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_overload_operator_Assignment
{
    class Employee<T> : Person
    {
        public int Id { get; set; }
        //public static bool operator == (Employee<T> employee, Employee<T> employee2) //overloading the operator
        //{
        //   return employee.Id == employee2.Id;    // assinging operator new alternate value.
        //}
        //public static bool operator !=(Employee<T> employee, Employee<T> employee2) //overloading the operator
        //{

        //    return employee.Id != employee2.Id;    // assinging operator new alternate value.
        //}
        public List<T> Thing { get; set; }
        
    }
}
