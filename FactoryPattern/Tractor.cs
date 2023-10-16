using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Tractor : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("You are a trucker!");
        }
    }
}
