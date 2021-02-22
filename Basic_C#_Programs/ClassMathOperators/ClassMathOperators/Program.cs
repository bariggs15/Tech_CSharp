using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMathOperators
{

       
    
    public class Program
    {



        static void Main(string[] args)
        {
           Console.WriteLine("What is your age : ");
            int age1 = Convert.ToInt32(Console.ReadLine()); 
            
            PersonAge age = new PersonAge();
            age.doubleAge = (age1 * 2);
            age.ageMinusFive = (age1 - 5);
            age.halfAge = (age1 / 2);

            Console.WriteLine("Your age doubled is: " + age.doubleAge + "\n Your age minus 5 years is: " + age.ageMinusFive + "\n Half of your age is: " + age.halfAge) ;
            Console.ReadLine();
            
            

            
        }
        
    }
}
