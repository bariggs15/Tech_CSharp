using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\arigg\Logs\log.txt", Convert.ToString(num1));
        }
    }
}
