﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Driver
{
    private string name;
    private double totalTime;
    private Car car;
    private double fuelConsumptionPerKm;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public double TotalTime
    {
        get { return totalTime; }
        private set { totalTime = value; }
    }


    public Car Car
    {
        get { return car; }
        private set { car = value; }
    }


    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        private set { fuelConsumptionPerKm = value; }
    }

    protected virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

    protected Driver(string name, Car car, double fuelConsumptionPerKm)
    {
        this.Name = name;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }
}