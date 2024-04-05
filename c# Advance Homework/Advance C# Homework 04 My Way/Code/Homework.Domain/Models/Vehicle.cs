

namespace Homework.Domain.Models
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public int YearOfProduction { get; set; }

        public int BatchNumber { get; set; }

        public Vehicle(int id , string type, int yearOfProd , int batch)
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProd;
            BatchNumber = batch;
        
        }

    }
}
