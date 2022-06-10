using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee: Person, IQuittable
    {
        int employeeID1 = 0001;
        int employeeID2 = 0002;
        
        public static bool operator== (Employee employeeID1, Employee employeeID2)
        {
            return employeeID1.Equals(employeeID2);
        }

        public static bool operator!= (Employee employeeID1, Employee employeeID2)
        {
            return !employeeID1.Equals(employeeID2);
        }

        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public virtual void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
