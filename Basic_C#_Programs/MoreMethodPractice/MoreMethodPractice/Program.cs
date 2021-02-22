using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethodPractice
{
    
    public class favNum
    {
        public int favNum1;
               
        public void mult(int multiply)
        {
            Console.WriteLine("Your favorite number is {0}. \n{0} * 100 = {1}" , favNum1, multiply);
            
        }    
            
    }
    

    class Program
    {
        private const int V = 100;

        static void Main(string[] args)
        {
            favNum num1 = new favNum();
            num1.favNum1 = 15;
            num1.mult(num1 * V);
        }
    }
}
