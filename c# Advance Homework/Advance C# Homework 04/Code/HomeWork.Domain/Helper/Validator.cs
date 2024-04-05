

using HomeWork.Domain.Models;

namespace HomeWork.Domain.Helper
{
    public static class Validator
    {
        public static Vehicle Validate(Vehicle vehicle)
        {   
            if(vehicle.Id > 0 && vehicle.Type != null && vehicle.YearOfProduction > 0)
            {
                return vehicle;
            }else
            {
                throw new Exception("Wrong input");
            }

        }
    }
}
