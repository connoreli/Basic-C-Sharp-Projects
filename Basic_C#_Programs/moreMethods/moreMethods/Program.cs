using System;

namespace moreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Please Enter two numbers, one at a time.");
            int theirNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This one is optional.");
            int optionalNumber = Convert.ToInt32(Console.ReadLine());

            int addition = math.myMethod(theirNumber, optionalNumber = 1);
            Console.WriteLine(addition);
        }
    }
}
