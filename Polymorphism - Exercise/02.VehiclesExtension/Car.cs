using System;
using System.Collections.Generic;
using System.Text;


public class Car : IVehicle
{
    public Car(double fuelQuantity, double fuelConsumePerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumePerKm = fuelConsumePerKm + 0.9;
    }

    //public double FuelQuantity { get; private set; }
    public double FuelConsumePerKm { get; }
    public double TankCapacity { get; }

    private double fuelQuantity;

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


    public void Drive(double distance)
    {
        //check if fuel is enought for current distance
        var currentPossibleDistance = FuelQuantity * FuelConsumePerKm;
        var distanceNeeded = distance * FuelConsumePerKm;
        //
        if (currentPossibleDistance >= distanceNeeded)
        {
            this.FuelQuantity -= distance * this.FuelConsumePerKm;
            Console.WriteLine($"Car travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"Car needs refueling");
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
        return $"Car: {this.FuelQuantity:f2}";
    }
}