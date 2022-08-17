using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Interview
{  
    public enum TypeOfAuto
{
    sportcar = 0,
    truck= 1,
    passengerCar = 2
} 
    public  class Auto
    {
        protected TypeOfAuto type;
        protected double averageFuelConsuming;
        protected double fuelTank;
        protected double speed;

        public double GetFuelTank() => fuelTank;
        public virtual void SetAuto(TypeOfAuto _type, double _averageFuelConsuming, double _fuelTank, double _speed, int _countSpot, int _countPeople)
        {

        }
        public virtual void SetAuto(TypeOfAuto _type, double _averageFuelConsuming, double _fuelTank, double _speed)
        {
           

        }
        public virtual void SetAuto(TypeOfAuto _type, double _averageFuelConsuming, double _fuelTank, double _speed, double _currentMass, double _maxLift)
        {

        }
        public virtual double GetPossibleDistance(bool full, double fuel)
        {
            return (full) ? fuelTank/averageFuelConsuming*100 : fuel/averageFuelConsuming*100;
        }
        public double GetTime( double distance)
        {
            
            return distance / speed;
        }
       
    }
}
