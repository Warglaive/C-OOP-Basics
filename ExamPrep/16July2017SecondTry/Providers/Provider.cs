using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider
{
    private string Id { get; set; }
    private double energyOutput;

    protected Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    protected double EnergyOutput
    {
        get { return energyOutput; }
        set
        {
            if (value >= 0 && value < 10000)
            {
                energyOutput = value;
            }
        }
    }
}