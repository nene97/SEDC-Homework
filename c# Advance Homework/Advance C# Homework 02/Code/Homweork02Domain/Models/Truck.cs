using Homweork02Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homweork02Domain.Models
{
    public class Truck : Vehicle, IGasPump
    {
        public bool IsElectric { get; set; }

        public Truck(string type, string brand , bool isElectric): base(type , brand)
        {
            IsElectric = IsElectric;
        }

        public override void Drive()
        {
            Console.WriteLine("The truck is driving");
        }

        public bool PumpGas(bool pump)
        {
            if(pump)
            {
                Console.WriteLine("Your tank is full");
                    return true;    
            }
            else
            {
                Console.WriteLine("The tank is empty");
                return false;
            }
        }
    }
}
