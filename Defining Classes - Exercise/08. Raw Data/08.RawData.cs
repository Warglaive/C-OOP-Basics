using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        var totalCars = new List<Car>();
        var carsAmount = int.Parse(Console.ReadLine());
        for (int currentCarInputLine = 0; currentCarInputLine < carsAmount; currentCarInputLine++)
        {
            var currentCarInput = Console.ReadLine().Split(new[] { ' ', '.' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();


            var currentEngine = new Engine();
            var currentCargo = new Cargo();
            var currentTires = new Tire();
            //Car
            var model = currentCarInput[0];
            //Engine
            currentEngine.EngineSpeed = int.Parse(currentCarInput[1]);
            currentEngine.EnginePower = int.Parse(currentCarInput[2]);
            //Cargo
            currentCargo.CargoWeight = int.Parse(currentCarInput[3]);
            currentCargo.CargoType = currentCarInput[4];
            //Tire
            currentTires.Tire1Pressure = double.Parse(currentCarInput[5]);
            currentTires.Tire1Age = int.Parse(currentCarInput[6]);

            currentTires.Tire2Pressure = double.Parse(currentCarInput[7]);
            currentTires.Tire2Age = int.Parse(currentCarInput[8]);

            currentTires.Tire3Pressure = double.Parse(currentCarInput[9]);
            currentTires.Tire3Age = int.Parse(currentCarInput[10]);

            currentTires.Tire4Pressure = double.Parse(currentCarInput[11]);
            currentTires.Tire4Age = int.Parse(currentCarInput[12]);
            //Add to currentCar
            var currentCar = new Car(model, currentTires, currentEngine, currentCargo);
            totalCars.Add(currentCar);

        }
        var lastLine = Console.ReadLine();
        //PRINT
    }
}