using System;
using System.Collections.Generic;
using System.Linq;

namespace sixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Cody", "Dallin", "Haley", "Connor" }; // start of step 1
            Console.WriteLine("What is a good last name?");
            string lastNames = Console.ReadLine();

            List<string> list = new List<string>(names.ToList());
            list.Add(lastNames);
            names = list.ToArray();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            list.ForEach(Console.WriteLine);  // end of step 1


            for (int i = 0; i < 5; i++)  // infinite loop and loop using <
            {
                Console.WriteLine(i);
            }

            for (int f = 0; f <= 10; f++) // loop using <=
            {
                Console.WriteLine(f);
            }

            List<string> Names = new List<string>() { "CONNOR", "DALLIN", "HALEY" };  // step 4
            Console.WriteLine(Names);
            Console.WriteLine("Which name would you like to search for?");
            string search = Console.ReadLine();

            for (int n = 0; n < Names.Count; n++)
            {
                if (Names[n] == "CONNOR")
                {
                    Console.WriteLine(Names[0]);
                    break;
                }
                else if (Names[n] == "DALLIN")
                {
                    Console.WriteLine(Names[1]);
                    break;
                }
                else if (Names[n] == "HALEY")
                {
                    Console.WriteLine(Names[2]);
                    break;
                }
                else Console.WriteLine("This name does not exist.");
            }

            // step 5

            List<string> Strings = new List<string>() { "Connor", "Bennett", "Seth", "Seth" };
            Console.WriteLine(Strings);
            Console.WriteLine("Search for a user!");
            string Search = Console.ReadLine();
            foreach (string String in Strings)
            {
                if (Search == "Connor")
                {
                    Console.WriteLine("0");
                }
                else if (Search == "Bennett")
                {
                    Console.WriteLine("1");
                }
                else if (Search == "Seth")
                {
                    Console.WriteLine("2");
                }
                else if (Search == "Seth")
                {
                    Console.WriteLine("3");
                }
                else Console.WriteLine("Input aint on the list, bud.");
            }

            // step 6

            List<string> Strings1 = new List<string>() { "Connor", "Bennett", "Seth", "Seth" };
            foreach(string Stringgss in Strings1)
            {
                if ("Connor" == Strings1[0])
                {
                    Console.WriteLine(Strings1[0] + " has not already appeared in the list.");
                }
                else if ("Bennett" == Strings1[1])
                {
                    Console.WriteLine(Strings1[1] + " has not already appeared in the list.");
                }
                else if ("Seth" == Strings1[2])
                {
                    Console.WriteLine(Strings1[2] + " has not already appeared in the list.");
                }
                else if ("Seth" == Strings1[2] && "Seth" == Strings[3])
                {
                    Console.WriteLine(Strings1[1] + " has already appeared in the list.");
                }
            }

            Console.ReadLine();
        } 
        
    }
}
