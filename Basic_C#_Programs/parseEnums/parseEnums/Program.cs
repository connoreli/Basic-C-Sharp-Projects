using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("What day is it today?");
            string day1 = Console.ReadLine();
            DaysOfTheWeek weekday1 = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day1);
            if (Enum.TryParse(day1, out weekday1))
            {
                Console.WriteLine("The day of the week is: {0}", day1);
            }
        }

        catch
        {
            Console.WriteLine("Please enter an actual day of the week!");
        }
        Console.ReadLine();
    }

    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }       
}

