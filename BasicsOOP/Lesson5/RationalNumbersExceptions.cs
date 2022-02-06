using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    class RationalNumbersExceptions : Exception
    {
        public RationalNumbersExceptions(string message)
        {
            Console.WriteLine(message);
        }
    }
}