using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new  StudentContext())
            {
                Console.WriteLine("What is your first name?");
                var FirstName = Console.ReadLine();

                var student1 = new student { FirstName = FirstName };
                
                db.students.Add(student1);
                db.SaveChanges();

                var query = from b in db.students
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
