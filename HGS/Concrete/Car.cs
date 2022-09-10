using HGS.Abstract;
using HGS.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Concrete
{
    public class Car : Vehicle
    {

        public Car()
        {
            VehicleType = VehicleType.Car;
        }
    }
}
