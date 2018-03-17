using System;
using System.Collections.Generic;
using System.Text;


public class ProviderFactory
{
    public Provider GenerateProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);
        if (type == "Solar")
        {
            var solarProvider = new SolarProvider(id, energyOutput);
            return solarProvider;
        }
        else
        {
            var pressureProvider = new PressureProvider(id, energyOutput);
            return pressureProvider;
        }
    }
}