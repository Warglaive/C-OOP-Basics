using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var takeListCars = new List<Car>();
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var carInfoInput = Console.ReadLine();
            var carInfoArgs = carInfoInput.Split();

            var currentCar = new Car();//car model is unique
            currentCar.Model = carInfoArgs[0];
            currentCar.FuelAmount = double.Parse(carInfoArgs[1]);
            currentCar.FuelConsumptionFor1km = double.Parse(carInfoArgs[2]);
            currentCar.DistanceTraveled = 0;
            takeListCars.Add(currentCar);

        }
        var commands = Console.ReadLine();
        //Drive the cars
        while (commands != "End")
        {
            Car checkCar = new Car();
            var commandParts = commands.Split();
            var carModel = commandParts[1];
            var amountOfKm = int.Parse(commandParts[2]);
            checkCar.CanTheCarMoveDistance(takeListCars, carModel, amountOfKm);

            commands = Console.ReadLine();
        }
        foreach (var currentCar in takeListCars)
        {
            Console.WriteLine($"{currentCar.Model} " +
                              $"{currentCar.FuelAmount:f2}" +
                              $" {currentCar.DistanceTraveled}");
        }
    }
}