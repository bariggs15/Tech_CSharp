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
            DateTime date = new DateTime();

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("type a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
