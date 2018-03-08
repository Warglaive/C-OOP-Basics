using System;
using System.Collections.Generic;
using System.Text;


public class Truck : IVehicle
{
    public Truck(double fuelQuantity, double fuelConsumePerKm)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumePerKm = fuelConsumePerKm + 1.6;
    }
    public double FuelQuantity { get; private set; }
    public double FuelConsumePerKm { get; private set; }

    public void Drive(double distance)
    {
        //check if fuel is enought for current distance

        if (distance * FuelConsumePerKm > FuelQuantity)
        {
            Console.WriteLine($"Truck needs refueling");
        }
        else
        {
            this.FuelQuantity -= distance * this.FuelConsumePerKm;
            Console.WriteLine($"Truck travelled {distance} km");
        }
    }

    public void Refuel(double liters)
    {
        liters *= 0.95;
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"Truck: {this.FuelQuantity:f2}";
    }
}