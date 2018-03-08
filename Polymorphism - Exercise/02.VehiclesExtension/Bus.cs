using System;
using System.Collections.Generic;
using System.Text;

public class Bus : IVehicle
{
    private double fuelQuantity;
    public double TankCapacity { get; }
    public double FuelConsumePerKm { get; set; }

    public Bus(double fuelQuantity, double fuelConsumePerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumePerKm = fuelConsumePerKm;
    }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set
        {
            if (value > this.TankCapacity)
            {
                fuelQuantity = 0;
            }
            else
            {
                fuelQuantity = value;
            }
        }
    }
    public void Drive(double distance) // With people
    {
        //check if fuel is enought for current distance
        this.FuelConsumePerKm += 1.4;
        var currentPossibleDistance = FuelQuantity / FuelConsumePerKm;
        var distanceNeeded = distance * FuelConsumePerKm;
        //
        if (currentPossibleDistance >= distanceNeeded)
        {
            this.FuelQuantity -= distance * this.FuelConsumePerKm;
            Console.WriteLine($"Bus travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"Bus needs refueling");
        }
    }

    public void DriveEmpty(double distance)
    {
        //check if fuel is enought for current distance
        this.FuelConsumePerKm -= 1.4;
        var currentPossibleDistance = FuelQuantity * FuelConsumePerKm;
        var distanceNeeded = distance * FuelConsumePerKm;
        //
        if (currentPossibleDistance > distanceNeeded)
        {
            this.FuelQuantity -= distance * this.FuelConsumePerKm;
            Console.WriteLine($"Bus travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"Bus needs refueling");
        }
    }
    public void Refuel(double liters, double tankCapacity)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            if (liters > tankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }
        }
    }
    public override string ToString()
    {
        return $"Bus: {this.FuelQuantity:f2}";
    }
}

