using System;
using System.Collections.Generic;
using System.Text;


public class EnduranceDriver : Driver
{
    public EnduranceDriver(string name, Car car, double fuelConsumptionPerKm)
        : base(name, car, fuelConsumptionPerKm)
    {
        this.FuelConsumptionPerKm = 1.5;
    }
}