using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>() { "Joe Austin" ,  "Joe Bill", "Z Candace", "Y Don", " D Elizabeth", "E Fred", "H Georgia", "Q Harry", "N Immogene", "P Jake" };


            //int counter = 0;
            //foreach (string employee in employees)
            //{
            //    if (employee.StartsWith("Joe")) 
            //    {
            //        counter++;
            //        Console.WriteLine(employee);
            //    }
            //}

            List<string> newList = employees.Where(x => x.StartsWith("Joe")).ToList();
            
            Console.WriteLine(employees);

            int numID = employees.Where(x => x > 5).ToList();
            Console.ReadLine();




            
        }
    }
}
