using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload2
{
    public class EmployeeID
    {
        public  string Employee1 { get; set; }
        public string Employee2 { get; set; }

        public void EmployeeCheck(string x, string y)
        {
            if (x == y)
            {
                throw new ArgumentException("Cannot have same ID#");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("the first employee is " + x + "\n the second employee is " + y);
                Console.ReadLine();
            }
        }
        
    }
   
}

