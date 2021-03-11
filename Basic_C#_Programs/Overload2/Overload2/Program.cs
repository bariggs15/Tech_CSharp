using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload2
{
    class Program
    {
        static void Main(string[] args)
        {
           //creates instances of the employee object 
            EmployeeID employee1 = new EmployeeID();
            EmployeeID employee2 = new EmployeeID();
            
        
            employee1.ID = 1;
            employee1.FirstName = "Michael";
            employee1.LastName = "Jordan";

            employee2.ID = 2;
            employee2.FirstName = "Michael";
            employee2.LastName = "Jordan";

            //employee3 is a placeholder that checks if 1 and 2 are the same
            Console.WriteLine(employee1 == employee2);

           

            
            Console.ReadLine();
        }
    }
}
