

namespace HomeWork.Domain.Models
{
    internal class Bike : Vehicle
    {
        public string Color { get; set; }
        public Bike(string color , int id, string type, int yearOfProduction, int batchNumber) : base(id, type, yearOfProduction, batchNumber)
        {
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"the bike is produced in the year of {YearOfProduction} and it is {Color} ");
        }
    }
}
