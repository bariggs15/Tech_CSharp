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


        public static bool operator == (EmployeeID employee1, EmployeeID employee2)
        {
            return employee1.ID == employee2.ID; 

           
        }
        public static bool operator != (EmployeeID employee1, EmployeeID employee2)
        {
            return employee1.ID != employee2.ID;


        }

    }
   
}

