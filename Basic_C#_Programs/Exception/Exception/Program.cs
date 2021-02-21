using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {


        List<int> num1 = new List<int>() { 121, 32, 6545, 236, 90 };
        Console.WriteLine("Pick a number to divide the numbers by");
        
        try
        {
            int divNum = Convert.ToInt32(Console.ReadLine());
       
            for (int i = 0; i < num1.Count; i++)
            {
                Console.WriteLine("The number in the list divided by your number is: " + (num1[i] / divNum));
            }
            Console.ReadLine();
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message); 
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }












            //try
            //{
            //    Console.WriteLine("pick a number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("pick another number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int num3 = num1 / num2;
            //    Console.WriteLine(num1 + " diving by " + num2 + " equals " + num3);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("please put a number");
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}





            /// List<int> passingScores = new List<int>();

            //    foreach (int score in testScores)
            //    {
            //        if (score > 85)
            //        {
            //            passingScores.Add(score);
            //        }
            //    }
            //    Console.WriteLine(passingScores.Count); 
            //    Console.ReadLine();


            //Console.WriteLine("select a car in the list");
            //string userInput = Console.ReadLine();
            //bool notInList = true;

            //for (int i = 0; i < cars1.Count; i++)

            //{
            //    if (userInput == cars1[i])
            //    {
            //        notInList = false;
            //        Console.WriteLine(i);
            //    }
            //}
            //if (notInList == true)
            //{
            //    Console.WriteLine("NOT in list");
            //}
            //Console.ReadLine();




















            //List<string> names = new List<string>() { "Austin", "Bob", "Charles" };

            //    foreach (string name in names)
            //    {

            //        Console.WriteLine(name);    

            //    }

            //    Console.ReadLine();

            //    /*List<int> testScores = new List<int>() { 92, 100, 75, 45, 34 };*/
            //    List<int> passingScores = new List<int>();

            //    foreach (int score in testScores)
            //    {
            //        if (score > 85)
            //        {
            //            passingScores.Add(score);
            //        }
            //    }
            //    Console.WriteLine(passingScores.Count);
            //    Console.ReadLine();



            //    int[] testScores = { 99, 98, 85, 64, 30, 12, 100, 35 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + testScores[i]);
            //    }

            //}
            //Console.ReadLine();

            //string[] names = { "Austin", "Bob", "Charles" };

            //for(int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Bob")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //    Console.ReadLine();

            //   string[] names = { "Austin", "Bob", "Charles" };

            //   for (int j = 0; j < names.Length; j++)
            //   {

            //       {
            //           Console.WriteLine(names[j]);
            //       }
            //   }   
            //Console.ReadLine();


            //    List<int> testScores = new List<int>();
            //    testScores.Add(98);
            //    testScores.Add(99);
            //    testScores.Add(58);
            //    testScores.Add(19);
            //    testScores.Add(89);
            //    testScores.Add(35);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //}
            //Console.ReadLine();



            //List<string> names = new List<string>() { "Austin", "Bob", "Charles" };

            //    foreach (string name in names)
            //    {

            //        Console.WriteLine(name);    

            //    }

            //    Console.ReadLine();

            //    List<int> testScores = new List<int>() { 92, 100, 75, 45, 34 };
            //    List<int> passingScores = new List<int>();

            //    foreach (int score in testScores)
            //    {
            //        if (score > 85)
            //        {
            //            passingScores.Add(score);
            //        }
            //    }
            //    Console.WriteLine(passingScores.Count); 
            //    Console.ReadLine();


        }
    }

