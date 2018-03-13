using System;
using System.Collections.Generic;

public class DraftManager
{
    public List<Harvester> harvesters;
    public List<Provider> providers;
    public string mode;

    public DraftManager()
    {
        this.mode = "Full";
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
    }
    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var type = arguments[0];
            var id = arguments[1];
            var oreOutput = double.Parse(arguments[2]);
            var energyRequirement = double.Parse(arguments[3]);

            if (type == "Sonic")
            {
                //factory that return harvester
                var sonicHarvesterFactory = new SonicHarvesterFactory();
                var sonicFactor = int.Parse(arguments[4]);
                var sonicHarvester = sonicHarvesterFactory.GenerateHarvester(id, oreOutput, energyRequirement, sonicFactor);
                //add to list
                harvesters.Add(sonicHarvester);
                return $"Successfully registered {sonicHarvester.GetType().Name} Harvester - {sonicHarvester.Id}";
            }
            // if type == Hammer
            var hammerHarvesterFactory = new HammerHarvesterFactory();
            var hammerHarvester = hammerHarvesterFactory.GenerateHammerHarvester(id, oreOutput, energyRequirement);
            //add to list
            harvesters.Add(hammerHarvester);
            return $"Successfully registered {hammerHarvester.GetType().Name} Harvester - {hammerHarvester.Id}";
        }
        catch (Exception e)
        {
            return $"Harvester is not registered, because of it's {e.Message}";
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var type = arguments[0];
            var id = arguments[1];
            var energyRequirement = double.Parse(arguments[2]);

            if (type == "Solar")
            {
                var solarProviderFactory = new SolarProviderFactory();
                var solarProvider = solarProviderFactory.GenerateSolarProvider(id, energyRequirement);
                //add to list
                providers.Add(solarProvider);
                return $"Successfully registered {solarProvider.GetType().Name} Provider - {solarProvider.Id}";
            }
            else //Pressure
            {
                var pressureProviderFactory = new PressureProviderFactory();
                var pressureProvider = pressureProviderFactory.PressureProviderGenerator(id, energyRequirement);
                //add to list
                providers.Add(pressureProvider);
                return $"Successfully registered {pressureProvider.GetType().Name} Provider - {pressureProvider.Id}";
            }
        }
        catch (Exception e)
        {
            return $"Provider is not registered, because of it's {e.Message}";
        }
    }
    public string Day(double currentDayOre, double providedEnergy)
    {
        var dayMsg = "A day has passed." + Environment.NewLine +
                     $"Energy Provided: {providedEnergy}" + Environment.NewLine +
                     $"Plumbus Ore Mined: {currentDayOre}";
        return dayMsg;
    }
    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        var result = $"Successfully changed working mode to {this.mode} Mode";
        return result;
    }
    public string Check(List<string> arguments)
    {
        var result = string.Empty;
        var checkId = arguments[0];
        //search in harvesters
        foreach (var currentHarvester in harvesters)
        {
            if (checkId == currentHarvester.Id)
            {
                result += $"{currentHarvester.GetType().Name} Harvester - {checkId}"
                    + Environment.NewLine
                    + $"Ore Output: {currentHarvester.OreOutput}"
                    + Environment.NewLine
                    + $"Energy Requirement: {currentHarvester.EnergyRequirement}";
                return result;
            }
        }
        //search in providers
        foreach (var currentProvider in providers)
        {
            if (checkId == currentProvider.Id)
            {
                result += $"{currentProvider.GetType().Name} Provider - {checkId}"
                    + Environment.NewLine
                    + $"Energy Output: {currentProvider.EnergyOutput}";
                return result;
            }
        }
        return $"No element found with id - {checkId}";
    }
    public string ShutDown()
    {
        var result = string.Empty;
        result += "System Shutdown"
                  + Environment.NewLine;
        return result;
    }
}