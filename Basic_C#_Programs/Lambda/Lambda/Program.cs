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
            List<Employees> allEmployees = new List<Employees>();
            
            //List<Employees> employees = new List<Employees>() { "Joe Austin" ,  "Joe Bill", "Z Candace", "Y Don", " D Elizabeth", "E Fred", "H Georgia", "Q Harry", "N Immogene", "P Jake" };
            allEmployees.Add(new Employees() { fname = "Joe", lname = "Austin", numID = 1 });
            allEmployees.Add(new Employees() { fname = "Joe", lname = "Bill", numID = 2 });
            allEmployees.Add(new Employees() { fname = "Z", lname = "Elizabeth", numID = 3 });
            allEmployees.Add(new Employees() { fname = "Y", lname = "Ruthy", numID = 4 });
            allEmployees.Add(new Employees() { fname = "A", lname = "Jim", numID = 5 });
            allEmployees.Add(new Employees() { fname = "Q", lname = "Paul", numID = 6 });
            allEmployees.Add(new Employees() { fname = "W", lname = "Susie", numID = 7 });
            allEmployees.Add(new Employees() { fname = "R", lname = "Fred", numID = 8 });
            allEmployees.Add(new Employees() { fname = "B", lname = "Georgoeee", numID = 9 });
            allEmployees.Add(new Employees() { fname = "H", lname = "Alfie", numID = 10 });

            List<Employees> joeList = new List<Employees>();
            foreach (Employees employeesObject in allEmployees)
            {
                if (employeesObject.fname == "Joe")
                {
                    joeList.Add(employeesObject);

                }
                
            }
            

            List<Employees> joeList1 = allEmployees.Where(x => x.fname == "Joe").ToList();
            
            Console.WriteLine();

            List<Employees> numID5 = allEmployees.Where(x => x.numID > 5).ToList();
            foreach (Employees num5 in numID5)
            {
                Console.WriteLine(num5.lname);
            }
            Console.ReadLine();

            
           




            
        }
    }
}
