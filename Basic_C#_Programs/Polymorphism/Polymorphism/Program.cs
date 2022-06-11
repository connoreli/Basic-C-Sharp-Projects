using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittable = new Employee();
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
