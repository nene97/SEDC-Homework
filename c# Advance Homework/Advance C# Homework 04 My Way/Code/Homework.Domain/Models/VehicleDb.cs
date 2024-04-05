
namespace Homework.Domain.Models
{
    public static class VehicleDb
    {
        public static List<Vehicle> Vehicles { get; set; }

        public static List<Car> Cars { get; set; }

        public static List<Bike> Bikes { get; set; }

        static VehicleDb()
        {
            Vehicles = new List<Vehicle>(); 

            Cars = new List<Car>()
            {
                new Car(50,new List<string> {"Macedonia" , "Usa"}, 111, "SUV" , 2024 , 15935788),
                new Car(50,new List<string> {"England" , "Mexico"}, 222, "SEDAN" , 2020 , 369852),
                new Car(50,new List<string> {"Australia" , "Japan"}, 333, "Van" , 2018 , 147852)

            }; 
            Bikes = new List<Bike>()
            {
               new Bike("Pink", 444 , "CityBike",2022 , 852963),
               new Bike("Black", 555 , "Road Bike",2020 , 15938423),
               new Bike("Yellow", 666 , "Mountain Bike",2017 , 226651),

            };
            Vehicles.Add(Cars[0]);
            Vehicles.Add(Cars[1]);
            Vehicles.Add(Cars[2]);

            Vehicles.Add(Bikes[0]);
            Vehicles.Add(Bikes[1]);
            Vehicles.Add(Bikes[2]);





        }
    }
}
