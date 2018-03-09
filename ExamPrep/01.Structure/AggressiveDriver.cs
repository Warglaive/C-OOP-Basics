using System;
using System.Collections.Generic;
using System.Text;


public class AggressiveDriver : IDrivers
{
    public AggressiveDriver(string name, double totalTime, Car car, double fuelConsumptionPerKm, double speed)
    {
        this.Name = name;
        this.TotalTime = totalTime;
        this.Car = car;
        this.FuelConsumptionPerKm = 2.7;
        this.Speed = speed * 1.3;
    }

    public string Name { get; }
    public double TotalTime { get; }
    public Car Car { get; }
    public double FuelConsumptionPerKm { get; }
    public double Speed { get; }
}