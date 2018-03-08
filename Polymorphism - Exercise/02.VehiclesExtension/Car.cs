using System;
using System.Collections.Generic;
using System.Text;


public class Car : IVehicle
{
    public Car(double fuelQuantity, double fuelConsumePerKm, double tankCapacity)
    {
        if (fuelQuantity > tankCapacity)
        {
            this.FuelQuantity = 0;
        }
        else
        {
            this.FuelQuantity = fuelQuantity;
        }
        this.TankCapacity = tankCapacity;
        this.FuelConsumePerKm = fuelConsumePerKm + 0.9;
    }
    public double FuelConsumePerKm { get; }
    public double TankCapacity { get; }

    private double fuelQuantity;

    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set
        {
            fuelQuantity = value;
        }
    }
    public void Drive(double distance)
    {
        //check if fuel is enought for current distance
        if (distance * FuelConsumePerKm > FuelQuantity)
        {
            Console.WriteLine($"Car needs refueling");
        }
        else
        {
            this.FuelQuantity -= distance * this.FuelConsumePerKm;
            Console.WriteLine($"Car travelled {distance} km");
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