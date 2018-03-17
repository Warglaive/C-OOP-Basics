using System;
using System.Collections.Generic;
using System.Text;


public class SonicHarvester : Harvester
{
    public SonicHarvester(string id, double oreOutput
        , double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement / sonicFactor)
    {
        if (energyRequirement > 10000)
        {
            throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
        }
    }
}