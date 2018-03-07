using System;
using System.Collections.Generic;
using System.Text;

public abstract class Vehicle
{
    public virtual decimal FuelQuantity { get; set; }
    public virtual decimal FuelConsumationPerKm { get; set; }
    public virtual decimal GivenDistance { get; set; }
    public virtual decimal RefuelAmount { get; set; }

    public void PrintEnought(string type, decimal distance)
    {
        Console.WriteLine($"{type} travelled {distance} km");
        this.FuelQuantity -= this.FuelConsumationPerKm * distance;
    }
}