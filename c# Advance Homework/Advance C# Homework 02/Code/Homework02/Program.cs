using Homweork02Domain.Models;

Car carOne = new Car("Sedan", "BMW" , "Bosko B" , 260);
Car carTwo = new Car("SUV", " Honda", "Nikola N", 198);

Truck truck = new Truck("Box Truck", "Volvo", true);

Truck truckTwo = new Truck("Semi", "Ford", false);

carOne.FixVehicle(true);
carTwo.FixVehicle(false);

carOne.WashCar(carOne);
//carTwo.WashCar(truck); wont work because of type Truck

truck.Drive();
truckTwo.Drive();

truck.PumpGas(true);
truckTwo.PumpGas(false);

CarCenter center = new CarCenter("Milenium", "Ul 101 BB 55" , carOne ,truck);
CarCenter centerTwo = new CarCenter("AMSM", "Some Addres", carTwo, truckTwo);


Console.WriteLine("=====================");
center.FixVehicle(true , carTwo);
centerTwo.FixVehicle(false , carOne);
center.WashTrailer(truck);
centerTwo.WashTrailer(truckTwo);
center.PumpGas(false , carOne);
centerTwo.PumpGas(true , carTwo);
center.CheckVehicle(true ,truck);
centerTwo.CheckVehicle(false , carOne);  

  