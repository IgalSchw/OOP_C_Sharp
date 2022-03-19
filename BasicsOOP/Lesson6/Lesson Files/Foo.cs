using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public class Foo : Bar
    {
        public override void DisplayName()
        {
            Console.WriteLine(nameof(Foo));
        }

        public override void ShowDescription()
        {
            Console.WriteLine($"Description of {nameof(Foo)}");
        }
    }

    public class SupeFoo : Foo
    {
        public override void DisplayName()
        {
            Console.WriteLine(nameof(SupeFoo));
        }

        public override void ShowDescription()
        {
            Console.WriteLine($"Description of {nameof(SupeFoo)}");
        }
    }
}
