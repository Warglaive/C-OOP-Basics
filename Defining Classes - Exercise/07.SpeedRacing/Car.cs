using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionFor1km;
    private double distanceTraveled;

    public string Model
    {
        get => model;
        set => model = value;
    }
    public double FuelAmount
    {
        get => fuelAmount;
        set => fuelAmount = value;
    }
    public double FuelConsumptionFor1km
    {
        get => fuelConsumptionFor1km;
        set => fuelConsumptionFor1km = value;
    }

    public double DistanceTraveled
    {
        get => distanceTraveled;
        set => distanceTraveled = value;
    }
    //list cars

    public Car CanTheCarMoveDistance(List<Car> takeListCars, string model, double distanceToMove)
    {
        var filterModels = takeListCars
            .Where(x => x.model == model)
            .ToList();
        var currentCar = filterModels[0];
        //To do
        var maxTravelDistance = currentCar.FuelAmount * currentCar.FuelConsumptionFor1km;

        if (maxTravelDistance >= distanceToMove)
        {
            currentCar.FuelAmount -= currentCar.FuelAmount;
            currentCar.DistanceTraveled += maxTravelDistance;

        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        return currentCar;
    }
}
