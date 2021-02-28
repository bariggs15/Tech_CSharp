using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.WriteLine(date);

            Console.WriteLine("type a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(date.AddHours(num1));

            //Console.WriteLine("the current time plus your input is {0}", Convert.ToDateTime(DateTime.Now.Hour + num1));
            //DateTime addedTime = Convert.ToDateTime(Console.ReadLine());

            //Console.WriteLine(addedTime);
            Console.ReadLine();
        }
    }
}
