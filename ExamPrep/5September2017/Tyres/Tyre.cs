﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Tyre
{
    private double degradation;

    protected Tyre(double hardness)
    {
        this.Hardness = hardness;
        this.Degradation = 100;
    }

    public abstract string Name { get; }

    protected double Hardness { get; }

    public virtual double Degradation
    {
        get => this.degradation;
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException("Tyre blowed up");
            }
            degradation = value;
        }
    }
}