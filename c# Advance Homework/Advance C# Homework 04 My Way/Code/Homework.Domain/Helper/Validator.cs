

using Homework.Domain.Models;

namespace Homework.Domain.Helper
{
    public static class Validator
    {
        public static Vehicle Validate(Vehicle vehicle)
        {
            if(vehicle.Id == null || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction > 0)
            {
                Console.WriteLine("Success");
                return vehicle;
            }
            else
            {
                throw new Exception("Invalid inputs");
            }
        }
    }
}
