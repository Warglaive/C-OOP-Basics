using System;
using System.Collections.Generic;
using System.Text;


public class Provider : IMiner
{
    private double energyOutput;
    public string Id { get; set; }

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
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException("must be positive and <= 10000");
            }
            energyOutput = value;
        }
    }

}