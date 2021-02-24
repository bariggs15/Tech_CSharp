using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public void SayName(string x, string y)
        {
            string result = x + " " + y;
            Console.WriteLine("Name: " + result);

        }
        //public string FullName(string x, string y)
        //{
        //    string result = x + " " +  y;
        //    return result; 

        //}

       
    }
}
