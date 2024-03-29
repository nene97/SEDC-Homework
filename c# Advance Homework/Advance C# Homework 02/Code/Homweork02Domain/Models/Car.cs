

using Homweork02Domain.Interfaces;

namespace Homweork02Domain.Models
{
    public class Car : Vehicle , IRepairService , ICarWash
    {
   
        public string DriverName { get; set; }

        public int TopSpeed { get; set; }   

        public Car(string type , string brand , string driverName , int speed ): base( type ,  brand)
        {
            
            DriverName = driverName;    
            TopSpeed = speed;
        }

        public override void Drive()
        {
            Console.WriteLine($"The brand is {BrandOfVehicle}, it is driven by {DriverName}, the top speed is {TopSpeed}");

        }

        public bool CheckVehicle(bool check)
        {
            if ( check )
            {
                Console.WriteLine($"the {BrandOfVehicle} is fine");
                return true;
            }
            else
            {
                Console.WriteLine($"the {BrandOfVehicle} is in need of repairs");
                return false;
             }
            
        }

        public bool FixVehicle(bool fix)
        {
            if ( fix )
            {
                Console.WriteLine("The vehicle is fixed");
                return true;
            }
            else
            {
                Console.WriteLine("The vehicle cant be fixed");
                return false;   
            }
        }

        public void WashCar(Car car)
        {
            Console.WriteLine($"The car is {car.BrandOfVehicle} and it is clean");
        }

        public void WashTrailer(Truck truck)
        {
            throw new Exception("You need a car for this");
        }
    }
}
