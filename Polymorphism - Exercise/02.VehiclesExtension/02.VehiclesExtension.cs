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
        var tankCapacity = double.Parse(carInfo[3]);
        var currentCar = new Car(fuelQuantity, litersPerKm, tankCapacity);
        //
        var truckInfo = Console.ReadLine().Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        var fuelQuantityTruck = double.Parse(truckInfo[1]);
        var litersPerKmTruck = double.Parse(truckInfo[2]);
        var tankCapacityTruck = double.Parse(truckInfo[3]);
        var currentTruck = new Truck(fuelQuantityTruck, litersPerKmTruck, tankCapacityTruck);
        //
        var busInfo = Console.ReadLine().Split(new[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var fuelQuantityBus = double.Parse(busInfo[1]);
        var litersPerKmBus = double.Parse(busInfo[2]);
        var tankCapacityBus = double.Parse(busInfo[3]);
        var currentBus = new Bus(fuelQuantityBus, litersPerKmBus, tankCapacityBus);

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
                    else if (vehicleType == "Truck")
                    {
                        currentTruck.Drive(distance);
                    }
                    else
                    {
                        currentBus.Drive(distance);
                    }
                    break;
                case "DriveEmpty":
                    distance = double.Parse(commands[2]);
                    currentBus.DriveEmpty(distance);
                    break;
                case "Refuel":
                    var liters = double.Parse(commands[2]);
                    if (vehicleType == "Car")
                    {
                        currentCar.Refuel(liters, currentCar.TankCapacity);
                    }
                    else if (vehicleType == "Truck")
                    {
                        currentTruck.Refuel(liters, currentTruck.TankCapacity);
                    }
                    else
                    {
                        currentBus.Refuel(liters, currentBus.TankCapacity);
                    }
                    break;
            }
        }
        Console.WriteLine(currentCar);
        Console.WriteLine(currentTruck);
        Console.WriteLine(currentBus);
    }
}