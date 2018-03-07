using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicle
{
    public Car(decimal fuelQuantity, decimal fuelConsumationPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumationPerKm = fuelConsumationPerKm;
    }
    public override decimal FuelConsumationPerKm
    {
        get => base.FuelConsumationPerKm;
        set => base.FuelConsumationPerKm = value;
    }

    public override decimal FuelQuantity
    {
        get => base.FuelQuantity;
        set { base.FuelQuantity = value + 0.9m; }
    }

    public void PrintNotEnought(string vehicleType, decimal distance)
    {
        throw new NotImplementedException();
    }
}