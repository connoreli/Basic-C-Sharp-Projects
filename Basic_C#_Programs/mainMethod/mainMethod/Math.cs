using System;
using System.Collections.Generic;
using System.Text;

namespace mainMethod
{
    public class Math
    {
        public int myMethod(int theirNumber, int secretNumber)
        {
            int newNumber = theirNumber + secretNumber;
            return newNumber;
        }

        public int myMethod(decimal theirDecimal, decimal secretDecimal)
        {
            decimal newDecimal = theirDecimal - secretDecimal;
            int result = Convert.ToInt32(newDecimal);
            return result;
        }

        public int myMethod(string theirString)
        {
            int num = Convert.ToInt32(theirString);
            int result = num + 5;
            return result;
        }
    }
}
