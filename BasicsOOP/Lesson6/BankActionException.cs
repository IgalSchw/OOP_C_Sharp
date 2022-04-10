using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public class BankActionException : Exception
    {

        public BankActionException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}
