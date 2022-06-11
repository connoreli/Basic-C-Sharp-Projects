using System;

namespace OverloadOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
        }

        public static bool operator !=(Employee employee1ID, Employee employee2ID)
        {
            return !employee1ID.Equals(employee2ID);
        }
        
        public static bool operator ==(Employee employee1ID, Employee employee2ID)
        {
            return employee1ID.Equals(employee2ID);
        }
    }
}
