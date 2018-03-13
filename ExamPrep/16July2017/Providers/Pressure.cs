public class Pressure : Provider
{
    public Pressure(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput *= 1.5;
    }
}