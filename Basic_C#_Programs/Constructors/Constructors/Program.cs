using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First construct!");
            newEmployee a = new newEmployee();
            Console.WriteLine("Second construct!");
            newEmployee b = new newEmployee("Connor");
            Console.WriteLine("Third construct!");
            newEmployee c = new newEmployee("Connor", "Eliason");

            Console.ReadLine();
        }

        public class newEmployee
        {
            public string lName;
            public string fName;

            public newEmployee():this("Default fName", "Default lName")
            {
                Console.WriteLine("Record for when new employee joins");
            }

            public newEmployee(string fName):this(fName, "Default lName")
            {
                this.fName = fName;
                Console.WriteLine("Creating record with first name and default last name.");

            }

            public newEmployee(string fName, string lName)
            {
                this.lName = lName;
                this.fName = fName;
                Console.WriteLine("Creating record with first name and default last name.");

            }
        }
    }
}
