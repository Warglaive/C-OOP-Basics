using System;
using System.Collections.Generic;
using System.Text;


public abstract class Tyre
{
    private string Name { get; }
    private double Hardness { get; }
    private double Degradation { get; }

    protected Tyre(string name, double hardness, int degradation)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = 100;
    }
}