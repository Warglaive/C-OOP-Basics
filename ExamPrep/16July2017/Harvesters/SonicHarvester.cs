using System;
using System.Collections.Generic;
using System.Text;

public class SonicHarvester : Harvester
{
    private int sonicFactor;
    public SonicHarvester(string id, double oreOutput,
        double energyRequirement, int sonicFactor)

        : base(id, oreOutput, energyRequirement)
    {
        this.SonicFactor = sonicFactor;
        this.EnergyRequirement = energyRequirement / sonicFactor;
    }

    private int SonicFactor
    {
        get { return sonicFactor; }
        set
        {
            sonicFactor = value;
        }
    }
}