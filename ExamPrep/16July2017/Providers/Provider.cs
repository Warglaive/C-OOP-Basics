using System;
using System.Collections.Generic;
using System.Text;


public class Provider : IMiner
{
    public double energyOutput;
    public string Id { get; set; }

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
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException("EnergyOutput");
            }
            energyOutput = value;
        }
    }
}