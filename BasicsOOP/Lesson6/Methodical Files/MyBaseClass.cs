using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Methodical_Files
{
    class MyBaseClass : IDisposable
    {
        protected MyBaseClass()
        {
            Console.WriteLine("MyBaseClass constructor called.");
        }

        protected MyBaseClass(int aNumber)
        {
            string output;
            output = string.Format("MyBaseClass created with value {0}.", aNumber);
            Console.WriteLine(output);
        }

        ~MyBaseClass()
        {
            Console.WriteLine("MyBaseClass destructor called.");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    class MySubclass : MyBaseClass
    {
        public MySubclass()
        {
            Console.WriteLine("MySubclass constructor called.");
        }

        // constructor base class using base
        public MySubclass(int startValue) : base(startValue - 1)
        {
            string output;
            output = string.Format("MySubclass created with value {0}.", startValue);
            Console.WriteLine(output);
        }

        ~MySubclass()
        {
           Console.WriteLine("MySubclass destructor called.");
        }
    }
}
