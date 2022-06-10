using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<T> employee = new Employee<T>();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();

            foreach (int i in List<Things>)
            {
                Console.WriteLine(i + "");
            }
        }

    }
}
