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
            EmployeeID employee = new EmployeeID();

            employee.Employee1 = "Jordans";
            employee.Employee2 = "Jordan";
            employee.EmployeeCheck(employee.Employee1, employee.Employee2);

           

            
            Console.ReadLine();
        }
    }
}
