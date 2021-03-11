using System;

namespace CodeFirstPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolDatabase())
            {
                var student1 = new Student() { FirstName = "Austin" };

                context.students.Add(student1);
                context.SaveChanges();
            }

            Console.WriteLine("This is a new student");
            Console.ReadLine();
        }
    }
}
