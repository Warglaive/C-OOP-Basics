using System;
using System.Collections.Generic;
using System.Text;


public class Provider
{
    private string id;
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

    private string Id
    {
        get { return id; }
        set { id = value; }
    }
}