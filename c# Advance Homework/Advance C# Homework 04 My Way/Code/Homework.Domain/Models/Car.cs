
namespace Homework.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesOfProduction{ get; set; }

        public Car(int fuel , List<string>production , int id , string type , int yearOfProd, int batch):base(id , type , yearOfProd, batch)
        { 
            FuelTank = fuel;
            CountriesOfProduction = production;

        
        }    
    }
}
