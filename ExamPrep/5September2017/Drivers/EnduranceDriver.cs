using System;
using System.Collections.Generic;
using System.Text;


public class EnduranceDriver : Driver
{
    public EnduranceDriver(string name, Car car, double fuelConsumptionPerKm)
        : base(name, car, 1.5)
    {
    }
}