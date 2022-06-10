using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        public void SayName()
        {
            string FirstName = "Connor";
            string LastName = "Eliason";

            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);
        }
    }
}
