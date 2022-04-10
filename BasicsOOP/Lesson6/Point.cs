using Lesson6.Methodical_Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    internal abstract class Point : Figure, IArea
    {
        // set coordination of each figure
        public Point(int pX, int pY) : base (pX, pY)
        {
           
        }

        public virtual double CalculateArea(double Height, double Width)
        {
            throw new NotImplementedException();
        }

        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public new virtual Type GetType()
        {
            return typeof(Point);
        }

    }
}
