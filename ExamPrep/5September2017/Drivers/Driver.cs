using System;
using System.Collections.Generic;
using System.Text;


public abstract class Driver
{
    private string name;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    private double totalTime;

    public double TotalTime
    {
        get { return totalTime; }
        protected set { totalTime = value; }
    }

    private Car car;

    public Car Car
    {
        get { return car; }
        private set { car = value; }
    }

    private double fuelConsumptionPerKm;

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        protected set { fuelConsumptionPerKm = value; }
    }

    private double speed;

    public double Speed
    {
        get { return speed; }
        protected set
        {
            //Speed = “(car’s Hp + tyre’s degradation) / car’s fuelAmount”
            speed = value;
        }
    }

    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.Car = car;
    }
}