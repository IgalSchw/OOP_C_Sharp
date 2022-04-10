using Lesson6.Methodical_Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    internal sealed class Rectangle : Point
    {       
        public Rectangle(int x, int y) : base(x,y)
        {
            
        }
        public override double CalculateArea()
        {
            return X * Y;
        }

        public override Type GetType()
        {
            return typeof(Rectangle);
        }
    }
}
