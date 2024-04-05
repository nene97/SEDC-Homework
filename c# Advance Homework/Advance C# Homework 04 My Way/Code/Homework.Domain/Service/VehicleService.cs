

using Homework.Domain.Models;

namespace Homework.Domain.Service
{
    public class VehicleService
    {
        public void PrintVehicle(Car car)
        {
            Console.WriteLine($"The car  is {car.Type} and it is produced in :");

           for (int i = 0; i < car.CountriesOfProduction.Count; i++)
            {
                Console.WriteLine(car.CountriesOfProduction[i]);
            }
        }

        public void PrintVehicle(Bike bike)
        {
            Console.WriteLine($"the bike is produced in the year {bike.YearOfProduction} and it is {bike.Color} ");
        }
    }
}
