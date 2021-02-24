using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Void void1 = new Void();
            void1.div2int(num1);
            double result1 = Void.div2double(num1);
            
            Console.WriteLine("If your number could be fully divided by 2, then here is the result (else it will be 0): " + result1);
            Console.ReadLine();
        }
    }
}
