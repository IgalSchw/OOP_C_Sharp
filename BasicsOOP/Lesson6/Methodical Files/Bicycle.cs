using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Methodical_Files
{
    internal sealed class Bicycle : Vehicle
    {
        public void RingBell()
        {
            Console.WriteLine("Ring!");
        }

        public override void Indicate(bool turningLeft)
        {
            base.Indicate(turningLeft); // call base class for turning left

            if (turningLeft)
                Console.WriteLine("Raising left arm");
            else
                Console.WriteLine("Raising right arm");
        }
    }
}
