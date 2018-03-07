using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    public Truck(decimal fuelQuantity, decimal fuelConsumationPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumationPerKm = fuelConsumationPerKm;
    }

    public override decimal FuelQuantity
    {
        get { return base.FuelQuantity; }
        set { base.FuelQuantity = value + 1.6m; }
    }

    public override decimal FuelConsumationPerKm
    {
        get { return base.FuelConsumationPerKm; }
        set { base.FuelConsumationPerKm = value; }
    }
}