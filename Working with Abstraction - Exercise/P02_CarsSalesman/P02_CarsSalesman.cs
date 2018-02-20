﻿using System;
using System.Collections.Generic;
using System.Linq;

class CarSalesman
{
    public static void Main()
    {
        var cars = AddCars();
        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static List<Car> AddCars()
    {
        List<Engine> engines;
        var cars = AddEngine(out engines);
        int carCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = parameters[0];
            string engineModel = parameters[1];
            Engine engine = engines.FirstOrDefault(x => x.model == engineModel);

            int weight;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
            {
                cars.Add(new Car(model, engine, weight));
            }
            else if (parameters.Length == 3)
            {
                string color = parameters[2];
                cars.Add(new Car(model, engine, color));
            }
            else if (parameters.Length == 4)
            {
                string color = parameters[3];
                cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
            }
            else
            {
                cars.Add(new Car(model, engine));
            }
        }
        return cars;
    }

    private static List<Car> AddEngine(out List<Engine> engines)
    {
        List<Car> cars = new List<Car>();
        engines = new List<Engine>();
        int engineCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < engineCount; i++)
        {
            var parameters = Console.ReadLine()
                .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries);
            var model = parameters[0];
            var power = int.Parse(parameters[1]);

            int displacement;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
            {
                engines.Add(new Engine(model, power, displacement));
            }
            else if (parameters.Length == 3)
            {
                string efficiency = parameters[2];
                engines.Add(new Engine(model, power, efficiency));
            }
            else if (parameters.Length == 4)
            {
                string efficiency = parameters[3];
                engines.Add(new Engine(model, power, int.Parse(parameters[2]), efficiency));
            }
            else
            {
                engines.Add(new Engine(model, power));
            }
        }
        return cars;
    }
}