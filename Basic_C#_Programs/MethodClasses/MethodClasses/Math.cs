using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClasses
{
    class Math
    {
        public int myMethod(int num1, int num2)
        {
            int operation = num1 * 5;
            Console.WriteLine(num2);
            num1 = 5;
            num2 = 10;
            int numbers = myMethod(5, 10);
            int addition = myMethod(num1, num2);
        }
    }
}
