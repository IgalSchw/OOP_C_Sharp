using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    internal class RationalNumbers : IComparable
    {
        private int _numerator { get; set; }
        private int _denominator { get; set; }
        private int _gcd { get; set; }

        public RationalNumbers(int numerator, int denominator)
        {
            try
            {
                GCD = Math.Abs(gcd(numerator, denominator));
                Numerator = numerator / GCD;
                Denominator = denominator / GCD;
            }
            catch (Exception ex)
            {
                throw new RationalNumbersExceptions("Wrong parameters. Try Again!");
            }
        }

        public RationalNumbers(int numerator)
        {
            GCD = Math.Abs(gcd(numerator, 1));
            Numerator = numerator / GCD;
            Denominator = 1;
        }

        public RationalNumbers()
        {
           
        }

        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {               
                // cannot have 0 denominator
                if (value == 0)
                {
                    throw new RationalNumbersExceptions("Wrong denominator, it cant be equals to 0 when nomirator isn't equals to 0");
                }

                // if denominator negative, invert sign
                else if (value < 0)
                {
                    _denominator = -value;
                    Numerator = -_numerator;
                }
                else
                {
                    _denominator = value;
                }
            }
        }

        public int GCD
        {
            get {
                return _gcd;
            }
            set {
                _gcd = value;
            }
        }


        // Method to find gcd-Euclidean algorithm
        private static int gcd(int pNumerator,int pDenominator)
        {
            if (pDenominator == 0)
                return pNumerator;

            return gcd(pDenominator, pNumerator % pDenominator);        
        }
            
        public override String ToString()
        {
            if (_denominator == 1)
                return _numerator.ToString();
            else
                return _numerator + "/" + _denominator;
        }

        public bool Equals(RationalNumbers r)
        {
            return (_numerator == r._numerator && _denominator == r._denominator);
        }

        public int CompareTo(object obj)
        {
            RationalNumbers r = (RationalNumbers)obj;

            int g = gcd(_denominator, r._denominator);

            int n1 = _numerator * r._denominator / g;
            int n2 = _denominator * r._numerator / g;

            // compare sthe two values
            // this is smaller
            if (n1 < n2)
                return -1;
            // o is smaller
            if (n1 > n2)
                return 1;

            return 0;
        }


      
        private RationalNumbers Add(RationalNumbers r)
        {
            return new RationalNumbers(Numerator * r.Denominator + r.Numerator * Denominator, Denominator * r.Denominator);
        }

        private RationalNumbers Subtract(RationalNumbers r)
        {
            return new RationalNumbers(Numerator * r.Denominator - r.Numerator * Denominator, Denominator * r.Denominator);
        }

        private RationalNumbers Multiply(RationalNumbers r)
        {
            return new RationalNumbers(Numerator * r.Numerator, Denominator * r.Denominator);
        }

        private RationalNumbers Divide(RationalNumbers r)
        {
            // flip second fraction and multiply
            return new RationalNumbers(Numerator * r.Denominator, Denominator * r.Numerator);
        }

        private RationalNumbers Module(RationalNumbers r)
        {
            return new RationalNumbers(Numerator % r.Numerator, Denominator % r.Denominator);
        }


        public static bool operator ==(RationalNumbers r1, RationalNumbers r2)
        {            
            return r1.Equals(r2);
        }

        public static bool operator !=(RationalNumbers r1, RationalNumbers r2)
        {
            return !r1.Equals(r2);
        }

        public static bool operator <(RationalNumbers r1, RationalNumbers r2)
        {
            return (r1.CompareTo(r2) < 0);
        }

        public static bool operator >(RationalNumbers r1, RationalNumbers r2)
        {
            return (r1.CompareTo(r2) > 0);
        }

        public static bool operator <=(RationalNumbers r1, RationalNumbers r2)
        {
            return !(r1.CompareTo(r2) > 0);
        }

        public static bool operator >=(RationalNumbers r1, RationalNumbers r2)
        {
            return !(r1.CompareTo(r2) < 0);
        }

        public static RationalNumbers operator ++(RationalNumbers r1)
        {
            r1.Numerator++;
            return new RationalNumbers(r1.Numerator, r1.Denominator); 
        }

        public static RationalNumbers operator --(RationalNumbers r1)
        {
            r1.Numerator--;
            return new RationalNumbers(r1.Numerator, r1.Denominator);
        }

        public static RationalNumbers operator +(RationalNumbers r1, RationalNumbers r2)
        {
            return r1.Add(r2);
        }

        public static RationalNumbers operator -(RationalNumbers r1, RationalNumbers r2)
        {
            return r1.Subtract(r2);
        }

        public static RationalNumbers operator *(RationalNumbers r1, RationalNumbers r2)
        {
            return r1.Multiply(r2);
        }

        public static RationalNumbers operator /(RationalNumbers r1, RationalNumbers r2)
        {
            return r1.Divide(r2);
        }

        public static RationalNumbers operator %(RationalNumbers r1, RationalNumbers r2)
        {
            return r1.Module(r2);
        }



        



        

        // overriding functions
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }     
}
