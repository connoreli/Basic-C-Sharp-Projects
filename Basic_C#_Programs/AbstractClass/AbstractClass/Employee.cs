using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee<T>: Person, IQuittable
    {
        int employeeID1 = 0001;
        int employeeID2 = 0002;

        List<T> Things = new List<T>();

        List<int> Things = new List<int>() { 23, 30, 26 };

        List<string> Things = new List<string>() { "Connor", "Dallin", "Haley" };

        public static bool operator ==(Employee<T> employeeID1, Employee<T> employeeID2)
        {
            return employeeID1.Equals(employeeID2);
        }

        public static bool operator !=(Employee<T> employeeID1, Employee<T> employeeID2)
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
