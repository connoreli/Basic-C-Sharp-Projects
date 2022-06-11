using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("The time right now: {0}.", now);

            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = now.AddHours(number);
            Console.WriteLine("It will be {0} in exactly {1} hours.", newTime, number);

            Console.ReadLine();
        }
    }
}
