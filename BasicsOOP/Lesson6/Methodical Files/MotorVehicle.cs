using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Methodical_Files
{
    internal class MotorVehicle : Vehicle
    {
        private float _fuelRemaining;
        private float _tankSize;
        public float FuelRemaining
        {
            get { return _fuelRemaining; }
        }
        public float TankSize
        {
            get { return _tankSize; }
            set { _tankSize = value; }
        }
        public float Refuel()
        {
            float fuelRequired = _tankSize - _fuelRemaining;
            _fuelRemaining = _tankSize;
            return fuelRequired;
        }

        // or public new void
        public override void Indicate(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Flashing left indicator");
            else
                Console.WriteLine("Flashing right indicator");
        }
    }
}
