using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Interview
{
    public static class Menu
    {
        /// <summary>
        /// Показать меню
        /// </summary>
        public static int ShowMenu()
        {
            Console.WriteLine(@"1. Текущая информация о состоянии запаса хода
2. Расчет времени на растояние");
            return Convert.ToInt32(Console.ReadLine());

        }
        public static void GetTime(object auto)
        {
            Console.WriteLine("Введите дистанцию (км): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            object[] par = new object[] {  distance };
            MethodInfo m = auto.GetType().GetMethod("GetTime");
            Console.WriteLine("\nПредположительное время = " + Math.Round(Convert.ToDouble(m.Invoke(auto, par)), 2)+" ч");
            Console.ReadKey();
        }

         public static void GetPossibleDistance(object auto)
        {

            Console.WriteLine("Полный бак? (y - Да,n - Нет)");
            ConsoleKeyInfo c = Console.ReadKey();
            bool full = false;
            double fuel = 0;
            double max = (auto as Auto).GetFuelTank();
            if (c.Key == ConsoleKey.Y)
            {
                full = true;
            }
            else
            {
                do {
                    Console.Clear();
                    Console.WriteLine($"Введите количество топлива ( не больше {max})");
                    
                    fuel = Convert.ToDouble(Console.ReadLine());
                }while (fuel > max) ;
            }
            object[] par = new object[] { full, fuel };
            MethodInfo m = auto.GetType().GetMethod("GetPossibleDistance");
            Console.WriteLine("\nТекущий запас хода = "+ Math.Round(Convert.ToDouble(m.Invoke(auto, par)),2)+" км");
            Console.ReadKey();
        }

        public static object SetAuto()
        {
            Console.WriteLine("Тип ТС (1 - Спортивный автомобиль, 2 - Легковой автомобиль, 3 - Грузовой автомобиль)");
            int typeOfAuto = Convert.ToInt32(Console.ReadLine());
            object auto = null;
            switch (typeOfAuto)
            {
                case 1:
                    auto =  SetSportcar();
                    //MethodInfo m= auto.GetType().GetMethod("");
                    //m.Invoke(auto, null);
                    break;
                case 2:
                    auto= SetTransport();
                    break;
                case 3:
                    auto=SetTruck();
                    break;
            }
            return auto;
        }
        private static Sportcar SetSportcar()
        {
            Sportcar auto = new Sportcar();
            TypeOfAuto type = 0;
            double averageFuelConsuming;
            double fuelTank;
            double speed;
            Console.WriteLine("Введите среднее потребление топлива (л): ");
            averageFuelConsuming = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите объем топливного бака (л): ");
            fuelTank = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость автомобиля (км/ч): ");
            speed = Convert.ToDouble(Console.ReadLine());
            auto.SetAuto(type, averageFuelConsuming, fuelTank, speed);
            return auto;
        }
        private static Truck SetTruck()
        {
            Truck auto = new Truck();
            TypeOfAuto type = 0;
            double averageFuelConsuming;
            double fuelTank;
            double speed;
            double currentMass;
            double maxLift;
            Console.WriteLine("Введите среднее потребление топлива (л): ");
            averageFuelConsuming = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите объем топливного бака (л): ");
            fuelTank = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость автомобиля (км/ч): ");
            speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите максимальную грузоподъемность (кг): ");
            maxLift = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine($"Введите текущий вес груза (не больше {maxLift})");
                currentMass = Convert.ToDouble(Console.ReadLine());
            } 
            while (currentMass > maxLift);
            auto.SetAuto(type, averageFuelConsuming, fuelTank, speed, currentMass,maxLift);
            return auto;
        }
        private static Transport SetTransport()
        {
            Transport auto = new Transport();
            TypeOfAuto type = 0;
            double averageFuelConsuming;
            double fuelTank;
            double speed;
            int countSpot;
            int countPeople;
            Console.WriteLine("Введите среднее потребление топлива (л): ");
            averageFuelConsuming = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите объем топливного бака (л): ");
            fuelTank = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость автомобиля (км/ч): ");
            speed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество пассажирских мест: ");
            countSpot = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine($"Введите количество пассажиров (не больше {countSpot})");
                countPeople = Convert.ToInt32(Console.ReadLine());
            } while(countPeople > countSpot);
           
            auto.SetAuto(type, averageFuelConsuming, fuelTank, speed, countSpot, countPeople);
            return auto;
        }
    }
}
