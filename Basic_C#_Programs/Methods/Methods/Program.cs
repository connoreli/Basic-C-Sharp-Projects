using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number 1-100!");
            int theirNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number will now be multiplied, added, and subtracted by our secret number!");
            Math add(); 
            Math subtract();
            Math multiply();
            Console.ReadLine();
        }
    }
}
