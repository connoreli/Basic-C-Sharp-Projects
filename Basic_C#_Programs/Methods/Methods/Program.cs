using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Pick a number 1-100!");
            int theirNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number will now be multiplied, added, and subtracted by our secret number!");

            int Addition = math.Add(theirNumber); 
            int Subtraction = math.Subtract(theirNumber);
            int Multiplication = math.Multiply(theirNumber);

            Console.WriteLine(Addition);
            Console.WriteLine(Subtraction);
            Console.WriteLine(Multiplication);


            Console.ReadLine();
        }
    }
}
