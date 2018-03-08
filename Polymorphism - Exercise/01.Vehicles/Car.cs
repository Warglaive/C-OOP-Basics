using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumationPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumationPerKm = fuelConsumationPerKm + 0.9;
    }
    public override double FuelConsumationPerKm
    {
        get => base.FuelConsumationPerKm;
        set => base.FuelConsumationPerKm = value;
    }

    public override double FuelQuantity
    {
        get => base.FuelQuantity;
        set { base.FuelQuantity = value; }
    }
    public void Refuel(double refuelQuantity)
    {
        this.FuelQuantity += refuelQuantity;
    }
}