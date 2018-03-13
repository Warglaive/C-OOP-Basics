using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class DraftManager
{
    public List<Harvester> harvesters;
    public List<Provider> providers;
    public string mode;
    public double oreMined;

    public DraftManager()
    {
        this.mode = string.Empty;

        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
    }
    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var type = arguments[1];
            var id = arguments[2];
            var oreOutput = double.Parse(arguments[3]);
            var energyRequirement = double.Parse(arguments[4]);

            if (type == "Sonic")
            {
                //factory that return harvester
                var sonicHarvesterFactory = new SonicHarvesterFactory();
                var sonicFactor = int.Parse(arguments[5]);
                var sonicHarvester = sonicHarvesterFactory.GenerateHarvester(id, oreOutput, energyRequirement, sonicFactor);
                //add to list
                harvesters.Add(sonicHarvester);
                return $"Successfully registered {sonicHarvester.GetType().Name} Harvester – {sonicHarvester.Id}";
            }
            // if type == Hammer
            var hammerHarvesterFactory = new HammerHarvesterFactory();
            var hammerHarvester = hammerHarvesterFactory.GenerateHammerHarvester(id, oreOutput, energyRequirement);
            //add to list
            harvesters.Add(hammerHarvester);
            return $"Successfully registered {hammerHarvester.GetType().Name} Harvester – {hammerHarvester.Id}";
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
            var type = arguments[1];
            var id = arguments[2];
            var energyRequirement = double.Parse(arguments[3]);

            if (type == "Solar")
            {
                var solarProviderFactory = new SolarProviderFactory();
                var solarProvider = solarProviderFactory.GenerateSolarProvider(id, energyRequirement);
                //add to list
                providers.Add(solarProvider);
                return $"Successfully registered {solarProvider.GetType().Name} Provider – {solarProvider.Id}";
            }
            else //Pressure
            {
                var pressureProviderFactory = new PressureProviderFactory();
                var pressureProvider = pressureProviderFactory.PressureProviderGenerator(id, energyRequirement);
                //add to list
                providers.Add(pressureProvider);
                return $"Successfully registered {pressureProvider.GetType().Name} Provider – {pressureProvider.Id}";
            }
        }
        catch (Exception e)
        {
            return $"Provider is not registered, because of it's {e.Message}";
        }
    }
    public string Day(double totalOre, double providedEnergy)
    {
        var dayMsg = "A day has passed." + Environment.NewLine +
                     $"Energy Provided: {providedEnergy}" + Environment.NewLine +
                     $"Plumbus Ore Mined: {totalOre}";
        return dayMsg;
    }
    //string Mode(List<string> arguments)
    //{
    //    //TODO: Add some logic here …
    //}
    //string Check(List<string> arguments)
    //{
    //    //TODO: Add some logic here …
    //}
    //string ShutDown()
    //{
    //    //TODO: Add some logic here …
    //}
}