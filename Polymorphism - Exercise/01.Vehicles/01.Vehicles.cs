using System;

public class Program
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split();
        var fuelQuantityCar = decimal.Parse(carInfo[1]);
        var fuelConsumPerKm = decimal.Parse(carInfo[2]);

        var currentCar = new Car(fuelQuantityCar, fuelConsumPerKm);
        Console.WriteLine(currentCar.FuelQuantity);
        var truckInfo = Console.ReadLine().Split();
        var fuelQuantityTruck = decimal.Parse(truckInfo[1]);
        var literPerKmTruck = decimal.Parse(truckInfo[2]);
        var currentTruck = new Truck(fuelQuantityTruck, literPerKmTruck);
        var commandsNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsNumber; i++)
        {
            var input = Console.ReadLine().Split();
            var command = input[0];
            var vehicleType = input[1];
            switch (command)
            {
                case "Drive":
                    var distance = decimal.Parse(input[2]);
                    if (vehicleType == "Car")
                    {
                        var fuelNeeded = currentCar.FuelConsumationPerKm * distance;
                        if (currentCar.FuelQuantity >= fuelNeeded)
                        {
                            currentCar.PrintEnought(vehicleType, distance);
                        }
                        else
                        {
                            currentCar.PrintNotEnought(vehicleType, distance);
                        }
                    }
                    break;
            }
        }
    }
}