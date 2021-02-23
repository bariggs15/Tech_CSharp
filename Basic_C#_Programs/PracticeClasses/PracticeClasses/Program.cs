using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is your hourly wages");
            
            int wage1 = Convert.ToInt32(Console.ReadLine());

            decimal wage2 = Convert.ToDecimal(wage1);

            //Console.WriteLine("Enter a second number");
            string wage3 = Console.ReadLine();

            Wages wage = new Wages();

            int result1 = wage.weeklyWage(wage1);
            int result2 = wage.weeklyWage(wage2);
            int result3 = wage.weeklyWage(wage3);

            Console.WriteLine("Your weekly wages are :" + result1);
            Console.ReadLine();
            Console.WriteLine("Your daily wages are: " + result2);
            Console.ReadLine();
            Console.WriteLine("Your yearly wages are : " + result3);
            Console.ReadLine();

        }
    }
}



            //Console.WriteLine("What is your hourly wages");
            //decimal wages = Convert.ToDecimal(Console.ReadLine());


            //decimal result4 = age.Double1(wages);


            //Console.WriteLine("Your weekly wages are: " + result4.ToString("#.##"));
            //Console.ReadLine();


            //public int Double1(decimal x)
            //{
            //    decimal result = x * 40;
            //    return Convert.ToInt32(result);
            //}

        