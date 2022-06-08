using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int secretNumber = 4;
            Console.WriteLine("Pick a number 1-100!");
            int theirNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number will now be multiplied, added, and subtracted by our secret number!");

            int Addition = math.Add(theirNumber, secretNumber); 
            int Subtraction = math.Subtract(theirNumber, secretNumber);
            int Multiplication = math.Multiply(theirNumber, secretNumber);

            Console.WriteLine(Addition);
            Console.WriteLine(Subtraction);
            Console.WriteLine(Multiplication);


            Console.ReadLine();
        }
    }
}
