using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("type a number");

            int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("the current date is {0} and the number you wrote it {1}" , DateTime.Now, num1);
            //Console.ReadLine();
        }
    }
}
