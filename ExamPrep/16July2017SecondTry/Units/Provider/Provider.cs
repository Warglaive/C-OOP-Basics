﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Provider : Unit
{
    private double energyOutput;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return energyOutput; }
        private set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }
    public override string ToString()
    {
        return $"{this.Type} Provider - {this.Id}"
               + Environment.NewLine
               + $"Energy Output: {this.EnergyOutput}";
    }
}