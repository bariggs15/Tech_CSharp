using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); 
            Employee<int> employee1 = new Employee<int>();

            employee.things =  { "Bill", "Bob", "Joe" };
            employee1.things = { 54323452, 8979, 262626 } ;
        }

        for 
    }
}
