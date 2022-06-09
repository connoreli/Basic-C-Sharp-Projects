using System;

namespace ClassesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int division = math.myMethod(num);
            Console.WriteLine(num + " divided by 2 equals " + division);
        }
    }
}
