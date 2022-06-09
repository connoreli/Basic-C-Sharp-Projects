using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClasses
{
    class Math
    {
        public void myMethod(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("The first number plus the second number is " + result);

            Console.WriteLine("The second number is" + num2);
        }
    }
}
