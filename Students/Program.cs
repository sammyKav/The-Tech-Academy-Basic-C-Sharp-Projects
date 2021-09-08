using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new StudentContext())
            {
                Console.Write("Enter a first name for the student:");
                var firstName = Console.ReadLine();
                Console.Write("Enter a last name for the student:");
                var lastName = Console.ReadLine();
                Console.Write("Date of birth?");
                DateTime birthDay = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Grade Name");
                var gradeName = Console.ReadLine();

                var student = new Student { FirstName = firstName, LastName = lastName, DateOfBirth = birthDay, GradeName = gradeName };
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
