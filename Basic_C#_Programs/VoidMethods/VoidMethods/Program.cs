using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input another number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Void void1 = new Void();

            void1.Squared(num1, num2);
            //int result1 = void1.Squared(num1);
            //int result2 = void1.squared(num2);

            //Console.WriteLine("your number square is " + result1);
            //Console.WriteLine("your second number was: " + result2);
            Console.ReadLine();
        }

    }
}

