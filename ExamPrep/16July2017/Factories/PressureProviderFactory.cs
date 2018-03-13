public class PressureProviderFactory
{
    public Pressure PressureProviderGenerator(string id, double energyOutput)
    {
        var pressureProvider = new Pressure(id, energyOutput);
        return pressureProvider;
    }
}