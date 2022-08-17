using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Interview
{
    class Sportcar:Auto
    {
        public override void SetAuto(TypeOfAuto _type, double _averageFuelConsuming, double _fuelTank, double _speed)
        {
            type = _type;
            averageFuelConsuming = _averageFuelConsuming;
            fuelTank = _fuelTank;
            speed = _speed;
            
        }
        public void GetAuto()
        {
            Console.WriteLine(speed+" "+ type);
        }
        public override double GetPossibleDistance(bool full, double fuel) => (full) ? fuelTank / averageFuelConsuming * 100 : fuel / averageFuelConsuming * 100;
       
    }
}
