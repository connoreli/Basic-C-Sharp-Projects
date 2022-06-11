using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee: Person
    {

        public static bool operator ==(Employee employeeID1, Employee employeeID2)
        {
            return employeeID1.Equals(employeeID2);
        }

        public static bool operator !=(Employee employeeID1, Employee employeeID2)
        {
            return !employeeID1.Equals(employeeID2);
        }

        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
