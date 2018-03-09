using System;
using System.Collections.Generic;
using System.Text;


public class Driver : IDrivers
{
    public Driver(string name, double totalTime, Car car, double fuelConsumptionPerKm, double speed)
    {
        this.Name = name;
        this.TotalTime = totalTime;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.Speed = speed;
    }

    public string Name { get; }
    public double TotalTime { get; }
    public Car Car { get; }
    public double FuelConsumptionPerKm { get; }
    public double Speed { get; }
}