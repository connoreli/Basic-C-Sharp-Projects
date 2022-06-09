using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAssignment
{
    public class Math
    {
        public int myMethod(int num)
        {
            int result = num / 2;
            return result;
        }

        public decimal myMethod(decimal num2)
        {
            decimal multiplication = num2 * 2;
            return multiplication;
        }

        public static double myMethod(double num3)
        {
            double addition = num3 + 5;
            return addition;
        }

        void myMethod(out int answer, out string message, out string stillNull)
        {
            answer = 44;
            message = "I've been returned";
            stillNull = null;
        }
    }
}
