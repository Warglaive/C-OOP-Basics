using System;
using System.Collections.Generic;
using System.Text;


public class HarvesterFactory
{
    public Harvester GenerateHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);
        if (type == "Sonic")
        {
            var sonicFactor = int.Parse(arguments[4]);
            var sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
            return sonicHarvester;
        }
        else
        {
            var hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
            return hammerHarvester;
        }
    }
}