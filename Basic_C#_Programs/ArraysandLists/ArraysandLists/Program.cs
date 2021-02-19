using System;
using System.Collections.Generic;



    class Program
    {
    static void Main()
    {

        string[] famArray = { "Bruce", "Tobi", "Whitney", "Austin", "Alex" };
        Console.WriteLine("select a number between 0-4");
        int index1 = Convert.ToInt32(Console.ReadLine());

        if (index1 <= 4)
        {
            Console.WriteLine("you chose " + famArray[index1]);
            Console.ReadLine();

            int[] ages = { 59, 56, 34, 31, 29 };
            Console.WriteLine("select the same number to see how old they are");
            int index2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The age of " + famArray[index1] + " is " + ages[index2]);
            Console.ReadLine();
        }

        else
        {
            Console.WriteLine("you have chosen an incorrect value. Goodbye.");
            Console.ReadLine();
        }


        List<string> newFamily = new List<string>();
        newFamily.Add("Bradleigh");
        newFamily.Add("Nick");
        newFamily.Add("Jireh");

        Console.WriteLine("select a number 0, 1, or 2 to reveal who the new family members are");
        int newFam = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("One of the new family members is " + newFamily[newFam]);
        Console.ReadLine();




















        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        ////can also use for strings//
        //Console.WriteLine(intList[1]);
        //Console.ReadLine();



        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        ////************easiest method**********************
        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();

    }
}

