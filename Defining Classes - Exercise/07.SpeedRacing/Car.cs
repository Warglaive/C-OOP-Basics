using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumptionFor1km;
    private decimal distanceTraveled;

    public string Model
    {
        get => model;
        set => model = value;
    }
    public decimal FuelAmount
    {
        get => fuelAmount;
        set => fuelAmount = value;
    }
    public decimal FuelConsumptionFor1km
    {
        get => fuelConsumptionFor1km;
        set => fuelConsumptionFor1km = value;
    }

    public decimal DistanceTraveled
    {
        get => distanceTraveled;
        set => distanceTraveled = value;
    }
    //list cars

    public void CanTheCarMoveDistance(HashSet<Car> takeListCars, string givenModel, decimal distanceToMove)
    {
        var filterModels = takeListCars
            .Where(x => x.model == givenModel)
            .ToList();
        var currentCar = filterModels.FirstOrDefault();

        if (distanceToMove <= currentCar.fuelAmount / currentCar.FuelConsumptionFor1km)
        {
            currentCar.fuelAmount -= currentCar.FuelConsumptionFor1km * distanceToMove;
            currentCar.distanceTraveled += distanceToMove;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
