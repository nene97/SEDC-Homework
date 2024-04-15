using Homework07;
using Homework07.Domain.Models;
using System.Linq;

List<Car> carsFromEurope = CarsData.Cars.Where(x => x.Origin == "Europe").ToList();

List<Car> carsFromUS = CarsData.Cars.Where(x => x.Origin == "US").ToList();

carsFromEurope.PrintEntities();
Console.WriteLine("============================================================");

List<Car> moreThan6 = CarsData.Cars.Where(x => x.Cylinders > 6).ToList();
List<Car> moreThan4 = CarsData.Cars.Where(x => x.Cylinders == 4 && x.HorsePower > 110).ToList();
List<Car> oneList = (List<Car>)moreThan6.Concat(moreThan4).ToList();   //merging the two lists together in one 

oneList.PrintEntities();
Console.WriteLine("============================================================");


Console.WriteLine($"Cars from Europe " +  carsFromEurope.Count);
Console.WriteLine($"Cars from US " + carsFromUS.Count);


var groupedList = CarsData.Cars.GroupBy(o => o.Origin).Select(grp => grp.ToList()).ToList();

for(int i = 0; i < groupedList.Count; i++)
{
    groupedList[i].PrintInfoOrigin();
   
} 
Console.WriteLine($"Made in US " +  groupedList[0].Count);
Console.WriteLine($"Made in Europe  " +  groupedList[1].Count);
Console.WriteLine($"Made in Japan " +  groupedList[2].Count);

Console.WriteLine("============================================================");
//models made in the US 8 cylinder 
List<string> modelsNAmesFromUS = carsFromUS.Where(x =>  x.Cylinders == 8).Select(x => x.Model).ToList();


Console.WriteLine("Models with 8 cylinder from the US: " );

modelsNAmesFromUS.PrintSimple();
Console.WriteLine("============================================================");

Console.WriteLine("MOre than 200 hp");

List<Car> morethan200Hp = CarsData.Cars.Where(x => x.HorsePower  > 200).ToList();
morethan200Hp.PrintEntities();
Console.WriteLine("============================================================");

Console.WriteLine("The model with the min and max miles per Galon are :");

var minMPG = morethan200Hp.MinBy(x => x.MilesPerGalon);
minMPG.PrintInfo();

var maxMPG = morethan200Hp.MaxBy(x => x.MilesPerGalon);
maxMPG.PrintInfo();

var average = morethan200Hp.Average(x => x.MilesPerGalon);
Console.WriteLine($"The average miles per galon is: {average} ");

Console.WriteLine("============================================================");



