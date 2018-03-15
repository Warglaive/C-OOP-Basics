using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private const int FuelCapacity = 160;
    private const int MinFuel = 0;

    private int hp;

    public int Hp
    {
        get { return hp; }
        private set { hp = value; }
    }
    private double fuelAmount;
    private Tyre tyre;

    public Tyre Tyre
    {
        get { return tyre; }
        private set { tyre = value; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        private set
        {
            if (value > FuelCapacity)
            {
                fuelAmount = FuelCapacity;
            }
            else if (value < MinFuel)
            {
                throw new ArgumentException("Out of fuel");
            }
            else
            {
                fuelAmount = value;
            }
        }
    }

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }
}