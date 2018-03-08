using System;
using System.Collections.Generic;
using System.Text;

public class Bus : IVehicle
{
    private double fuelQuantity;
    public double TankCapacity { get; }
    public double FuelConsumePerKm { get; private set; }

    public Bus(double fuelQuantity, double fuelConsumePerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        if (fuelQuantity > tankCapacity)
        {
            this.FuelQuantity = 0;
        }
        else
        {
            this.FuelQuantity = fuelQuantity;
        }
        this.FuelConsumePerKm = fuelConsumePerKm;
    }

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set
        {
            fuelQuantity = value;
        }
    }
    public void Drive(double distance) // With people
    {
        //check if fuel is enought for current distance
        var consumedFuel = distance * (this.FuelConsumePerKm + 1.4);
        if (consumedFuel > this.FuelQuantity)
        {
            Console.WriteLine($"Bus needs refueling");
        }
        else
        {
            this.FuelQuantity -= consumedFuel;
            Console.WriteLine($"Bus travelled {distance} km");
        }
    }

    public void DriveEmpty(double distance)
    {
        //check if fuel is enought for current distance
        if (distance * this.FuelConsumePerKm > this.FuelQuantity)
        {
            Console.WriteLine($"Bus needs refueling");
        }
        else
        {
            this.FuelQuantity -= distance * this.FuelConsumePerKm;
            Console.WriteLine($"Bus travelled {distance} km");
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

