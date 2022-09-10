using HGS.Abstract;
using HGS.Enum;
using HGS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HGS.Concrete
{
    public class TollBooth : ICollect
    {
        public TollBooth()
        {
            Logs = new List<Log>();
        }
        public int Id { get; set; }
        public Bridge Bridge { get; set; }
        public decimal PriceCar { get; set; }
        public decimal PriceMinibus { get; set; }
        public decimal PriceBus { get; set; }
        List<Log> Logs { get; set; }

        /// <summary>
        /// Collects payment from vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        public void CollectPayment(Vehicle vehicle)
        {

            switch (vehicle.VehicleType)
            {
                case VehicleType.Car:
                    if (vehicle.AccountBalance <= PriceCar)
                        throw new Exception("Insufficient Balance");
                    else
                    {
                        vehicle.AccountBalance -= PriceCar;
                        SaveToLog(vehicle);
                    }
                    break;

                case VehicleType.Minibus:
                    if (vehicle.AccountBalance <= PriceMinibus)
                        throw new Exception("Insufficient Balance");
                    else
                    {
                        vehicle.AccountBalance -= PriceMinibus;
                        SaveToLog(vehicle);
                    }
                    break;

                case VehicleType.Bus:
                    if (vehicle.AccountBalance <= PriceBus)
                        throw new Exception("Insufficient Balance");
                    else
                    {
                        vehicle.AccountBalance -= PriceMinibus;
                        SaveToLog(vehicle);
                    }
                    break;

                default:
                    throw new Exception("Undefined Vehicle Type");

            }
        }

        /// <summary>
        /// It calculates total income according to date parameter and print it to screen 
        /// </summary>
        /// <param name="date"></param>
        public void GetDailyEarn(DateTime date)
        {
            if(date <= DateTime.Now.Date)
            {
                decimal dailyTotal = Logs.Where(x => x.TransitTime.Date == date.Date).Sum(x => x.PassagePrice);
                Console.WriteLine($"{date} Total Income : {dailyTotal}");
            }
            else
                throw new Exception("Date value cannot be a future date");
        }

        /// <summary>
        /// Creates Log Object and save passage informations to List<Log> Logs
        /// </summary>
        /// <param name="vehicle"></param>
        public void SaveToLog(Vehicle vehicle)
        {
            decimal price;

            //Defines price according to VehicleType
            switch (vehicle.VehicleType)
            {
                case VehicleType.Car:
                    price = PriceCar;
                    break;
                case VehicleType.Minibus:
                    price = PriceMinibus;
                    break;
                case VehicleType.Bus:
                    price = PriceBus;
                    break;
                default:
                    throw new Exception("Invalid Vehicle Type");
            }

            Log log = new Log();
            log.HgsNo = vehicle.HgsNo;
            log.PassagePrice = price;
            log.TransitTime = DateTime.Now;
            Logs.Add(log);
        }
    }
}
