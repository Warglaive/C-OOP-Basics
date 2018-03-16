using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DraftManager
{
    private string mode = "Full";
    private double totalProvidedEnergy;
    private double totalOreOutput;
    private Dictionary<string, Harvester> registeredHarvesters;
    private Dictionary<string, Provider> registeredProviders;

    public DraftManager()
    {
        registeredHarvesters = new Dictionary<string, Harvester>();
        registeredProviders = new Dictionary<string, Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);
        if (type == "Sonic")
        {
            var sonicFactor = int.Parse(arguments[4]);
            var sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
            registeredHarvesters.Add(sonicHarvester.Id, sonicHarvester);
            return $"Successfully registered {type} Harvester - {id}";
        }
        else
        {
            var hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
            registeredHarvesters.Add(hammerHarvester.Id, hammerHarvester);
            return $"Successfully registered {type} Harvester – {id}";
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);
        if (type == "Solar")
        {
            var solarProvider = new SolarProvider(id, energyOutput);
            registeredProviders.Add(solarProvider.Id, solarProvider);
            return $"Successfully registered {type} Provider – {id}";
        }
        else
        {
            var pressureProvider = new PressureProvider(id, energyOutput);
            registeredProviders.Add(pressureProvider.Id, pressureProvider);
            return $"Successfully registered {type} Provider – {id}";
        }
    }
    public string Day()
    {
        var energyProvidedDay = registeredProviders.Sum(p => p.Value.EnergyOutput);
        double oreOutputDay=0;
        totalProvidedEnergy += energyProvidedDay;

        var energyRequirement = registeredHarvesters.Sum(h => h.Value.EnergyRequirement);

        if (energyRequirement <= totalProvidedEnergy)
        {
            oreOutputDay = registeredHarvesters.Sum(o => o.Value.OreOutput);
            totalProvidedEnergy -= energyRequirement;
            totalOreOutput += registeredHarvesters.Sum(o => o.Value.OreOutput);
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
        return "";
    }
    public string Check(List<string> arguments)
    {
        var checkId = arguments[0];
        var result = registeredHarvesters.FirstOrDefault(h => h.Key == checkId);
        if (result.Key == null)
        {
            var newResult = registeredProviders.FirstOrDefault(p => p.Key == checkId);
            if (newResult.Key == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                //.
                return "";
            }
        }
        else
        {
            //
            return "";
        }
        return "";
    }

    public string ShutDown()
    {
        return $"{totalProvidedEnergy}";
    }
}