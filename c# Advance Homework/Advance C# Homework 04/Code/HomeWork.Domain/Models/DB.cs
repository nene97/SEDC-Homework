

namespace HomeWork.Domain.Models
{
    public static class DB
    {
        public static List<Vehicle> Vehicles { get; set; }

        static DB()
        {
            Vehicles = new List<Vehicle>()
            {
                 new Car(50,new List<string> {"Macedonia" , "Usa"}, 111, "SUV" , 2024 , 15935788),
                 new Car(52,new List<string> {"England" , "Mexico"}, 222, "SEDAN" , 2020 , 369852),
                 new Car(55,new List<string> {"Australia" , "Japan"}, 333, "Van" , 2018 , 147852),
                 new Bike("Pink", 444 , "CityBike",2022 , 852963),
                 new Bike("Black", 555 , "Road Bike",2020 , 15938423),
                 new Bike("Yellow", 666 , "Mountain Bike",2017 , 226651),
                 new Vehicle(15146,"truck" ,2025 , 54644),
                 new Vehicle(15146,"Van" ,2012 , 4545445),
                 new Vehicle(15146,"Bus" ,0 , 4444)
            };

        }
    }
}
