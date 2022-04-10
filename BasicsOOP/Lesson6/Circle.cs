using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    internal sealed class Circle : Point
    {
        private double _r;
        private const double pi = 3.14;

        // must to asign 
        public Circle(int x, int y,double Pr) : base(x,y)
        {
            R = Pr;
        }

        public double R
        {
            get => _r;
            set 
            {
                if (value > 0)
                    _r = value;
                else
                    _r = 0;
            }
        }

        public override double CalculateArea()
        {
            return pi * (_r + _r) * (_r + _r) / 4;
        }

        public override Type GetType()
        {
            return typeof(Circle);
        }
    }
}
