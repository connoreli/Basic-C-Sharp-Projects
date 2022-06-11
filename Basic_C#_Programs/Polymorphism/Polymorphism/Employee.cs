using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Employee: IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Employee quits.");
        }
    }
}
