using System;

namespace OverloadOperators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee ID = int ID;
            Employee employee1 = new Employee(ID)
            {
                ID = 00001
            };

            Employee employee2 = new Employee(ID)
            {
                ID = 00002
            };

        }

    }
}
