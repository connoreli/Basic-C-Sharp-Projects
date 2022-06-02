using System;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            int salary1 = hourlyRate * hoursWorked;
            Console.WriteLine(salary1);

            Console.WriteLine("Annual salary of Person 2:");
            int salary2 = hourlyRate2 * hoursWorked2;
            Console.WriteLine(salary2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreMoney = salary1 > salary2;
            Console.WriteLine(moreMoney.ToString());
            Console.ReadLine();
        }
    }
}
