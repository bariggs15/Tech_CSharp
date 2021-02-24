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


            Person person = new Person();
            Employee employee1 = new Employee();

            employee1.FirstName = "Sample";
            employee1.LastName = "Student";
            employee1.SayName();

            Console.ReadLine();
        }
    }
}
            //string result1 = person.FullName(fname,lname);

            //Console.WriteLine("Your full name is " + result1);            
            

            //Console.WriteLine("What is your first name?");
            //string fname = Console.ReadLine();
            //Console.WriteLine("What is your last name?");
            //string lname = Console.ReadLine();           
            
            //string fname = "Sample";
            //string lname = "Student"; 
            
               //person.SayName(fname, lname);
            //employee1.SayName("Sample", "Student");
            