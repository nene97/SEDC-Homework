using HomeWork.Domain.Helper;
using HomeWork.Domain.Models;


DB.Vehicles[0].PrintVehicle();
DB.Vehicles[1].PrintVehicle();
DB.Vehicles[2].PrintVehicle();
DB.Vehicles[3].PrintVehicle();
DB.Vehicles[4].PrintVehicle();
DB.Vehicles[5].PrintVehicle();
DB.Vehicles[6].PrintVehicle();
DB.Vehicles[7].PrintVehicle();
DB.Vehicles[8].PrintVehicle();

Validator.Validate(DB.Vehicles[0]);
Validator.Validate(DB.Vehicles[1]);
Validator.Validate(DB.Vehicles[2]);
Validator.Validate(DB.Vehicles[3]);
Validator.Validate(DB.Vehicles[4]);
Validator.Validate(DB.Vehicles[5]);
Validator.Validate(DB.Vehicles[6]);
Validator.Validate(DB.Vehicles[7]);
Validator.Validate(DB.Vehicles[8]);//Throws an error cuz the yearOfProduction is 0;