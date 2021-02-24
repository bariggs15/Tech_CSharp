using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }


    }
}



//*public string fname { get; set; }*/
        //public string lname { get; set; }
        //public void SayName()
 //string result = x + " " + y;
            //Console.WriteLine("Name: " + result);
        //public string FullName(string x, string y)
        //{
        //    string result = x + " " +  y;
        //    return result; 

        //}