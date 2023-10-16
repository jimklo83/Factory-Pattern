using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheels)
        {
            switch (wheels.ToLower())
            {
                case "4":
                case "four":
                case "2":
                case "two":

                    return new Car();

                default:
                   
                    return new Tractor();
            }
        }
    }
}
