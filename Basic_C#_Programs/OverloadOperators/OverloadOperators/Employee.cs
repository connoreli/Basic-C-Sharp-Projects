using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadOperators
{
    public class Employee
    {
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.ID !== employee2.ID;
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.ID == employee2.ID;
        }
    }
}
