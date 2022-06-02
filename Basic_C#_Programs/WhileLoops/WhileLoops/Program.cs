using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
                break;
            }
            

            int x = 0;
            do
            {
                Console.WriteLine(i);
                i++;
                break;
            }
            while (x < 5);
        }
    }
}
