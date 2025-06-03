using Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


CarsData.LoadCars();

#region Task 1

//Filter all cars that have origin from Europe and print them in console


List<Car> europeanCars = CarsData.Cars
    .Where(car => car.Origin == "Europe")
    .ToList();

foreach (Car car in europeanCars)
{
    Console.WriteLine($"Model: {car.Model}, Origin: {car.Origin}");
}
#endregion
Console.WriteLine("=================");
#region Task 2


//Filter all cars that have more that 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result and print them in console.
List<Car> highCylinderCars = CarsData.Cars
    .Where(car => car.Cylinders > 6)
    .ToList();

List<Car> fourCylinderPowerfulCars = CarsData.Cars
    .Where(car => car.Cylinders == 4 && car.HorsePower > 110.0)
    .ToList();

List<Car> combinedCars = highCylinderCars
    .Concat(fourCylinderPowerfulCars)
    .ToList();

foreach (Car car in combinedCars)
{
    Console.WriteLine($"Model: {car.Model}, Cylinders: {car.Cylinders}, HorsePower: {car.HorsePower}");
}

#endregion
Console.WriteLine("=================");
#region Task 3
//Count all cars based on their Origin and print the result in console. Example outpur "US 10 models\n Eu 15 Models";
List<string> origins = CarsData.Cars
     .Select(car => car.Origin)
     .Distinct()
     .ToList();

foreach (string origin in origins)
{
    int count = CarsData.Cars
        .Count(car => car.Origin == origin);

    Console.WriteLine(origin + " " + count + " models");
}
#endregion
Console.WriteLine("=================");
#region Task 4
//Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;

List<Car> powerfulCars = CarsData.Cars
         .Where(car => car.HorsePower > 200)
         .ToList();

if (powerfulCars.Count > 0)
{
    double minMpg = powerfulCars.Min(car => car.MilesPerGalon);
    double maxMpg = powerfulCars.Max(car => car.MilesPerGalon);
    double avgMpg = powerfulCars.Average(car => car.MilesPerGalon);

    Console.WriteLine("Lowest MPG: " + minMpg);
    Console.WriteLine("Highest MPG: " + maxMpg);
    Console.WriteLine("Average MPG: " + avgMpg);
}
else
{
    Console.WriteLine("No cars found with more then 200 HorsePower.");
}

#endregion
Console.WriteLine("=================");
#region Task 5
List<Car> top3Cars = CarsData.Cars
       .OrderBy(car => car.AccelerationTime)
       .Take(3)
       .ToList();

foreach (Car car in top3Cars)
{
    Console.WriteLine(car.Model);
}
Console.WriteLine("=================");

double totalWeight = CarsData.Cars
          .Where(car => car.Cylinders > 6)
          .Sum(car => car.Weight);

Console.WriteLine("Total weight of cars with more than 6 cylinders: " + totalWeight);
Console.WriteLine("=================");

double averageMpg = CarsData.Cars
    .Where(car => car.Cylinders % 2 == 0)
    .Average(car => car.MilesPerGalon);
Console.WriteLine("Average MilesPerGalon for cars with even number of cylinders: " + averageMpg);

#endregion






