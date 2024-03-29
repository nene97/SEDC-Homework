

namespace Homweork02Domain.Models
{
    public abstract class Vehicle
    {
        public string TypeOfVehicle { get; set; }

        public string BrandOfVehicle { get; set; }
       
        public Vehicle(string type , string brand) 
        {
            TypeOfVehicle = type;
            BrandOfVehicle = brand;
        }
        public abstract void Drive();
    }
}
