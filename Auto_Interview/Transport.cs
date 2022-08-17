using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Interview
{
     class Transport : Auto
    {
        public int countSpot;
        int countPeople=0;
        public override void SetAuto(TypeOfAuto _type, double _averageFuelConsuming, double _fuelTank, double _speed,int _countSpot,int _countPeople)
        {
            type = _type;
            averageFuelConsuming = _averageFuelConsuming;
            fuelTank = _fuelTank;
            speed = _speed;
            countPeople = _countPeople;
            countSpot = _countSpot;
        }
 
        public override double GetPossibleDistance(bool full, double fuel)
        {
            return (full) ? (fuelTank / averageFuelConsuming * 100)*(1-(countPeople*0.06f)) : (fuel / averageFuelConsuming * 100) * (1 - (countPeople * 0.06f));
        }
    }
}
