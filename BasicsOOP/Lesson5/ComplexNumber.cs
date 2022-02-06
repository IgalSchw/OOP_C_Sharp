using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Lesson5
{
    internal class ComplexNumber
    {
        private double re;
        private double im;

        [Description("Constructor")]
        public ComplexNumber(double pRe, double pIm)
        {
            RE = pRe;
            IM = pIm;
        }

        public double RE
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }
        public double IM
        {
            get
            {
                return im;
            }

            set
            {
                im = value;
            }        
        }


        [Description("Overloaded binary + operator")]
        public static ComplexNumber operator +(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.RE + arg2.RE, arg1.RE + arg2.IM));
        }

        [Description("Overloaded unary - operator")]
        public static ComplexNumber operator -(ComplexNumber arg1)
        {
            return (new ComplexNumber(-arg1.RE, -arg1.IM));
        }

        [Description("Overloaded binary - operator")]
        public static ComplexNumber operator -(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.RE - arg2.RE, arg1.IM - arg2.IM));
        }

        [Description("Overloaded binary * operator")]
        public static ComplexNumber operator *(ComplexNumber arg1, ComplexNumber arg2)
        {
            return (new ComplexNumber(arg1.RE * arg2.RE - arg1.IM * arg2.IM, arg1.RE * arg2.IM + arg2.RE * arg1.IM));
        }

        [Description("Overloaded binary / operator")]
        public static ComplexNumber operator /(ComplexNumber arg1, ComplexNumber arg2)
        {
            double c1, c2, d;
            d = arg2.RE * arg2.RE + arg2.IM * arg2.IM;
            if (d == 0)
            {
                return (new ComplexNumber(0, 0));
            }
            c1 = arg1.RE * arg2.RE + arg1.IM * arg2.IM;
            c2 = arg1.IM * arg2.RE - arg1.RE * arg2.IM;
            return (new ComplexNumber(c1 / d, c2 / d));
        }

        [Description("Argument of a complex number in degree. Usage: c.Arg()")]
        public double Arg()
        {
            double ret = 0;
            if (RE != 0)
                ret = (180 / Math.PI) * Math.Atan(IM / RE);
            return (ret);
        }

        [Description("Absolute value of a complex number. Usage: c.Abs()")]
        public double Abs()
        {
            return (Math.Sqrt(RE * RE + IM * IM));
        }

        [Description("Overridden ToString. Usage: c.toString()")]
        public override string ToString()
        {
            return (String.Format("Complex: ({0}, {1})", RE, IM));
        }
    }
}
