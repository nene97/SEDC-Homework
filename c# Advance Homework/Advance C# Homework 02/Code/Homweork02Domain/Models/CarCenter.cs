

using Homweork02Domain.Interfaces;

namespace Homweork02Domain.Models
{
    public class CarCenter : IRepairService, IGasPump, ICarWash
    {
        public string CarCenterName { get; set; }

        public string Addres { get; set; }  

        public Car Car { get; set; }

        public Truck Truck { get; set; }

        public CarCenter(string nameOfCenter , string addres , Car car , Truck truck) 
        { 
            CarCenterName = nameOfCenter;
            Addres = addres;    
            Car = car;
            Truck = truck;  
        }  


        public bool CheckVehicle(bool check , Car car)
        {
            if (check) 
            {
                Console.WriteLine($"The vehicle of type {Car.TypeOfVehicle} is fine");
                return true;
            }
            else
            {

                Console.WriteLine($"The vehicle of type {Car.TypeOfVehicle} is in need of rapair");
                return false;
            }
        }

        public bool CheckVehicle(bool check, Truck truck)
        {
            if (check)
            {
                Console.WriteLine($"The vehicle of type {Truck.TypeOfVehicle} is fine");
                return true;
            }
            else
            {

                Console.WriteLine($"The vehicle of type {Truck.TypeOfVehicle} is in need of repair");
                return false;
            }
        }

        public bool FixVehicle(bool fix , Car car)
        {
            if (fix) 
            {
                 Console.WriteLine($"The vehicle of type {Car.TypeOfVehicle} is fixed");
                
                return true;
            }
            else
            {
                Console.WriteLine($"The vehicle of type {Car.TypeOfVehicle} is not fixed");
             
                return false;
            }
        }
        public bool FixVehicle(bool fix, Truck truck)
        {
            if (fix)
            {
                Console.WriteLine($"The vehicle of type {Truck.TypeOfVehicle} is fixed");

                return true;
            }
            else
            {
                Console.WriteLine($"The vehicle of type {Truck.TypeOfVehicle} is not fixed");

                return false;
            }
        }

        public bool PumpGas(bool pump , Car car)
        {
            if(pump)
            {
                Console.WriteLine($"You have a full tank on the {Car.BrandOfVehicle} no need of gas");
                return true;
            }
            else 
            {
                Console.WriteLine($"Your tank is  on the {Car.BrandOfVehicle} empty you need gas");
                return false;
            }
        }
        public bool PumpGas(bool pump, Truck truck)
        {
            if (pump)
            {
                Console.WriteLine($"You have a full tank on the {Truck.BrandOfVehicle} no need of gas");
                return true;
            }
            else
            {
                Console.WriteLine($"Your tank is  on the {Truck.BrandOfVehicle} empty you need gas");
                return false;
            }
        }

        public void WashCar(Car car)
        {
            Console.WriteLine($"The car {Car.BrandOfVehicle} is now clean......");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"The car {Truck.BrandOfVehicle} is now clean.....!!!.");

        }

        public bool FixVehicle(bool fix)
        {
            throw new NotImplementedException();
        }

        public bool PumpGas(bool pump)
        {
            throw new NotImplementedException();
        }

        public bool CheckVehicle(bool check)
        {
            throw new NotImplementedException();
        }
    }
}
