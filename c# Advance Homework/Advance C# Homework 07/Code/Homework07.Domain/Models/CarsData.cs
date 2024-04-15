﻿

namespace Homework07.Domain.Models
{
    public static class CarsData
    {
        public static List<Car> Cars = new List<Car>();

        static CarsData()
        {
            LoadCars();
        }


        public static void LoadCars()
        {
            Cars = new List<Car>()
            
                {
                        new Car() { Model = "Chevrolet Chevelle Malibu", MilesPerGalon = 18, AccelerationTime = 12, Cylinders = 8, HorsePower = 130, Origin = "US", Weight = 3504 },
new Car() { Model = "Buick Skylark 320", MilesPerGalon = 15, AccelerationTime = 11.5, Cylinders = 8, HorsePower = 165, Origin = "US", Weight = 3693 },
new Car() { Model = "Plymouth Satellite", MilesPerGalon = 18, AccelerationTime = 11, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3436 },
new Car() { Model = "AMC Rebel SST", MilesPerGalon = 16, AccelerationTime = 12, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3433 },
new Car() { Model = "Ford Torino", MilesPerGalon = 17, AccelerationTime = 10.5, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 3449 },
new Car() { Model = "Ford Galaxie 500", MilesPerGalon = 15, AccelerationTime = 10, Cylinders = 8, HorsePower = 198, Origin = "US", Weight = 4341 },
new Car() { Model = "Chevrolet Impala", MilesPerGalon = 14, AccelerationTime = 9, Cylinders = 8, HorsePower = 220, Origin = "US", Weight = 4354 },
new Car() { Model = "Plymouth Fury iii", MilesPerGalon = 14, AccelerationTime = 8.5, Cylinders = 8, HorsePower = 215, Origin = "US", Weight = 4312 },
new Car() { Model = "Pontiac Catalina", MilesPerGalon = 14, AccelerationTime = 10, Cylinders = 8, HorsePower = 225, Origin = "US", Weight = 4425 },
new Car() { Model = "AMC Ambassador DPL", MilesPerGalon = 15, AccelerationTime = 8.5, Cylinders = 8, HorsePower = 190, Origin = "US", Weight = 3850 },
new Car() { Model = "Citroen DS-21 Pallas", MilesPerGalon = 0, AccelerationTime = 17.5, Cylinders = 4, HorsePower = 115, Origin = "Europe", Weight = 3090 },
new Car() { Model = "Chevrolet Chevelle Concours (sw)", MilesPerGalon = 0, AccelerationTime = 11.5, Cylinders = 8, HorsePower = 165, Origin = "US", Weight = 4142 },
new Car() { Model = "Ford Torino (sw)", MilesPerGalon = 0, AccelerationTime = 11, Cylinders = 8, HorsePower = 153, Origin = "US", Weight = 4034 },
new Car() { Model = "Plymouth Satellite (sw)", MilesPerGalon = 0, AccelerationTime = 10.5, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 4166 },
new Car() { Model = "AMC Rebel SST (sw)", MilesPerGalon = 0, AccelerationTime = 11, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 3850 },
new Car() { Model = "Dodge Challenger SE", MilesPerGalon = 15, AccelerationTime = 10, Cylinders = 8, HorsePower = 170, Origin = "US", Weight = 3563 },
new Car() { Model = "Plymouth 'Cuda 340", MilesPerGalon = 14, AccelerationTime = 8, Cylinders = 8, HorsePower = 160, Origin = "US", Weight = 3609 },
new Car() { Model = "Ford Mustang Boss 302", MilesPerGalon = 0, AccelerationTime = 8, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 3353 },
new Car() { Model = "Chevrolet Monte Carlo", MilesPerGalon = 15, AccelerationTime = 9.5, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3761 },
new Car() { Model = "Buick Estate Wagon (sw)", MilesPerGalon = 14, AccelerationTime = 10, Cylinders = 8, HorsePower = 225, Origin = "US", Weight = 3086 },
new Car() { Model = "Toyota Corolla Mark ii", MilesPerGalon = 24, AccelerationTime = 15, Cylinders = 4, HorsePower = 95, Origin = "Japan", Weight = 2372 },
new Car() { Model = "Plymouth Duster", MilesPerGalon = 22, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 95, Origin = "US", Weight = 2833 },
new Car() { Model = "AMC Hornet", MilesPerGalon = 18, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 97, Origin = "US", Weight = 2774 },
new Car() { Model = "Ford Maverick", MilesPerGalon = 21, AccelerationTime = 16, Cylinders = 6, HorsePower = 85, Origin = "US", Weight = 2587 },
new Car() { Model = "Datsun PL510", MilesPerGalon = 27, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 88, Origin = "Japan", Weight = 2130 },
new Car() { Model = "Volkswagen 1131 Deluxe Sedan", MilesPerGalon = 26, AccelerationTime = 20.5, Cylinders = 4, HorsePower = 46, Origin = "Europe", Weight = 1835 },
new Car() { Model = "Peugeot 504", MilesPerGalon = 25, AccelerationTime = 17.5, Cylinders = 4, HorsePower = 87, Origin = "Europe", Weight = 2672 },
new Car() { Model = "Audi 100 LS", MilesPerGalon = 24, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 90, Origin = "Europe", Weight = 2430 },
new Car() { Model = "Saab 99e", MilesPerGalon = 25, AccelerationTime = 17.5, Cylinders = 4, HorsePower = 95, Origin = "Europe", Weight = 2375 },
new Car() { Model = "BMW 2002", MilesPerGalon = 26, AccelerationTime = 12.5, Cylinders = 4, HorsePower = 113, Origin = "Europe", Weight = 2234 },
new Car() { Model = "AMC Gremlin", MilesPerGalon = 21, AccelerationTime = 15, Cylinders = 6, HorsePower = 90, Origin = "US", Weight = 2648 },
new Car() { Model = "Ford F250", MilesPerGalon = 10, AccelerationTime = 14, Cylinders = 8, HorsePower = 215, Origin = "US", Weight = 4615 },
new Car() { Model = "Chevy C20", MilesPerGalon = 10, AccelerationTime = 15, Cylinders = 8, HorsePower = 200, Origin = "US", Weight = 4376 },
new Car() { Model = "Dodge D200", MilesPerGalon = 11, AccelerationTime = 13.5, Cylinders = 8, HorsePower = 210, Origin = "US", Weight = 4382 },
new Car() { Model = "Hi 1200D", MilesPerGalon = 9, AccelerationTime = 18.5, Cylinders = 8, HorsePower = 193, Origin = "US", Weight = 4732 },
new Car() { Model = "Datsun PL510", MilesPerGalon = 27, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 88, Origin = "Japan", Weight = 2130 },
new Car() { Model = "Chevrolet Vega 2300", MilesPerGalon = 28, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 90, Origin = "US", Weight = 2264 },
new Car() { Model = "Toyota Corolla", MilesPerGalon = 25, AccelerationTime = 14, Cylinders = 4, HorsePower = 95, Origin = "Japan", Weight = 2228 },
new Car() { Model = "Ford Pinto", MilesPerGalon = 25, AccelerationTime = 19, Cylinders = 4, HorsePower = 0, Origin = "US", Weight = 2046 },
new Car() { Model = "Volkswagen Super Beetle 117", MilesPerGalon = 0, AccelerationTime = 20, Cylinders = 4, HorsePower = 48, Origin = "Europe", Weight = 1978 },
new Car() { Model = "AMC Gremlin", MilesPerGalon = 19, AccelerationTime = 13, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 2634 },
new Car() { Model = "Plymouth Satellite Custom", MilesPerGalon = 16, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 105, Origin = "US", Weight = 3439 },
new Car() { Model = "Chevrolet Chevelle Malibu", MilesPerGalon = 17, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3329 },
new Car() { Model = "Ford Torino 500", MilesPerGalon = 19, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 88, Origin = "US", Weight = 3302 },
new Car() { Model = "AMC Matador", MilesPerGalon = 18, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3288 },
new Car() { Model = "Chevrolet Impala", MilesPerGalon = 14, AccelerationTime = 12, Cylinders = 8, HorsePower = 165, Origin = "US", Weight = 4209 },
new Car() { Model = "Pontiac Catalina Brougham", MilesPerGalon = 14, AccelerationTime = 11.5, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 4464 },
new Car() { Model = "Ford Galaxie 500", MilesPerGalon = 14, AccelerationTime = 13.5, Cylinders = 8, HorsePower = 153, Origin = "US", Weight = 4154 },
new Car() { Model = "Plymouth Fury iii", MilesPerGalon = 14, AccelerationTime = 13, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4096 },
new Car() { Model = "Dodge Monaco (sw)", MilesPerGalon = 12, AccelerationTime = 11.5, Cylinders = 8, HorsePower = 180, Origin = "US", Weight = 4955 },
new Car() { Model = "Ford Country Squire (sw)", MilesPerGalon = 13, AccelerationTime = 12, Cylinders = 8, HorsePower = 170, Origin = "US", Weight = 4746 },
new Car() { Model = "Pontiac Safari (sw)", MilesPerGalon = 13, AccelerationTime = 12, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 5140 },
new Car() { Model = "AMC Hornet Sportabout (sw)", MilesPerGalon = 18, AccelerationTime = 13.5, Cylinders = 6, HorsePower = 110, Origin = "US", Weight = 2962 },
new Car() { Model = "Chevrolet Vega (sw)", MilesPerGalon = 22, AccelerationTime = 19, Cylinders = 4, HorsePower = 72, Origin = "US", Weight = 2408 },
new Car() { Model = "Pontiac Firebird", MilesPerGalon = 19, AccelerationTime = 15, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3282 },
new Car() { Model = "Ford Mustang", MilesPerGalon = 18, AccelerationTime = 14.5, Cylinders = 6, HorsePower = 88, Origin = "US", Weight = 3139 },
new Car() { Model = "Mercury Capri 2000", MilesPerGalon = 23, AccelerationTime = 14, Cylinders = 4, HorsePower = 86, Origin = "US", Weight = 2220 },
new Car() { Model = "Opel 1900", MilesPerGalon = 28, AccelerationTime = 14, Cylinders = 4, HorsePower = 90, Origin = "Europe", Weight = 2123 },
new Car() { Model = "Peugeot 304", MilesPerGalon = 30, AccelerationTime = 19.5, Cylinders = 4, HorsePower = 70, Origin = "Europe", Weight = 2074 },
new Car() { Model = "Fiat 124B", MilesPerGalon = 30, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 76, Origin = "Europe", Weight = 2065 },
new Car() { Model = "Toyota Corolla 1200", MilesPerGalon = 31, AccelerationTime = 19, Cylinders = 4, HorsePower = 65, Origin = "Japan", Weight = 1773 },
new Car() { Model = "Datsun 1200", MilesPerGalon = 35, AccelerationTime = 18, Cylinders = 4, HorsePower = 69, Origin = "Japan", Weight = 1613 },
new Car() { Model = "Volkswagen Model 111", MilesPerGalon = 27, AccelerationTime = 19, Cylinders = 4, HorsePower = 60, Origin = "Europe", Weight = 1834 },
new Car() { Model = "Plymouth Cricket", MilesPerGalon = 26, AccelerationTime = 20.5, Cylinders = 4, HorsePower = 70, Origin = "US", Weight = 1955 },
new Car() { Model = "Toyota Corolla Hardtop", MilesPerGalon = 24, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 95, Origin = "Japan", Weight = 2278 },
new Car() { Model = "Dodge Colt Hardtop", MilesPerGalon = 25, AccelerationTime = 17, Cylinders = 4, HorsePower = 80, Origin = "US", Weight = 2126 },
new Car() { Model = "Volkswagen Type 3", MilesPerGalon = 23, AccelerationTime = 23.5, Cylinders = 4, HorsePower = 54, Origin = "Europe", Weight = 2254 },
new Car() { Model = "Chevrolet Vega", MilesPerGalon = 20, AccelerationTime = 19.5, Cylinders = 4, HorsePower = 90, Origin = "US", Weight = 2408 },
new Car() { Model = "Ford Pinto Runabout", MilesPerGalon = 21, AccelerationTime = 16.5, Cylinders = 4, HorsePower = 86, Origin = "US", Weight = 2226 },
new Car() { Model = "Chevrolet Impala", MilesPerGalon = 13, AccelerationTime = 12, Cylinders = 8, HorsePower = 165, Origin = "US", Weight = 4274 },
new Car() { Model = "Pontiac Catalina", MilesPerGalon = 14, AccelerationTime = 12, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 4385 },
new Car() { Model = "Plymouth Fury III", MilesPerGalon = 15, AccelerationTime = 13.5, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4135 },
new Car() { Model = "Ford Galaxie 500", MilesPerGalon = 14, AccelerationTime = 13, Cylinders = 8, HorsePower = 153, Origin = "US", Weight = 4129 },
new Car() { Model = "AMC Ambassador SST", MilesPerGalon = 17, AccelerationTime = 11.5, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3672 },
new Car() { Model = "Mercury Marquis", MilesPerGalon = 11, AccelerationTime = 11, Cylinders = 8, HorsePower = 208, Origin = "US", Weight = 4633 },
new Car() { Model = "Buick LeSabre Custom", MilesPerGalon = 13, AccelerationTime = 11.5, Cylinders = 8, HorsePower = 155, Origin = "US", Weight = 4129 },
new Car() { Model = "Oldsmobile Delta 88 Royale", MilesPerGalon = 12, AccelerationTime = 12, Cylinders = 8, HorsePower = 155, Origin = "US", Weight = 4209 },
new Car() { Model = "Chrysler Newport Royal", MilesPerGalon = 13, AccelerationTime = 13.5, Cylinders = 8, HorsePower = 160, Origin = "US", Weight = 4457 },
new Car() { Model = "Mazda RX2 Coupe", MilesPerGalon = 19, AccelerationTime = 16, Cylinders = 3, HorsePower = 97, Origin = "Japan", Weight = 2774 },
new Car() { Model = "AMC Matador (Wagon)", MilesPerGalon = 16, AccelerationTime = 12, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4498 },
new Car() { Model = "Chevrolet Chevelle Concours (Wagon)", MilesPerGalon = 16, AccelerationTime = 13, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4657 },
new Car() { Model = "Ford Torino (Wagon)", MilesPerGalon = 17, AccelerationTime = 13, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 4499 },
new Car() { Model = "Plymouth Satellite (Wagon)", MilesPerGalon = 18, AccelerationTime = 12.5, Cylinders = 8, HorsePower = 130, Origin = "US", Weight = 3962 },
new Car() { Model = "AMC Pacer", MilesPerGalon = 17.5, AccelerationTime = 15, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3282 },
new Car() { Model = "Volkswagen Super Beetle", MilesPerGalon = 23.5, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 46, Origin = "Europe", Weight = 1835 },
new Car() { Model = "Ford Pinto", MilesPerGalon = 21, AccelerationTime = 16.5, Cylinders = 4, HorsePower = 67, Origin = "US", Weight = 2205 },
new Car() { Model = "AMC Gremlin", MilesPerGalon = 19, AccelerationTime = 16.5, Cylinders = 6, HorsePower = 90, Origin = "US", Weight = 3211 },
new Car() { Model = "Plymouth Duster", MilesPerGalon = 18.5, AccelerationTime = 17.5, Cylinders = 6, HorsePower = 95, Origin = "US", Weight = 2945 },
new Car() { Model = "Pontiac Ventura SJ", MilesPerGalon = 19, AccelerationTime = 14.5, Cylinders = 6, HorsePower = 97, Origin = "US", Weight = 2930 },
new Car() { Model = "AMC Hornet", MilesPerGalon = 18, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 85, Origin = "US", Weight = 3250 },
new Car() { Model = "Chevrolet Nova", MilesPerGalon = 16, AccelerationTime = 16, Cylinders = 6, HorsePower = 88, Origin = "US", Weight = 3897 },
new Car() { Model = "Ford Maverick", MilesPerGalon = 15.5, AccelerationTime = 17.5, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3230 },
new Car() { Model = "AMC Gremlin", MilesPerGalon = 19, AccelerationTime = 14.5, Cylinders = 6, HorsePower = 85, Origin = "US", Weight = 2990 },
new Car() { Model = "Plymouth Satellite Custom", MilesPerGalon = 16.5, AccelerationTime = 14, Cylinders = 6, HorsePower = 88, Origin = "US", Weight = 3730 },
new Car() { Model = "Chevrolet Chevelle Malibu", MilesPerGalon = 16.5, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 88, Origin = "US", Weight = 3785 },
new Car() { Model = "Ford Gran Torino", MilesPerGalon = 14.5, AccelerationTime = 14.5, Cylinders = 8, HorsePower = 117, Origin = "US", Weight = 3410 },
new Car() { Model = "Plymouth Valiant Custom", MilesPerGalon = 15.5, AccelerationTime = 15.5, Cylinders = 6, HorsePower = 90, Origin = "US", Weight = 3520 },
new Car() { Model = "Chevrolet Nova Custom", MilesPerGalon = 16.5, AccelerationTime = 16, Cylinders = 6, HorsePower = 90, Origin = "US", Weight = 3420 },
new Car() { Model = "AMC Matador", MilesPerGalon = 15.5, AccelerationTime = 14.5, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 3955 },
new Car() { Model = "Chevrolet Malibu", MilesPerGalon = 19.5, AccelerationTime = 14.5, Cylinders = 6, HorsePower = 150, Origin = "US", Weight = 3761 },
new Car() { Model = "Ford Gran Torino (Wagon)", MilesPerGalon = 12, AccelerationTime = 14, Cylinders = 8, HorsePower = 152, Origin = "US", Weight = 4215 },
new Car() { Model = "Buick Century 350", MilesPerGalon = 13, AccelerationTime = 15.5, Cylinders = 8, HorsePower = 175, Origin = "US", Weight = 3900 },
new Car() { Model = "AMC Matador (Wagon)", MilesPerGalon = 14, AccelerationTime = 17, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4499 },
new Car() { Model = "Ford Gran Torino (Wagon)", MilesPerGalon = 13, AccelerationTime = 14.5, Cylinders = 8, HorsePower = 148, Origin = "US", Weight = 4657 },
new Car() { Model = "Plymouth Satellite Custom (Wagon)", MilesPerGalon = 14, AccelerationTime = 17.5, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4129 },
new Car() { Model = "Volvo 145e (Wagon)", MilesPerGalon = 18, AccelerationTime = 11, Cylinders = 4, HorsePower = 112, Origin = "Europe", Weight = 2933 },
new Car() { Model = "Volkswagen 411 (Wagon)", MilesPerGalon = 22, AccelerationTime = 14, Cylinders = 4, HorsePower = 76, Origin = "Europe", Weight = 2930 },
new Car() { Model = "Peugeot 504 (Wagon)", MilesPerGalon = 21, AccelerationTime = 19.5, Cylinders = 4, HorsePower = 87, Origin = "Europe", Weight = 3907 },
new Car() { Model = "Renault 12 (Wagon)", MilesPerGalon = 26, AccelerationTime = 18.6, Cylinders = 4, HorsePower = 87, Origin = "Europe", Weight = 3190 },
new Car() { Model = "Ford Pinto (Wagon)", MilesPerGalon = 22.5, AccelerationTime = 16.9, Cylinders = 4, HorsePower = 89, Origin = "US", Weight = 2755 },
new Car() { Model = "Datsun 510 (Wagon)", MilesPerGalon = 28, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 96, Origin = "Japan", Weight = 2800 },
new Car() { Model = "Toyota Corolla (Wagon)", MilesPerGalon = 29, AccelerationTime = 16.4, Cylinders = 4, HorsePower = 97, Origin = "Japan", Weight = 2130 },
new Car() { Model = "Dodge Colt (Wagon)", MilesPerGalon = 26, AccelerationTime = 20.5, Cylinders = 4, HorsePower = 85, Origin = "US", Weight = 2295 },
new Car() { Model = "Toyota Corolla", MilesPerGalon = 31.5, AccelerationTime = 19.5, Cylinders = 4, HorsePower = 85, Origin = "Japan", Weight = 2020 },
new Car() { Model = "Datsun 510", MilesPerGalon = 27.2, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 88, Origin = "Japan", Weight = 2130 },
new Car() { Model = "Chevrolet Citation", MilesPerGalon = 23.5, AccelerationTime = 14, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 2379 },
new Car() { Model = "Ford Fairmont", MilesPerGalon = 24.5, AccelerationTime = 15, Cylinders = 4, HorsePower = 92, Origin = "US", Weight = 2130 },
new Car() { Model = "AMC Concord", MilesPerGalon = 19.4, AccelerationTime = 13, Cylinders = 6, HorsePower = 115, Origin = "US", Weight = 2320 },
new Car() { Model = "Dodge Aspen", MilesPerGalon = 20.3, AccelerationTime = 17, Cylinders = 6, HorsePower = 120, Origin = "US", Weight = 2230 },
new Car() { Model = "Audi 4000", MilesPerGalon = 21.4, AccelerationTime = 15.5, Cylinders = 4, HorsePower = 110, Origin = "Europe", Weight = 2800 },
new Car() { Model = "Toyota Corona", MilesPerGalon = 21.6, AccelerationTime = 16.5, Cylinders = 4, HorsePower = 110, Origin = "Japan", Weight = 2720 },
new Car() { Model = "Ford Pinto", MilesPerGalon = 26, AccelerationTime = 18.5, Cylinders = 4, HorsePower = 95, Origin = "US", Weight = 2560 },
new Car() { Model = "Datsun 510", MilesPerGalon = 27, AccelerationTime = 18, Cylinders = 4, HorsePower = 88, Origin = "Japan", Weight = 2205 },
new Car() { Model = "Toyota Corolla", MilesPerGalon = 25.5, AccelerationTime = 16.4, Cylinders = 4, HorsePower = 98, Origin = "Japan", Weight = 2160 },
new Car() { Model = "Mazda GLC", MilesPerGalon = 30.5, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 78, Origin = "Japan", Weight = 1985 },
new Car() { Model = "Dodge Colt", MilesPerGalon = 30.6, AccelerationTime = 16.4, Cylinders = 4, HorsePower = 75, Origin = "US", Weight = 2145 },
new Car() { Model = "Capri ii", MilesPerGalon = 25, AccelerationTime = 14.9, Cylinders = 4, HorsePower = 92, Origin = "US", Weight = 2572 },
new Car() { Model = "Dodge Colt", MilesPerGalon = 26, AccelerationTime = 17.7, Cylinders = 4, HorsePower = 79, Origin = "US", Weight = 2255 },
new Car() { Model = "Renault 12tl", MilesPerGalon = 27, AccelerationTime = 15.3, Cylinders = 4, HorsePower = 83, Origin = "Europe", Weight = 2202 },
new Car() { Model = "Chevrolet Chevelle Malibu Classic", MilesPerGalon = 17.5, AccelerationTime = 13, Cylinders = 8, HorsePower = 140, Origin = "US", Weight = 4215 },
new Car() { Model = "Dodge Coronet Brougham", MilesPerGalon = 16, AccelerationTime = 13, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 4190 },
new Car() { Model = "AMC Matador", MilesPerGalon = 15.5, AccelerationTime = 13.9, Cylinders = 8, HorsePower = 120, Origin = "US", Weight = 3962 },
new Car() { Model = "Ford Gran Torino", MilesPerGalon = 14.5, AccelerationTime = 12.8, Cylinders = 8, HorsePower = 152, Origin = "US", Weight = 4215 },
new Car() { Model = "Plymouth Valiant", MilesPerGalon = 22, AccelerationTime = 15.4, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3233 },
new Car() { Model = "Chevrolet Nova", MilesPerGalon = 22, AccelerationTime = 14.5, Cylinders = 6, HorsePower = 105, Origin = "US", Weight = 3353 },
new Car() { Model = "Ford Maverick", MilesPerGalon = 24, AccelerationTime = 17.6, Cylinders = 6, HorsePower = 81, Origin = "US", Weight = 3012 },
new Car() { Model = "AMC Hornet", MilesPerGalon = 22.5, AccelerationTime = 17.6, Cylinders = 6, HorsePower = 90, Origin = "US", Weight = 3085 },
new Car() { Model = "Chevrolet Chevette", MilesPerGalon = 29, AccelerationTime = 22.2, Cylinders = 4, HorsePower = 52, Origin = "US", Weight = 2035 },
new Car() { Model = "Chevrolet Woody", MilesPerGalon = 24.5, AccelerationTime = 22.1, Cylinders = 4, HorsePower = 60, Origin = "US", Weight = 2164 },
new Car() { Model = "Volkswagen Rabbit", MilesPerGalon = 29, AccelerationTime = 14.2, Cylinders = 4, HorsePower = 70, Origin = "Europe", Weight = 1937 },
new Car() { Model = "Honda Civic", MilesPerGalon = 33, AccelerationTime = 17.4, Cylinders = 4, HorsePower = 53, Origin = "Japan", Weight = 1795 },
new Car() { Model = "Dodge Aspen SE", MilesPerGalon = 20, AccelerationTime = 17.7, Cylinders = 6, HorsePower = 100, Origin = "US", Weight = 3651 },
new Car() { Model = "Ford Grenada ghia", MilesPerGalon = 18, AccelerationTime = 21, Cylinders = 6, HorsePower = 78, Origin = "US", Weight = 3574 },
new Car() { Model = "Pontiac Ventura SJ", MilesPerGalon = 18.5, AccelerationTime = 16.2, Cylinders = 6, HorsePower = 110, Origin = "US", Weight = 3645 },
new Car() { Model = "AMC Pacer d/l", MilesPerGalon = 17.5, AccelerationTime = 17.8, Cylinders = 6, HorsePower = 95, Origin = "US", Weight = 3193 },
new Car() { Model = "Volkswagen Rabbit", MilesPerGalon = 29.5, AccelerationTime = 12.2, Cylinders = 4, HorsePower = 71, Origin = "Europe", Weight = 1825 },
new Car() { Model = "Datsun B-210", MilesPerGalon = 32, AccelerationTime = 17, Cylinders = 4, HorsePower = 70, Origin = "Japan", Weight = 1990 },
new Car() { Model = "Toyota Corolla", MilesPerGalon = 28, AccelerationTime = 16.4, Cylinders = 4, HorsePower = 75, Origin = "Japan", Weight = 2155 },
new Car() { Model = "Ford Pinto", MilesPerGalon = 26.5, AccelerationTime = 13.6, Cylinders = 4, HorsePower = 72, Origin = "US", Weight = 2565 },
new Car() { Model = "Volvo 245", MilesPerGalon = 20, AccelerationTime = 15.7, Cylinders = 4, HorsePower = 102, Origin = "Europe", Weight = 3150 },
new Car() { Model = "Plymouth Volare Premier v8", MilesPerGalon = 13, AccelerationTime = 13.2, Cylinders = 8, HorsePower = 150, Origin = "US", Weight = 3940 },
new Car() { Model = "Peugeot 504", MilesPerGalon = 19, AccelerationTime = 17.4, Cylinders = 4, HorsePower = 79, Origin = "Europe", Weight = 3140 },
new Car() { Model = "Toyota Corolla liftback", MilesPerGalon = 26, AccelerationTime = 16.6, Cylinders = 4, HorsePower = 97, Origin = "Japan", Weight = 2300 },
new Car() { Model = "Mazda 626", MilesPerGalon = 31.5, AccelerationTime = 14.4, Cylinders = 4, HorsePower = 120, Origin = "Japan", Weight = 2625 },
new Car() { Model = "Datsun 510", MilesPerGalon = 27.2, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 119, Origin = "Japan", Weight = 2130 },
new Car() { Model = "Toyota Corona", MilesPerGalon = 24, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 97, Origin = "Japan", Weight = 2020 },
new Car() { Model = "Honda Civic cvcc", MilesPerGalon = 36, AccelerationTime = 18.5, Cylinders = 4, HorsePower = 75, Origin = "Japan", Weight = 1985 },
new Car() { Model = "Ford Grenada l", MilesPerGalon = 20, AccelerationTime = 17, Cylinders = 6, HorsePower = 98, Origin = "US", Weight = 3525 },
new Car() { Model = "Toyota Celica gt liftback", MilesPerGalon = 21.1, AccelerationTime = 12.1, Cylinders = 4, HorsePower = 134, Origin = "Japan", Weight = 2515 },
new Car() { Model = "Dodge Colt m/m", MilesPerGalon = 27.9, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 71, Origin = "US", Weight = 2220 },
new Car() { Model = "Datsun 210", MilesPerGalon = 40.8, AccelerationTime = 13.5, Cylinders = 4, HorsePower = 65, Origin = "Japan", Weight = 2045 },
new Car() { Model = "Volkswagen Rabbit c (diesel)", MilesPerGalon = 44.3, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 48, Origin = "Europe", Weight = 2085 },
new Car() { Model = "Volkswagen Dasher (diesel)", MilesPerGalon = 43.4, AccelerationTime = 24.6, Cylinders = 4, HorsePower = 48, Origin = "Europe", Weight = 2335 },
new Car() { Model = "Audi 5000s (diesel)", MilesPerGalon = 36.4, AccelerationTime = 19.9, Cylinders = 5, HorsePower = 67, Origin = "Europe", Weight = 2950 },
new Car() { Model = "Mercedes-benz 240d", MilesPerGalon = 30, AccelerationTime = 20.7, Cylinders = 4, HorsePower = 67, Origin = "Europe", Weight = 3250 },
new Car() { Model = "Honda Civic 1500 gl", MilesPerGalon = 44.6, AccelerationTime = 14.5, Cylinders = 4, HorsePower = 67, Origin = "Japan", Weight = 1850 },
new Car() { Model = "Renault Lecar deluxe", MilesPerGalon = 40.9, AccelerationTime = 14.8, Cylinders = 4, HorsePower = 67, Origin = "Europe", Weight = 1835 },
new Car() { Model = "Subaru dl", MilesPerGalon = 32.3, AccelerationTime = 12.5, Cylinders = 4, HorsePower = 67, Origin = "Japan", Weight = 2145 },
new Car() { Model = "Volkswagen Rabbit custom", MilesPerGalon = 37, AccelerationTime = 14, Cylinders = 4, HorsePower = 67, Origin = "Europe", Weight = 1985 }

                };
           
        }
    }
}