using System;
using System.Collections.Generic;
using System.Text;


public class SonicHarvesterFactory
{
    public SonicHarvester GenerateHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
    {
        var sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        return sonicHarvester;
    }
}