using System;
using System.Collections.Generic;
using System.Text;


public class EnduranceDriver : IDrivers
{
    public EnduranceDriver(string name, double totalTime, Car car, double fuelConsumptionPerKm, double speed)
    {
        this.Name = name;
        this.TotalTime = totalTime;
        this.Car = car;
        this.FuelConsumptionPerKm = 1.5;
        this.Speed = speed;
    }

    public string Name { get; }
    public double TotalTime { get; }
    public Car Car { get; }
    public double FuelConsumptionPerKm { get; }
    public double Speed { get; }
}