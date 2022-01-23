using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4_DLL
{
    class BuildingExceptions : Exception
    {
        public BuildingExceptions(string message)
        {
            Console.WriteLine(message);
        }
    }
}
