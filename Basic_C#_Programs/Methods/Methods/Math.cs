using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Math
    {
        int secretNumber = 4;
        int theirNumber = Convert.ToInt32(Console.ReadLine());
        public Math add()
        {
            int newNumber = theirNumber + secretNumber;
            Console.WriteLine(theirNumber + " plus our secret number is " + newNumber);
        }

        public Math subtract()
        {
            int newNumber = theirNumber - secretNumber;
            Console.WriteLine(theirNumber + " minus our secret number is " + newNumber);
        }

        public Math multiply()
        {
            int newNumber = theirNumber + secretNumber;
            Console.WriteLine(theirNumber + " times our secret number is " + newNumber);
        }
    }
}
