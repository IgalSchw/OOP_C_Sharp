using System;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers rNumbers1 = new RationalNumbers(200, -200);
            RationalNumbers rNumbers2 = new RationalNumbers(22, 21);

            Console.WriteLine("Rational numbers");
            Console.WriteLine(rNumbers1==rNumbers2); // false
            Console.WriteLine(rNumbers1!=rNumbers2); // true
            Console.WriteLine(rNumbers1 < rNumbers2); // true
            Console.WriteLine(rNumbers1 > rNumbers2); // false
            Console.WriteLine(rNumbers1 <= rNumbers2); // true
            Console.WriteLine(rNumbers1 >= rNumbers2); // false

            rNumbers1++;
            Console.WriteLine(rNumbers1);
            rNumbers1++;
            Console.WriteLine(rNumbers1);
            rNumbers1++;
            Console.WriteLine(rNumbers1);

            rNumbers2++;
            Console.WriteLine(rNumbers2);
            rNumbers2--;
            Console.WriteLine(rNumbers2);
            rNumbers2--;
            Console.WriteLine(rNumbers2);

            RationalNumbers rNumbers3 = new RationalNumbers(5);
            rNumbers1 = new RationalNumbers(200, -200);
            rNumbers2 = new RationalNumbers(22, 21);
            
            rNumbers3 = rNumbers1 + rNumbers2;
            Console.WriteLine(rNumbers3);

            rNumbers3 = rNumbers1 - rNumbers2;
            Console.WriteLine(rNumbers3);

            rNumbers3 = rNumbers1 * rNumbers2;
            Console.WriteLine(rNumbers3);

            rNumbers3 = rNumbers1 / rNumbers2;
            Console.WriteLine(rNumbers3);

            rNumbers3 = rNumbers1 % rNumbers2;
            Console.WriteLine(rNumbers3);

            Console.WriteLine("Complex numbers");
            ComplexNumber c1 = new ComplexNumber(3, 3);
            ComplexNumber c2 = new ComplexNumber(2, 4);
            ComplexNumber c3 = new ComplexNumber(0, 0);
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
            Console.WriteLine(c1 + c3);
            Console.WriteLine(c1 - c3);
            Console.WriteLine(c1 * c3);
            Console.WriteLine(c1 / c3);

            Console.WriteLine(c1.Abs());
            Console.WriteLine(c1.Arg());
            Console.WriteLine(c2.Abs());
            Console.WriteLine(c2.Arg());
            Console.WriteLine(c3.Abs());
            Console.WriteLine(c3.Arg());
        }
    }
}
