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
            int result1 = age.Double1(age1);
            int result2 = age.MinusFive(age1);
            int result3 = age.HalfAge(age1);



            Console.WriteLine("Your age doubled is: " + result1 + "\n Your age minus 5 years is: " + result2 + "\n Half of your age is: " + result3);
            Console.ReadLine();

           


            //Console.WriteLine("What is your hourly wages");
            //decimal wages = Convert.ToDecimal(Console.ReadLine());


            //decimal result4 = age.Double1(wages);


            //Console.WriteLine("Your weekly wages are: " + result4.ToString("#.##"));
            //Console.ReadLine();
        }
    }
}
