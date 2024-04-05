

namespace HomeWork.Domain.Models
{
    internal class Car : Vehicle
    {
        public int FuelTank { get; set; }

        public List<string> CountriesOfProduction { get; set; }

        public Car(int fuelTank, List<string> countriesOfProduction , int id, string type, int yearOfProduction, int batchNumber):base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            CountriesOfProduction = countriesOfProduction;
        }
        public override void PrintVehicle()
        {
            Console.WriteLine($"The type of the car is {Type} and it is produced in:");

            for (int i = 0; i < CountriesOfProduction.Count; i++)
            {
                Console.WriteLine(CountriesOfProduction[i]);
            }
        }
    }
}
