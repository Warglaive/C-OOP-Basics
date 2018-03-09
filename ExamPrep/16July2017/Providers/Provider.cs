using System;
using System.Collections.Generic;
using System.Text;


public abstract class Provider
{
    private string id;
    private double energyOutput;

    public Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }
    public double EnergyOutput
    {
        get { return energyOutput; }
        set
        {
            if (value < 0 || value > 10000)
            {
            }
            else
            {
                energyOutput = value;
            }
        }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }
}