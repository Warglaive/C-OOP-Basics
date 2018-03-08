using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    public virtual double FuelQuantity { get; set; }
    public virtual double FuelConsumationPerKm { get; set; }
    public virtual double GivenDistance { get; set; }
    public virtual double RefuelAmount { get; set; }

    public void PrintIsEnoughtFuel(string type, double distance)
    {
        Console.WriteLine($"{type} travelled {distance} km");
        if (type == "Car")
        {
            this.FuelQuantity = this.FuelQuantity - distance * this.FuelConsumationPerKm;
        }
        else
        {
            this.FuelQuantity = this.FuelQuantity - distance * this.FuelConsumationPerKm;
        }
    }

    public void PrintNotEnoughFuel(string type)
    {
        Console.WriteLine($"{type} needs refueling");
    }
}