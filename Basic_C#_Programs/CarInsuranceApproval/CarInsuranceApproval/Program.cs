using System;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            bool hadDUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding Tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualified = age > 15 && hadDUI == false && speedingTickets <= 3;
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
