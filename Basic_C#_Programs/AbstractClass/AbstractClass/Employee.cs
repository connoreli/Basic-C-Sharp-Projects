using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee: Person, IQuittable
    {
        public override void SayName()
        {
            throw new NotImplementedException();
        }

        public virtual void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
