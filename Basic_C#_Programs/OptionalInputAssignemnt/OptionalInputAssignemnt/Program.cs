using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalInputAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input another number if you want, if not type 0");
            string num2str = (Console.ReadLine());

            Num1 number1 = new Num1();

            if (num2str =="")
            {
                int result = number1.Add1(num1);
                Console.WriteLine("your result is  " + result);
            }
            else
            {
                int num2 = Convert.ToInt32(num2str);
                int result = number1.Add1(num1, num2);
                Console.WriteLine("if you add your two numbers together you get: " + result);
            }


            Console.ReadLine();
        }
    }
}
