using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Interview
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             
            object auto =Menu.SetAuto();
            while (true)
            {
                Console.Clear();
                int choise = Menu.ShowMenu();
                switch (choise)
                {
                    case 1:
                        Menu.GetPossibleDistance(auto);
                        break;
                        case 2:
                        Menu.GetTime(auto);
                        break;
                }
            }
            
           
            
        }
    }
}
