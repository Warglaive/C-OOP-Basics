using System;

public class Program
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split();
        var fuelQuantityCar = double.Parse(carInfo[1]);
        var fuelConsumPerKm = double.Parse(carInfo[2]);

        var currentCar = new Car(fuelQuantityCar, fuelConsumPerKm);

        var truckInfo = Console.ReadLine().Split(new[] { ' ' }
        , StringSplitOptions.RemoveEmptyEntries);
        var fuelQuantityTruck = double.Parse(truckInfo[1]);
        var fuelConsumPerKmTruck = double.Parse(truckInfo[2]);

        var currentTruck = new Truck(fuelQuantityTruck, fuelConsumPerKmTruck);
        var commandsNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsNumber; i++)
        {
            var input = Console.ReadLine().Split(new[] {' '}
                , StringSplitOptions.RemoveEmptyEntries);
            var command = input[0];
            var vehicleType = input[1];
            switch (command)
            {
                case "Drive":
                    var distance = double.Parse(input[2]);
                    if (vehicleType == "Car")
                    {
                        var neededFuel = distance * currentCar.FuelConsumationPerKm;
                        if (currentCar.FuelQuantity / currentCar.FuelConsumationPerKm > neededFuel)
                        {
                            currentCar.PrintIsEnoughtFuel(vehicleType, distance);
                        }
                        else
                        {
                            currentCar.PrintNotEnoughFuel(vehicleType);
                        }
                    }
                    else
                    {
                        var neededFuelTruck = distance * currentTruck.FuelConsumationPerKm;
                        if (currentTruck.FuelQuantity / currentTruck.FuelConsumationPerKm > neededFuelTruck)
                        {
                            currentTruck.PrintIsEnoughtFuel(vehicleType, distance);
                        }
                        else
                        {
                            currentTruck.PrintNotEnoughFuel(vehicleType);
                        }
                    }
                    break;
                case "Refuel":
                    if (vehicleType == "Car")
                    {
                        var refuelQuantity = double.Parse(input[2]);
                        currentCar.Refuel(refuelQuantity);
                    }
                    else
                    {
                        var refuelQuantity = double.Parse(input[2]);
                        var lessFuel = refuelQuantity * 0.95;
                        currentTruck.Refuel(lessFuel);
                    }
                    break;
            }
        }
        Console.WriteLine($"Car: {currentCar.FuelQuantity:f2}");
        Console.WriteLine($"Truck: {currentTruck.FuelQuantity:f2}");
    }
}