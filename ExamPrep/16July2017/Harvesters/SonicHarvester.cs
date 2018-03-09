using System;
using System.Collections.Generic;
using System.Text;


public class SonicHarvester : Harvester
{
    private double sonicFactor;
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement /= this.SonicFactor;
    }

    private double SonicFactor
    {
        get { return sonicFactor; }
        set
        {
            sonicFactor = value;
        }
    }
}