using System;
using System.Collections.Generic;
using System.Text;


public abstract class Tyre
{
    protected string Name { get; set; }
    private double Hardness { get; set; }
    private double degradation;
    //Upon each lap it’s degradation is reduced by the value of the hardness
    public double Degradation
    {
        get { return degradation; }
        protected set
        {
            value = 100;
            degradation = value;
            if (degradation < 0)
            {
                throw new ArgumentException("Tyre blowed up");
            }
        }
    }

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        //
        this.Degradation -= this.Hardness;
    }
}