using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new  PostStudent())
            {
                Console.WriteLine("What is your first name?");
                var FirstName = Console.ReadLine();

                var student1 = new student { FirstName = FirstName };
                db.PostStudents.Add(student1);
                db.SaveChanges();

                var query = from b in db.PostStudents
                            orderby b.FirstName
                            select b;
                foreach (var item in query)
                {
                    Console.WriteLine(item.FirstName);
                }
                            
            }
        }
    }
}
