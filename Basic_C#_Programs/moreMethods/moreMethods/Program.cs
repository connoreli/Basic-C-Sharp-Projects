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

            try
            {
                int optionalNumber = Convert.ToInt32(Console.ReadLine());
                int result = math.myMethod(theirNumber, optionalNumber);
                Console.WriteLine("Result of " + theirNumber + " and " + optionalNumber + " passed into the method: " + result);
            }
            catch(Exception)
            {
                int result = math.myMethod(theirNumber);
                Console.WriteLine("Result of " + theirNumber + " passed into the method: " + result);
            }
            Console.ReadLine();
        }
    }
}
