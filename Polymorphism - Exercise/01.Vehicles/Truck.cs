using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumationPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumationPerKm = fuelConsumationPerKm + 1.6;
    }

    public override double FuelQuantity
    {
        get { return base.FuelQuantity; }
        set { base.FuelQuantity = value; }
    }

    public override double FuelConsumationPerKm
    {
        get { return base.FuelConsumationPerKm; }
        set { base.FuelConsumationPerKm = value; }
    }
    public void Refuel(double refuelQuantity)
    {
        this.FuelQuantity += refuelQuantity;
    }
}