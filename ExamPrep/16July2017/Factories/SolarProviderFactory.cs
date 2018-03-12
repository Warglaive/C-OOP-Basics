using System;
using System.Collections.Generic;
using System.Text;


public class SolarProviderFactory
{
    public SolarProvider GenerateSolarProvider(string id, double energyRequirement)
    {

        var solarProvider = new SolarProvider(id, energyRequirement);
        return solarProvider;
    }
}