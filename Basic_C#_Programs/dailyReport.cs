using System;

class DailyReport
{
	static void Main(string [] args)
    {
        Console.WriteLine("The Tech Academy");
        Console.ReadLine();
        Console.WriteLine("Student Daily Report");
        Console.ReadLine();

        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("Your name is: " + yourName);

        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();
        Console.WriteLine("Your course is: " + courseName);

        Console.WriteLine("What page number?");
        short pageNumber = Console.ReadLine();
        Console.WriteLine("You're on page " + pageNumber);

        Console.WriteLine("Do you need help with anything? Please answer true or false.");
        bool needHelp = Console.ReadLine();
        Console.WriteLine(needHelp);

        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();
        Console.WriteLine("Your positive experiences: "positiveExperiences);

        Console.WriteLine("Is there any other feedback you'd like to provide?");
        string feedBack = Console.ReadLine();
        Console.WriteLine("Your feedback: " + feedBack);

        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        Console.WriteLine("Your studied " + hoursStudied + " hours today.");

        Console.WriteLine("Thank you for all your answers. An instructor will respond to this very shortly. Have a great day!");
        Console.ReadLine();
    }
}