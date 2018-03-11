using System;
using System.Collections.Generic;
using System.Text;
public class DraftManager
{
    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var type = arguments[1];
            var id = arguments[2];
            var oreOutput = double.Parse(arguments[3]);
            var energyRequirement = double.Parse(arguments[4]);
            var sonicFactor = -1;

            if (type == "Sonic")
            {
                sonicFactor = int.Parse(arguments[5]);
                var sonicHarvester = new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
                return $"Successfully registered {sonicHarvester.GetType().Name} Harvester – {sonicHarvester.Id}";
            }
            else
            {
                var hammerHarvester = new HammerHarvester(id, oreOutput, energyRequirement);
                return $"Successfully registered {hammerHarvester.GetType().Name} Harvester – {hammerHarvester.Id}";
            }
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
                var solarProvider = new SolarProvider(id, energyRequirement);
                return $"Successfully registered {solarProvider.GetType().Name} Provider – {solarProvider.Id}";
            }
            else //Pressure
            {
                var pressureProvider = new PressureProvider(id, energyRequirement);
                return $"Successfully registered {pressureProvider.GetType().Name} Provider – {pressureProvider.Id}";
            }
        }
        catch (Exception e)
        {
            return $"Provider is not registered, because of it's {e.Message}";
        }
    }
    //string Day(List<Provider> providers, double providedEnery)
    //{

    //}
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