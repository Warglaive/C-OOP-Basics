using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DraftManager
{
    private string mode = "Full";
    private double totalProvidedEnergy;
    private double totalOreOutput;

    private double totalEnergyStored;

    private Dictionary<string, Harvester> registeredHarvesters;
    private Dictionary<string, Provider> registeredProviders;

    public DraftManager()
    {
        registeredHarvesters = new Dictionary<string, Harvester>();
        registeredProviders = new Dictionary<string, Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var factory = new HarvesterFactory();

        var type = arguments[0];
        if (type == "Sonic")
        {
            var sonicHarvester = factory.GenerateHarvester(arguments);
            registeredHarvesters.Add(sonicHarvester.Id, sonicHarvester);
            return $"Successfully registered {type} Harvester - {sonicHarvester.Id}";
        }
        else
        {
            var hammerHarvester = factory.GenerateHarvester(arguments);
            registeredHarvesters.Add(hammerHarvester.Id, hammerHarvester);
            return $"Successfully registered {type} Harvester - {hammerHarvester.Id}";
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        var factory = new ProviderFactory();

        var type = arguments[0];
        if (type == "Solar")
        {
            var solarProvider = factory.GenerateProvider(arguments);
            registeredProviders.Add(solarProvider.Id, solarProvider);
            return $"Successfully registered {type} Provider - {solarProvider.Id}";
        }
        else
        {
            var pressureProvider = factory.GenerateProvider(arguments);
            registeredProviders.Add(pressureProvider.Id, pressureProvider);
            return $"Successfully registered {type} Provider - {pressureProvider.Id}";
        }
    }
    public string Day()
    {
        var energyProvidedDay = registeredProviders.Sum(p => p.Value.EnergyOutput);
        double oreOutputDay = 0;
        totalProvidedEnergy += energyProvidedDay;

        var energyRequirement = registeredHarvesters.Sum(h => h.Value.EnergyRequirement);
        //mode check
        if (mode == "Half")
        {
            totalProvidedEnergy -= energyRequirement * 0.6;
            oreOutputDay = registeredHarvesters.Sum(o => o.Value.OreOutput) * 0.5;
        }
        else if (mode == "Energy")
        {
            oreOutputDay = 0;
        }

        if (energyRequirement < totalProvidedEnergy)
        {
            oreOutputDay = registeredHarvesters.Sum(o => o.Value.OreOutput);
            totalProvidedEnergy -= energyRequirement;
            totalOreOutput += oreOutputDay;
            //shutdown command
            totalEnergyStored = totalProvidedEnergy;
        }

        string result = "A day has passed."
                        + Environment.NewLine
                        + $"Energy Provided: {energyProvidedDay}"
                        + Environment.NewLine
                        + $"Plumbus Ore Mined: {oreOutputDay}";
        return result;
    }
    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var checkId = arguments[0];
        var harvester = registeredHarvesters.FirstOrDefault(h => h.Key == checkId);
        if (harvester.Key != null)
        {
            var type = harvester.Value.GetType();
            var typeResult = type.ToString();
            if (typeResult == "SonicHarvester")
            {
                typeResult = "Sonic";
            }
            else
            {
                typeResult = "Hammer";
            }
            var harvesterResult = $"{typeResult} Harvester - {harvester.Key}"
                + Environment.NewLine
                + $"Ore Output: {harvester.Value.OreOutput}"
                + Environment.NewLine
                + $"Energy Requirement: {harvester.Value.EnergyRequirement}";
            return harvesterResult;
        }
        var provider = registeredProviders.FirstOrDefault(h => h.Key == checkId);
        if (provider.Key != null)
        {
            var type = provider.Value.GetType();
            var typeResult = type.ToString();
            if (typeResult == "SolarProvider")
            {
                typeResult = "Solar";
            }
            else
            {
                typeResult = "Pressure";
            }
            var providerResult = $"{typeResult} Provider - {provider.Value.Id}"
                + Environment.NewLine
                + $"Energy Output: {provider.Value.EnergyOutput}";
            return providerResult;
        }
        else
        {
            return $"No element found with id - {checkId}";
        }
    }

    public string ShutDown()
    {
        return "System Shutdown"
            + Environment.NewLine
            + $"Total Energy Stored: {totalEnergyStored}"
            + Environment.NewLine
            + $"Total Mined Plumbus Ore: {totalOreOutput}";
    }
}