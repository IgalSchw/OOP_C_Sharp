using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public class Bar
    {
        public Bar()
        {
           

        }

        // virtual method always can override
        public virtual void DisplayName()
        {
            Console.WriteLine(nameof(Bar));
        }

        // virtual method always can override
        public virtual void ShowDescription()
        {
            Console.WriteLine($"Description of {nameof(Bar)}");
        }
    }
}
