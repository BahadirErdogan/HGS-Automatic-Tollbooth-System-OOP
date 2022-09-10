using HGS.Concrete;
using System;

namespace HGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HGS Management Test");

            Car car = new Car();
            car.Id = 1;
            car.HgsNo = "10";
            car.OwnerFirstName = "John";
            car.OwnerLastName = "Doe";
            car.Brand = "Brand";
            car.Model = "Model X";
            car.Color = "White";
            car.LicencePlate = "22AA2222";
            car.AccountBalance = 1000;

            Minibus minibus = new Minibus();
            minibus.Id = 2;
            minibus.HgsNo = "20";
            minibus.OwnerFirstName = "Jeyn";
            minibus.OwnerLastName = "Doe";
            minibus.Brand = "Brand";
            minibus.Model = "Model Y";
            minibus.Color = "Blue";
            minibus.LicencePlate = "11AA1111";
            minibus.AccountBalance = 1000;

            Bus bus = new Bus();
            bus.Id = 3;
            bus.HgsNo = "30";
            bus.OwnerFirstName = "Jennifer";
            bus.OwnerLastName = "Doe";
            bus.Brand = "Brand";
            bus.Model = "Model Z";
            bus.Color = "Red";
            bus.LicencePlate = "33AA3333";
            bus.AccountBalance = 1000;


            TollBooth tollBooth = new TollBooth();
            tollBooth.Id = 1;
            tollBooth.Bridge = Enum.Bridge.FirstBridge;
            tollBooth.PriceCar = 20;
            tollBooth.PriceMinibus = 25;
            tollBooth.PriceBus = 35;

            try
            {
                Console.WriteLine($"Before Passage : {car.LicencePlate} , {car.VehicleType} , Account Balance:{car.AccountBalance}");
                tollBooth.CollectPayment(car);
                Console.WriteLine($"After Passage : {car.LicencePlate} , {car.VehicleType} , Account Balance:{car.AccountBalance}");

                Console.WriteLine($"Before Passage : {minibus.LicencePlate} , {minibus.VehicleType} , Account Balance:{minibus.AccountBalance}");
                tollBooth.CollectPayment(minibus);
                Console.WriteLine($"After Passage : {minibus.LicencePlate} , {minibus.VehicleType} , Account Balance:{minibus.AccountBalance}");

                Console.WriteLine($"Before Passage : {bus.LicencePlate} , {bus.VehicleType} , Account Balance:{bus.AccountBalance}");
                tollBooth.CollectPayment(bus);
                Console.WriteLine($"After Passage : {bus.LicencePlate} , {bus.VehicleType} , Account Balance:{bus.AccountBalance}");

                Console.WriteLine($"Before Passage : {bus.LicencePlate} , {bus.VehicleType} , Account Balance:{bus.AccountBalance}");
                tollBooth.CollectPayment(bus);
                Console.WriteLine($"After Passage : {bus.LicencePlate} , {bus.VehicleType} , Account Balance:{bus.AccountBalance}");

                tollBooth.GetDailyEarn(new DateTime(2022, 09, 09));
                tollBooth.GetDailyEarn(DateTime.Now.Date);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message : " + ex.Message);
                throw;
            }

            Console.ReadLine();

        }
    }
}
