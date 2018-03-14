public class ProviderFactory
{
    public PressureProvider GeneratePressureProvider(string id, double energyOutput)
    {
        var pressureProvider = new PressureProvider(id, energyOutput);
        return pressureProvider;
    }
    public SolarProvider GenerateSolarProvider(string id, double energyRequirement)
    {
        var solarProvider = new SolarProvider(id, energyRequirement);
        return solarProvider;
    }
}