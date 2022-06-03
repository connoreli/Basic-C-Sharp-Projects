using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 77;

            do
            {
                switch (number)
                {
                    case 14:
                        Console.WriteLine("You guessed 14. Try again!");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 22:
                        Console.WriteLine("You guessed 22. Try again!");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 76:
                        Console.WriteLine("You guessed 76. Try again!");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 77:
                        Console.WriteLine("You guessed 77. You are correct! Great job!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } 
            while (!isGuessed);

            Console.Read();
        }
    }
}
