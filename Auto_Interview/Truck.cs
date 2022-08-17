using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Interview
{
     class Truck:Auto
    {
        public double currentMass;
        double maxLift;
        public override void SetAuto(TypeOfAuto _type, double _averageFuelConsuming, double _fuelTank, double _speed, double _currentMass, double _maxLift)
        {
            type = _type;
            averageFuelConsuming = _averageFuelConsuming;
            maxLift = _maxLift;
            fuelTank = _fuelTank;
            speed = _speed;
            currentMass = _currentMass;
        }

        public override double GetPossibleDistance(bool full, double fuel)
        {
            return (full) ? (fuelTank / averageFuelConsuming * 100) * (1 - (currentMass/200 * 0.04f)) : (fuel / averageFuelConsuming * 100) * (1 - (currentMass/200 * 0.04f));
        }
        
    }
}
