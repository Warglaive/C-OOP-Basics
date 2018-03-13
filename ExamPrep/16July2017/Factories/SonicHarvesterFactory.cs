using System;
using System.Collections.Generic;
using System.Text;


public class SonicHarvesterFactory
{
    public Sonic GenerateHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
    {
        var sonicHarvester = new Sonic(id, oreOutput, energyRequirement, sonicFactor);
        return sonicHarvester;
    }
}