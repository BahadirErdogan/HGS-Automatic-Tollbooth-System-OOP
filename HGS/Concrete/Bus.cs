using HGS.Abstract;
using HGS.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HGS.Concrete
{
    public class Bus : Vehicle 
    {
        public Bus()
        {
            VehicleType = VehicleType.Bus;
        }
    }
}
