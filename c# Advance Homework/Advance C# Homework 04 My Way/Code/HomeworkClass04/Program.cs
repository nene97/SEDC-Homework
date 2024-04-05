using Homework.Domain.Helper;
using Homework.Domain.Models;
using Homework.Domain.Service;


VehicleService vehicleService = new VehicleService();
vehicleService.PrintVehicle(VehicleDb.Cars[0]);
vehicleService.PrintVehicle(VehicleDb.Cars[1]);
vehicleService.PrintVehicle(VehicleDb.Cars[2]);

vehicleService.PrintVehicle(VehicleDb.Bikes[1]);
vehicleService.PrintVehicle(VehicleDb.Bikes[0]);
vehicleService.PrintVehicle(VehicleDb.Bikes[2]);


Car valid = VehicleDb.Cars[0];
Validator.Validate(valid);