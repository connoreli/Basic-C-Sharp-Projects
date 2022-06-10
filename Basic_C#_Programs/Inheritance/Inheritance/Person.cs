using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        public string FirstName = "Connor";
        public string LastName = "Eliason";

        public void SayName()
        {

            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + FullName);
        }
    }
}
