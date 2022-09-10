using HGS.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Concrete
{
    public class Log
    {
        public string HgsNo { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        public decimal PassagePrice { get; set; }
        public DateTime TransitTime { get; set; }
    }
}
