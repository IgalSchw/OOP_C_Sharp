using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_ClassRoles
{
    public class BankActionException : Exception
    {

        public BankActionException(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}
