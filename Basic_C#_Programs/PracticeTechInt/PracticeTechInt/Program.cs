using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTechInt
{
    class Program
    {
        static void Main(string[] args)

        {

            // //add odd numbers together in an array
            // int[] numbers = {1,2,4,7,5,3,1234,1235,1233};
            // int sum = 0;


            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     if (numbers[i] % 2 != 0)
            //     {
            //         sum = sum + numbers[i];
            //         Console.WriteLine(sum);
            //     }


            // }
            // Console.ReadLine();





            // //add array of integers

            // int[] arr = { 1234123, 65734, 1234655, 8645334, 123 };
            // int sum2 = 0;

            //for (int i = 0; i < arr.Length; i++)
            // {
            //     sum2 = sum2 + arr[i];
            //     Console.WriteLine(sum2);
            // }
            // Console.ReadLine();



            ////reverse string method

            //string name = "Bryan Austin Riggs";
            //string newString = "";

            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    newString = newString + name[i];
            //    Console.WriteLine(newString);
            //}
            //Console.ReadLine();



            ///easy easy easy method with array function to reverse string
            //string name2 = "Bryan Austin Riggs";
            //var chars = name2.ToCharArray();

            //Array.Reverse(chars);
            //Console.WriteLine(new string(chars));
            //Console.ReadLine();




            ////remove duplicates
            //string name2 = "Bryan Austin Riggs";
            //var unique = new HashSet<char>(name2);

            //foreach (char c in unique)
            //{

            //    Console.Write(c);
            //    Console.ReadLine();

            //}

            //Console.WriteLine("Enter a string : ");
            //string inputString = Console.ReadLine();
            //string resultString = string.Empty;

            //var unique = new HashSet<char>(inputString);
            //foreach(char c in unique)
            //{
            //    resultString = resultString + c;
            //}
            //Console.WriteLine("After removing duplicates: {0}", resultString);
            //Console.ReadLine();




            //Fizz buzz- create array
            int[] array = new int[100];
            for (int x = 1; x<=100; x++)
            {
                array[x - 1] = x;
            }
            Console.WriteLine("Array Populated");

            //set up loop
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element " + i + " contains integer " + array[i]);
            }


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && array[i] % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (array[i] % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (array[i] % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
                


            }
            Console.ReadLine();
        }   
    }
}
