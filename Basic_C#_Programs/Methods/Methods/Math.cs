using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Math
    {
        public int Add(int theirNumber, int secretNumber)
        {
            int newNumber = theirNumber + secretNumber;
            return newNumber;
        }

        public int Subtract(int theirNumber, int secretNumber)
        {
            int newNumber = theirNumber - secretNumber;
            return newNumber;
        }

        public int Multiply(int theirNumber, int secretNumber)
        {
            int newNumber = theirNumber * secretNumber;
            return newNumber;
        }
    }
}
