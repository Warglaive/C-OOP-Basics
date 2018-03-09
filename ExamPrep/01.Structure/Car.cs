using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private int Hp;
    private double fuelAmount;
    private Tyre tyre;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.HP = hp;
        this.FuelAmount = fuelAmount;
        if (fuelAmount < 0)
        {
            throw new ArgumentException("Fuel below 0");
        }
        this.Tyre = tyre;
    }

    public Tyre Tyre
    {
        get { return tyre; }
        set { tyre = value; }
    }


    public double FuelAmount
    {
        get { return fuelAmount; }
        set
        {
            //160 max capacity
            if (value > 160)
            {
                fuelAmount = 160;
            }
            else
            {
                fuelAmount = value;
            }
        }
    }

    public int HP
    {
        get { return Hp; }
        set { Hp = value; }
    }

}