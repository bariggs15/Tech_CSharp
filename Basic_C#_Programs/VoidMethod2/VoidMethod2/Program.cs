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
            int num2;

            Void void1 = new Void();
            void1.div2int(num1);
            void1.div2int(out num2);

            Console.WriteLine("After calling method your value is: " + num2);
            Console.ReadLine();
        }
    }
}
