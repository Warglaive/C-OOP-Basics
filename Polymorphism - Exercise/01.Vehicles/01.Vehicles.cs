using System;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split(new[] { ' ' }
        , StringSplitOptions.RemoveEmptyEntries)
        .ToList();
        var fuelQuantity = double.Parse(carInfo[1]);
        var litersPerKm = double.Parse(carInfo[2]);
        var currentCar = new Car(fuelQuantity, litersPerKm);
        //
        var truckInfo = Console.ReadLine().Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        var fuelQuantityTruck = double.Parse(truckInfo[1]);
        var litersPerKmTruck = double.Parse(truckInfo[2]);
        var currentTruck = new Truck(fuelQuantityTruck, litersPerKmTruck);

        var n = int.Parse(Console.ReadLine());
        for (var i = 0; i < n; i++)
        {
            var commands = Console.ReadLine().Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var command = commands[0];
            var vehicleType = commands[1];
            switch (command)
            {
                case "Drive":
                    var distance = double.Parse(commands[2]);
                    if (vehicleType == "Car")
                    {
                        currentCar.Drive(distance);
                    }
                    else
                    {
                        currentTruck.Drive(distance);
                    }
                    break;
                case "Refuel":
                    var liters = double.Parse(commands[2]);
                    if (vehicleType == "Car")
                    {
                        currentCar.Refuel(liters);
                    }
                    else
                    {
                        currentTruck.Refuel(liters);
                    }
                    break;
            }
        }
        Console.WriteLine(currentCar);
        Console.WriteLine(currentTruck);
    }
}