using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string fname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();

            Person person = new Person();
            Employee employee1 = new Employee();
            

            person.SayName(fname, lname);
            employee1.SayName("Sample", "Student");
            
            Console.ReadLine();
        }
    }
}
            //string result1 = person.FullName(fname,lname);

            //Console.WriteLine("Your full name is " + result1);