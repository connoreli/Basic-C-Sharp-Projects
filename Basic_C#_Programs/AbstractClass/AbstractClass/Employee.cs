﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee: Person
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
