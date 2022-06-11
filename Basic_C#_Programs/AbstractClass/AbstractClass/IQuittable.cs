using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    interface IQuittable
    {
        void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
