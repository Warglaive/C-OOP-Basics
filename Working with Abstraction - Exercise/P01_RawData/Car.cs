﻿using System.Collections.Generic;


public class Car
{
    public string model;
    public int engineSpeed;
    public int enginePower;
    public int cargoWeight;
    public string cargoType;

    public KeyValuePair<double, int>[] tires;
    public Car(string model,
        int engineSpeed,
        int enginePower,
        int cargoWeight,
        string cargoType,
        double tire1Pressure,
        int tire1Age,
        double tire2Pressure,
        int tire2Age,
        double tire3Pressure,
        int tire3Age,
        double tire4Pressure,
        int tire4Age)
    {
        this.model = model;
        this.engineSpeed = engineSpeed;
        this.enginePower = enginePower;
        this.cargoWeight = cargoWeight;
        this.cargoType = cargoType;
        this.tires = new[] { KeyValuePair.Create(tire1Pressure, tire1Age),
            KeyValuePair.Create(tire2Pressure, tire2Age),
            KeyValuePair.Create(tire3Pressure, tire3Age),
            KeyValuePair.Create(tire4Pressure, tire4Age) };
    }
}