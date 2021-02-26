using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter current day of week: ");
            string day1 = Console.ReadLine();

            try { 
            
            Console.WriteLine("The corresponding value is: {0} = {1:D} ", day1, Enum.Parse(typeof(DaysOfWeek), day1));
            Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter actual day of week", e.Message);
            }
            Console.ReadLine();

            //try
            //{   
            //    foreach (string day in Enum.GetNames(typeof(DaysOfWeek)))
            //    {
            //        Console.WriteLine("The corresponding value is: {0} = {1:D}", day, Enum.Parse(typeof(DaysOfWeek), day));
            //    }
            //    Console.ReadLine();
            //    //DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day1);
            //    //Console.WriteLine();
            //    //Console.ReadLine();
            //}
            //catch  (ArgumentException e)
            //{
            //    Console.WriteLine("Please enter actual day of week", e);
            //}
        }
    }
}
