using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Methodical_Files
{
    internal class Vehicle
    {
        private int _speed;
        public int Speed { get { return _speed; } }
        public void Accelerate(int mph) { _speed += mph; }
        public void Decelerate(int mph) { _speed -= mph; }

        public virtual void Indicate(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Turning left");
            else
                Console.WriteLine("Turning right");
        }
    }
}
