using HGS.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Abstract
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string HgsNo { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string LicencePlate { get; set; }
        public VehicleType VehicleType { get; set; }
        public decimal AccountBalance { get; set; }

    }
}
