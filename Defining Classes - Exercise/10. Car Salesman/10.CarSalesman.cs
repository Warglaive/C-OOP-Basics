using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var engines = new List<Engine>();
        var enginesReceiveCount = int.Parse(Console.ReadLine());
        GetEnginesToList(enginesReceiveCount, engines);
        var cars = GetCarsToList();
        Print(cars, engines);
    }

    private static void Print(List<Car> cars, List<Engine> engines)
    {
        foreach (var currentCar in cars)
        {
            Console.WriteLine($"{currentCar.Model}:");
            foreach (var engine in engines)
            {
                if (engine.Model == currentCar.Engine)
                {
                    Console.WriteLine($"  {engine.Model}:"
                                      + Environment.NewLine
                                      + $"    Power: {engine.Power}"
                                      + Environment.NewLine
                                      + $"    Displacement: {engine.Displacement}"
                                      + Environment.NewLine
                                      + $"    Efficiency: {engine.Efficiency}");
                }
            }
            Console.WriteLine($"  Weight: {currentCar.Weight}"
                              + Environment.NewLine +
                              $"  Color: {currentCar.Color}");
        }
    }

    private static List<Car> GetCarsToList()
    {
        var cars = new List<Car>();
        var carsEntryCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carsEntryCount; i++)
        {
            var currentCar = new Car();
            //“<Model> <Engine> <Weight> <Color>
            var currentCarArgs = Console.ReadLine()
                .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
            currentCar.Model = currentCarArgs[0];
            currentCar.Engine = currentCarArgs[1];
            currentCar.Weight = "n/a";
            currentCar.Color = "n/a";
            if (currentCarArgs.Count == 3 && int.TryParse(currentCarArgs[2], out _) == false)
            {
                currentCar.Color = currentCarArgs[2];
            }
            else if (currentCarArgs.Count == 3 && int.TryParse(currentCarArgs[2], out _))
            {
                currentCar.Weight = currentCarArgs[2];
            }
            if (currentCarArgs.Count > 3)
            {
                currentCar.Weight = currentCarArgs[2];
                currentCar.Color = currentCarArgs[3];
            }
            cars.Add(currentCar);
        }
        return cars;
    }

    private static void GetEnginesToList(int enginesReceiveCount, List<Engine> engines)
    {
        for (int i = 0; i < enginesReceiveCount; i++)
        {
            //“<Model> <Power> <Displacement> <Efficiency>
            var currentEngine = new Engine();
            var currentEngineArgsInput = Console.ReadLine()
                .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries).ToList();
            currentEngine.Model = currentEngineArgsInput[0];
            currentEngine.Power = currentEngineArgsInput[1];

            currentEngine.Displacement = "n/a"; // Int
            currentEngine.Efficiency = "n/a";

            if (currentEngineArgsInput.Count == 3 && int.TryParse(currentEngineArgsInput[2], out _))
            {
                currentEngine.Displacement = currentEngineArgsInput[2];
            }
            else if (currentEngineArgsInput.Count == 3 && int.TryParse(currentEngineArgsInput[2], out _) == false)
            {
                currentEngine.Efficiency = currentEngineArgsInput[2];
            }
            else if (currentEngineArgsInput.Count > 3)
            {
                currentEngine.Displacement = currentEngineArgsInput[2];
                currentEngine.Efficiency = currentEngineArgsInput[3];
            }
            engines.Add(currentEngine);
        }
    }
}