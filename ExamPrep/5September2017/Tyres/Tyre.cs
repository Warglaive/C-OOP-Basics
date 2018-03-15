using System;
using System.Collections.Generic;
using System.Text;


public abstract class Tyre
{
    public string Name { get; }
    private double Hardness { get; }
    private double degradation;
    //Upon each lap it’s degradation is reduced by the value of the hardness
    public virtual double Degradation
    {
        get { return degradation; }
        protected set
        {
            if (degradation < 0)
            {
                throw new ArgumentException("Tyre blowed up");
            }
            degradation = value;
        }
    }

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        //
        this.Degradation = 100;
    }

    public virtual void ReduceDegradation()
    {
        this.Degradation -= this.Hardness;
    }
}