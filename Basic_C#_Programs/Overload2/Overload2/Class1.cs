using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload2
{
    public class EmployeeID
    {
        public  int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void EmployeeCheck(int x, int y)
        {
            //takes in object information from ID and determines if they're equal. If they are they throw the error. If not it passes through. 
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

