using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //*************************************WHILE LOOP, DO/WHILE LOOP RIGHT BELOW IT**********************************************

            Console.WriteLine("guess a famous movie character");
            string movieChar = Console.ReadLine();
            bool guess = movieChar == "Jack Bauer";

            while (!guess)
            {
                switch (movieChar)
                {

                    case "Jack Bauer":
                        Console.WriteLine("you have great taste in movies");
                        guess = true;
                        break;
                    default:
                        Console.WriteLine("not correct, who else can you think of?");
                        movieChar = Console.ReadLine();
                        break;
                }
            }   
                Console.ReadLine();



                //            //breakfast do/while loop
                //            Console.WriteLine("What did you have for breakfast?");
                //            string food = Console.ReadLine();
                //            bool protein = food == "eggs";

                //}            do
                //            {
                //                switch (food)
                //                {
                //                    case "cereal":
                //                        Console.WriteLine("cereal has too much sugar, try again");
                //                        Console.WriteLine("what else can you eat?");
                //                        food = Console.ReadLine();
                //                        break;
                //                    case "oatmeal":
                //                        Console.WriteLine("oatmeal has too much starch, try again");
                //                        Console.WriteLine("what else can you eat?");
                //                        food = Console.ReadLine();
                //                        break;
                //                    case "poptarts":
                //                        Console.WriteLine("are you 5 years old, try again");
                //                        Console.WriteLine("what else can you eat?");
                //                        food = Console.ReadLine();
                //                        break;
                //                    default:
                //                        Console.WriteLine("try again");
                //                        Console.WriteLine("what else can you eat?");
                //                        food = Console.ReadLine();
                //                        break;
                //                    case "eggs":
                //                        Console.WriteLine("finally, some good protein in your body");
                //                        protein = true;
                //                        break;
                //                }
                //            }
                //            while (!protein);
                //            Console.ReadLine();


            }
        }
    }

