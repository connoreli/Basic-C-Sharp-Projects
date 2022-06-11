using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class constructorChain
        {
            private const int x;
            private var j;

            public constructorChain() : this(10, 55)
            {

            }
        }
    }
}
