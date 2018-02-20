﻿using System.Text;
class Engine
{
    private const string offset = "  ";

    public string model;
    private int power;
    private int displacement;
    private string efficiency;

    public Engine(string model, int power)
    {
        this.model = model;
        this.power = power;
        displacement = -1;
        efficiency = "n/a";
    }

    public Engine(string model, int power, int displacement)
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        efficiency = "n/a";
    }

    public Engine(string model, int power, string efficiency)
    {
        this.model = model;
        this.power = power;
        displacement = -1;
        this.efficiency = efficiency;
    }

    public Engine(string model, int power, int displacement, string efficiency)
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendFormat("{0}{1}:\n", offset, this.model);
        sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.power);
        sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.displacement == -1 ? "n/a" : this.displacement.ToString());
        sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.efficiency);

        return sb.ToString();
    }
}