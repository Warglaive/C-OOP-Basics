using System;
using System.Collections.Generic;
using System.Text;


public class Truck : IVehicle
{
    public Truck(double fuelQuantity, double fuelConsumePerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumePerKm = fuelConsumePerKm + 1.6;
    }
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
                liters *= 0.95;
                this.FuelQuantity += liters;
            }
        }
    }

    public override string ToString()
    {
        return $"Truck: {this.FuelQuantity:f2}";
    }
}