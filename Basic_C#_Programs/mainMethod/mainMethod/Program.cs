using System;

namespace mainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 100!");
            int theirNumber = Convert.ToInt32(Console.ReadLine());
            int secretNumber = 4;

            Math math = new Math();

            int Addition = math.myMethod(theirNumber, secretNumber);
            Console.WriteLine(Addition);

            Console.WriteLine("Pick a decimal between 2 and 3");
            decimal theirDecimal = Convert.ToDecimal(Console.ReadLine());
            decimal secretDecimal = 5;

            int Subtraction = math.myMethod(theirDecimal, secretDecimal);
            Console.WriteLine(Subtraction);

            Console.WriteLine("Enter a number:");
            string theirString = Console.ReadLine();
            string secretString = "10";

            int Multiplication = math.myMethod(theirString);

            Console.Write(Multiplication);
            
            Console.ReadLine();
        }
    }
}
