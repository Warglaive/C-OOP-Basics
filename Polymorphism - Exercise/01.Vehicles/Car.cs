using System;
using System.Collections.Generic;
using System.Text;


public class Car : IVehicle
{
    public Car(double fuelQuantity, double fuelConsumePerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumePerKm = fuelConsumePerKm + 0.9;
    }

    public double FuelQuantity { get; private set; }
    public double FuelConsumePerKm { get; private set; }

    public void Drive(double distance)
    {

        //check if fuel is enought for current distance
        var currentPossibleDistance = FuelQuantity / FuelConsumePerKm;
        var distanceNeeded = distance * FuelConsumePerKm;
        //
        if (currentPossibleDistance > distanceNeeded)
        {
            this.FuelQuantity -= distance * this.FuelConsumePerKm;
            Console.WriteLine($"Car travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"Car needs refueling");
        }
    }

    public void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"Car: {this.FuelQuantity:f2}";
    }
}