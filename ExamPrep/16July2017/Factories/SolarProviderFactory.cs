using System;
using System.Collections.Generic;
using System.Text;


public class SolarProviderFactory
{
    public Solar GenerateSolarProvider(string id, double energyRequirement)
    {

        var solarProvider = new Solar(id, energyRequirement);
        return solarProvider;
    }
}