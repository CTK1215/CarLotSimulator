using System;

namespace CarLotSimulator;

public class Program
{
    public static void Main(string[] args)
    {
        CarLot carLot = new CarLot();

        // Style 1: empty constructor + property setters
        Car car1 = new Car();
        car1.Year = 2018;
        car1.Make = "Honda";
        car1.Model = "Civic";
        car1.EngineNoise = "vrooom";
        car1.HonkNoise = "beep beep";
        car1.IsDriveable = true;
        carLot.Cars.Add(car1);

        // Style 2: object initializer
        Car car2 = new Car
        {
            Year = 2022,
            Make = "Ford",
            Model = "F-150",
            EngineNoise = "RRRRUMMBLE",
            HonkNoise = "AH-OOOOGA AH-OOOOGA",
            IsDriveable = true
        };
        carLot.Cars.Add(car2);

        // Style 3: var with object initializer
        var car3 = new Car
        {
            Year = 1995,
            Make = "Toyota",
            Model = "Corolla",
            EngineNoise = "putt putt",
            HonkNoise = "meep",
            IsDriveable = false
        };
        carLot.Cars.Add(car3);

        car1.MakeEngineNoise(car1.EngineNoise);
        car1.MakeHonkNoise(car1.HonkNoise);

        car2.MakeEngineNoise(car2.EngineNoise);
        car2.MakeHonkNoise(car2.HonkNoise);

        car3.MakeEngineNoise(car3.EngineNoise);
        car3.MakeHonkNoise(car3.HonkNoise);

        Console.WriteLine("\nCars in the lot:");
        foreach (Car car in carLot.Cars)
        {
            Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
        }
    }
}