using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringArray = { "Connor", "Olivia", "Dallin", "Jack", "Paige" };  // Array of strings
        Console.WriteLine("Pick a number 0-4!");
        int arrayNumber = Convert.ToInt32(Console.ReadLine());
        if (Convert.ToBoolean(arrayNumber = 0))
        {
            Console.WriteLine(stringArray[0]);
        }
        else if (Convert.ToBoolean(arrayNumber = 1))
        {
            Console.WriteLine(stringArray[1]);
        }
        else if (Convert.ToBoolean(arrayNumber = 2))
        {
            Console.WriteLine(stringArray[2]);
        }
        else if (Convert.ToBoolean(arrayNumber = 3))
        {
            Console.WriteLine(stringArray[3]);
        }
        else if (Convert.ToBoolean(arrayNumber = 4))
        {
            Console.WriteLine(stringArray[4]);
        }
        else
        {
            Console.WriteLine("Choose a number between 0 and 4, please thanks love you.");
        }


        int[] intArray = { 1, 10, 100, 1000, 10000 };        // Array of integers
        Console.WriteLine("Pick a number 0-4!");
        int arrayNumber1 = Convert.ToInt32(Console.ReadLine());
        if (Convert.ToBoolean(arrayNumber = 0))
        {
            Console.WriteLine(intArray[0]);
        }
        else if (Convert.ToBoolean(arrayNumber1 = 1))
        {
            Console.WriteLine(intArray[1]);
        }
        else if (Convert.ToBoolean(arrayNumber1 = 2))
        {
            Console.WriteLine(intArray[2]);
        }
        else if (Convert.ToBoolean(arrayNumber1 = 3))
        {
            Console.WriteLine(intArray[3]);
        }
        else if (Convert.ToBoolean(arrayNumber1 = 4))
        {
            Console.WriteLine(intArray[4]);
        }
        else
        {
            Console.WriteLine("Choose a number between 0 and 4, please thanks love you.");
            Console.ReadLine();
        }




        List<string> stringList = new List<string>();    // List of strings
        stringList.Add("Eliason");
        stringList.Add("Bray");
        stringList.Add("Jackson");

        Console.WriteLine("Pick a number 0-2!");
        int listNumber = Convert.ToInt32(Console.ReadLine());

        if (Convert.ToBoolean(listNumber = 0))
        {
            Console.WriteLine(stringList[0]);
        }

        else if (Convert.ToBoolean(listNumber = 1))
        {
            Console.WriteLine(stringList[1]);
        }

        else if (Convert.ToBoolean(listNumber = 2))
        {
            Console.WriteLine(stringList[2]);
        }

        else
        {
            Console.WriteLine("Please pick a number between 0 and 2 dude.");
        }

    }
}
