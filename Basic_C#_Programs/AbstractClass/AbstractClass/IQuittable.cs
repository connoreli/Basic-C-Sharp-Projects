using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    interface IQuittable
    {
        void Quit()
        {
            IQuittable quittable = new IQuittable();
            quittable.Quit();
        }
    }
}
